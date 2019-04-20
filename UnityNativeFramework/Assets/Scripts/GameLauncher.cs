/*
 * Description:             游戏入口
 * Author:                  tanghuan
 * Create Date:             2018/03/12
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 游戏入口
/// </summary>
public class GameLauncher : MonoBehaviour {

    private void Awake()
    {
        Debug.Log("GameLauncher:Awake()");
        DontDestroyOnLoad(this);

        addMonoComponents();

        nativeInitilization();
    }

    private void Start () {
        Debug.Log("GameLauncher:Start()");
        VisibleLogUtility.Singleton.mVisibleLogSwitch = FastUIEntry.LogSwitch;
    }

    private void OnDestroy()
    {

    }

    /// <summary>
    /// 添加Mono相关的组件
    /// </summary>
    private void addMonoComponents()
    {
        //原生消息处理器
        gameObject.AddComponent<NativeMessageHandler>();
    }

    /// <summary>
    /// 原生初始化
    /// </summary>
    private void nativeInitilization()
    {
        NativeManager.Singleton.init();
    }

    /// <summary>
    /// 调用原生方法
    /// </summary>
    public void onCallNativeMethodClick()
    {
        Debug.Log("onCallNativeMethodClick()");
        NativeManager.Singleton.callNativeMethod();
    }
}
