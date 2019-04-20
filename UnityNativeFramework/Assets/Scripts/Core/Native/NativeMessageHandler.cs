/*
 * Description:             NativeMessageHandler.cs
 * Author:                  TONYTANG
 * Create Date:             2018/08/10
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// NativeMessageHandler.cs
/// ԭ����Ϣ��Ӧ������
/// </summary>
public class NativeMessageHandler : MonoBehaviour {

    /// <summary>
    /// ����ԭ����Ϣ
    /// </summary>
    /// <param name="msg"></param>
    public void resUnityMsg(string msg)
    {
        Debug.Log(string.Format("resUnityMsg : {0}", msg));
    }
}