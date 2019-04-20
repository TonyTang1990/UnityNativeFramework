/*
 * Description:             AndroidNativeManager.cs
 * Author:                  TONYTANG
 * Create Date:             2018/08/10
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_ANDROID
/// <summary>
/// AndroidNativeManager.cs
/// Androidԭ��������
/// </summary>
public class AndroidNativeManager : NativeManager
{
    /// <summary>
    /// Android��Activity����
    /// </summary>
    private AndroidJavaObject mAndroidActivity;

    /// <summary>
    /// ��ʼ��
    /// </summary>
    public override void init()
    {
        Debug.Log("AndroidNativeManager:init()");
        if (Application.platform == RuntimePlatform.Android)
        {
            //����ʹ��using��Ŀ����ȷ��AndroidJavaClass���󾡿챻ɾ��
            using (AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            {
                //��õ�ǰActivity(������Ϊ�˻��MainActivity)
                mAndroidActivity = jc.GetStatic<AndroidJavaObject>("currentActivity");
                if (mAndroidActivity == null)
                {
                    Debug.Log("��ȡUnityMainActivity::mAndroidActivity��Աʧ�ܣ�");
                }
                else
                {
                    Debug.Log("��ȡUnityMainActivity::mAndroidActivity��Ա�ɹ�!");
                }
            }
        }
    }

    /// <summary>
    /// ����ԭ������
    /// </summary>
    public override void callNativeMethod()
    {
        Debug.Log("AndroidNativeManager:callNativeMethod()");
        if (mAndroidActivity != null)
        {
            mAndroidActivity.Call("javaMethod", "cs param");
        }
    }
}
#endif