﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Framework_MonoSingleton_Framework_LuaMgrWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Framework.MonoSingleton<Framework.LuaMgr>), typeof(UnityEngine.MonoBehaviour), "MonoSingleton_Framework_LuaMgr");
		L.RegFunction("StartEx", StartEx);
		L.RegFunction("AwakeEx", AwakeEx);
		L.RegFunction("OnEnableEx", OnEnableEx);
		L.RegFunction("FixedUpdateEx", FixedUpdateEx);
		L.RegFunction("UpdateEx", UpdateEx);
		L.RegFunction("LateUpdateEx", LateUpdateEx);
		L.RegFunction("OnDisableEx", OnDisableEx);
		L.RegFunction("OnDestroyEx", OnDestroyEx);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Instance", get_Instance, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StartEx(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Framework.MonoSingleton<Framework.LuaMgr> obj = (Framework.MonoSingleton<Framework.LuaMgr>)ToLua.CheckObject<Framework.MonoSingleton<Framework.LuaMgr>>(L, 1);
			obj.StartEx();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AwakeEx(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Framework.MonoSingleton<Framework.LuaMgr> obj = (Framework.MonoSingleton<Framework.LuaMgr>)ToLua.CheckObject<Framework.MonoSingleton<Framework.LuaMgr>>(L, 1);
			obj.AwakeEx();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnEnableEx(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Framework.MonoSingleton<Framework.LuaMgr> obj = (Framework.MonoSingleton<Framework.LuaMgr>)ToLua.CheckObject<Framework.MonoSingleton<Framework.LuaMgr>>(L, 1);
			obj.OnEnableEx();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FixedUpdateEx(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Framework.MonoSingleton<Framework.LuaMgr> obj = (Framework.MonoSingleton<Framework.LuaMgr>)ToLua.CheckObject<Framework.MonoSingleton<Framework.LuaMgr>>(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.FixedUpdateEx(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateEx(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Framework.MonoSingleton<Framework.LuaMgr> obj = (Framework.MonoSingleton<Framework.LuaMgr>)ToLua.CheckObject<Framework.MonoSingleton<Framework.LuaMgr>>(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.UpdateEx(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LateUpdateEx(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Framework.MonoSingleton<Framework.LuaMgr> obj = (Framework.MonoSingleton<Framework.LuaMgr>)ToLua.CheckObject<Framework.MonoSingleton<Framework.LuaMgr>>(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.LateUpdateEx(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDisableEx(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Framework.MonoSingleton<Framework.LuaMgr> obj = (Framework.MonoSingleton<Framework.LuaMgr>)ToLua.CheckObject<Framework.MonoSingleton<Framework.LuaMgr>>(L, 1);
			obj.OnDisableEx();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDestroyEx(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Framework.MonoSingleton<Framework.LuaMgr> obj = (Framework.MonoSingleton<Framework.LuaMgr>)ToLua.CheckObject<Framework.MonoSingleton<Framework.LuaMgr>>(L, 1);
			obj.OnDestroyEx();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Instance(IntPtr L)
	{
		try
		{
			ToLua.Push(L, Framework.MonoSingleton<Framework.LuaMgr>.Instance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

