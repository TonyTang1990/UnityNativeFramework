/*
 * Description:             NativeManager.cs
 * Author:                  TONYTANG
 * Create Date:             2018/08/12
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// NativeManager.cs
/// ԭ���ӿڹ�������
/// </summary>
public abstract class NativeManager{

    /// <summary>
    /// ԭ���ӿڵ�������
    /// </summary>
    public static NativeManager Singleton
    {
        get
        {
            if (mNativeManagerSingleton == null)
            {
#if UNITY_ANDROID
                mNativeManagerSingleton = new AndroidNativeManager();
#elif UNITY_IOS
                mNativeManagerSingleton = new IOSNativeManager();
#endif
            }
            return mNativeManagerSingleton;
        }
    }
    private static NativeManager mNativeManagerSingleton;

    /// <summary>
    /// ��ʼ��
    /// </summary>
    public abstract void init();

    /// <summary>
    /// ����ԭ������
    /// </summary>
    public abstract void callNativeMethod();
}