using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWindowsBase : UIBase
{

    public Animator m_EnterAnim;
    public Animator m_ExitAnim;

    protected override void OnEnter()
    {
        base.OnEnter();
        //播放enter动画，执行动画回调，初始化界面信息
        //注册刷新事件，数值动画，数据刷新
    }

    protected override void OnPause()
    {
        base.OnPause();
        //暂停界面的刷新
    }

    protected override void OnResume()
    {
        base.OnResume();
        //唤醒界面，刷新数据
    }

    protected override void OnExit()
    {
        base.OnExit();
        //退出动画，执行动画回调
        //移除刷新事件
    }

}//END calss
