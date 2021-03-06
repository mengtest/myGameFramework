/********************************************************************************
** auth:  https://github.com/HushengStudent
** date:  2018/01/10 23:22:57
** desc:  ECS组件抽象基类;
*********************************************************************************/

using MEC;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Framework
{
    /// <summary>
    /// 组件抽象基类;
    /// </summary>
    public class BaseComponent : IPool
    {
        protected BaseComponent() { }

        private long _id;
        private bool _enable = false;
        private BaseEntity _entity;
        private GameObject _componentGo = null;
        private Action<BaseComponent> _initCallBack;

        public long ID { get { return _id; } }
        public bool Enable { get { return _enable; } set { _enable = value; } }
        public BaseEntity Entity { get { return _entity; } set { _entity = value; } }
        public GameObject ComponentGo { get { return _componentGo; } set { _componentGo = value; } }
        public Action<BaseComponent> InitCallBack { get { return _initCallBack; } set { _initCallBack = value; } }

        public virtual void UpdateEx() { }
        public virtual void LateUpdateEx() { }

        /// <summary>
        /// 初始化Component;
        /// </summary>
        /// <param name="entity">entity</param>
        /// <param name="go">gameObject</param>
        public void Create(BaseEntity entity, GameObject go)
        {
            _id = IdGenerater.GenerateId();
            OnAttachEntity(entity);
            OnAttachComponentGo(go);
            EventSubscribe();
            OnInitComponent();
            _enable = true;
            if (InitCallBack != null)
            {
                InitCallBack(this);
            }
        }
        /// <summary>
        /// 重置Component;
        /// </summary>
        public void Reset()
        {
            DeAttachEntity();
            DeAttachComponentGo();
            EventUnsubscribe();
            OnResetComponent();
            _id = 0;
            _enable = false;
            _initCallBack = null;
        }
        /// <summary>
        /// 初始化;
        /// </summary>
        protected virtual void OnInitComponent() { }
        /// <summary>
        /// 重置;
        /// </summary>
        protected virtual void OnResetComponent() { }
        /// <summary>
        /// Component附加Entity;
        /// </summary>
        /// <param name="entity"></param>
        protected virtual void OnAttachEntity(BaseEntity entity)
        {
            _entity = entity;
        }
        /// <summary>
        /// Component附加GameObject;
        /// </summary>
        /// <param name="go"></param>
        protected virtual void OnAttachComponentGo(GameObject go)
        {
            _componentGo = go;
        }
        /// <summary>
        /// 重置Entity的附加;
        /// </summary>
        protected virtual void DeAttachEntity()
        {
            _entity = null;
        }
        /// <summary>
        /// 重置GameObject的附加;
        /// </summary>
        protected virtual void DeAttachComponentGo()
        {
            _componentGo = null;
        }
        /// <summary>
        /// 注册事件;
        /// </summary>
        protected virtual void EventSubscribe() { }
        /// <summary>
        /// 注销事件;
        /// </summary>
        protected virtual void EventUnsubscribe() { }
        /// <summary>
        /// 进入场景;
        /// </summary>
        /// <param name="sceneId"></param>
        protected virtual void OnEnterScene(int sceneId) { }
        /// <summary>
        /// 离开场景;
        /// </summary>
        /// <param name="sceneId"></param>
        protected virtual void OnExitScene(int sceneId) { }
        /// <summary>
        /// 对象池Get;
        /// </summary>
        /// <param name="args"></param>
        public virtual void OnGet(params System.Object[] args) { }
        /// <summary>
        /// 对象池Release;
        /// </summary>
        public virtual void OnRelease() { }
    }
}
