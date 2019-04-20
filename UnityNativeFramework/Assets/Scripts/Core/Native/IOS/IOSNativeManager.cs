/*
 * Description:             IOSNativeManager.cs
 * Author:                  TONYTANG
 * Create Date:             2018/08/10
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_IOS
/// <summary>
/// IOSNativeManager.cs
/// IOSԭ��������
/// </summary>
public class IOSNativeManager : NativeManager {

    /// <summary>
    /// ��ʼ��
    /// </summary>
    public override void init()
    {
        Debug.Log("IOSNativeManager:init()");    
    }

    /// <summary>
    /// ����ԭ������
    /// </summary>
    public override void callNativeMethod()
    {
        Debug.Log("IOSNativeManager:init()");
    }
}
#endif