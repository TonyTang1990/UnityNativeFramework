package com.tonytang.unitynativeframework;

import android.os.Bundle;

import android.app.Activity;
import android.content.Context;
import android.content.res.Configuration;
import android.util.Log;
import android.util.DisplayMetrics;

import com.unity3d.player.UnityPlayer;
import com.unity3d.player.UnityPlayerActivity;

public class MainActivity extends UnityPlayerActivity {

    public final static String mUnityCallBackHandler = "GameLuancher";

    public Context mContext = null;

    public Activity mCurrentActivity = null;

    private int mWidth;

    private int mHeight;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        Log.d("JNI", "onCreate()");
        mContext = this.getApplicationContext();
        mCurrentActivity = this;

        DisplayMetrics dm = getResources().getDisplayMetrics();
        mWidth = dm.widthPixels;
        mHeight = dm.heightPixels;
        Log.d("JNI","mWidth :" + mWidth);
        Log.d("JNI","mHeight :" + mHeight);
    }

    protected void onStart()
    {
        super.onStart();

        Log.d("JNI", "onStart()");
    }

    protected void onResume()
    {
        super.onResume();

        Log.d("JNI", "onResume()");
    }

    protected void onPause()
    {
        super.onPause();

        Log.d("JNI", "onPause()");
    }

    protected void onStop()
    {
        super.onStop();

        Log.d("JNI", "onStop()");
    }

    protected void onDestroy()
    {
        super.onDestroy();

        Log.d("JNI", "onDestroy()");
    }

    public void onWindowFocusChanged(boolean hasFocus)
    {
        super.onWindowFocusChanged(hasFocus);

        Log.d("JNI", "onWindowFocusChanged(" + hasFocus + ")");
    }

    @Override
    public void onConfigurationChanged(Configuration newConfig)
    {
        super.onConfigurationChanged(newConfig);
        Log.d("JNI","onConfigurationChanged()");
    }

    //Unity call part
    public void javaMethod(String csparam)
    {
        Log.d("JNI", "javaMethod() with parameter:" + csparam);
        UnityPlayer.UnitySendMessage(mUnityCallBackHandler,"resUnityMsg", "java param");
    }
}
