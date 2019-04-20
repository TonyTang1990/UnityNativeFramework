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
/// 原生消息相应处理器
/// </summary>
public class NativeMessageHandler : MonoBehaviour {

    /// <summary>
    /// 接收原生消息
    /// </summary>
    /// <param name="msg"></param>
    public void resUnityMsg(string msg)
    {
        Debug.Log(string.Format("resUnityMsg : {0}", msg));
    }
}