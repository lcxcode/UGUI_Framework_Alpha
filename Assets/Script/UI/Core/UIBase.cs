using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  abstract class UIBase : MonoBehaviour 
{

    public enum WindowsType
    {
		Fixed,//固定不动的，如hud页面
        Normal,//全屏的，隐藏前一个
        PopUp,//弹窗之类的，不隐藏前一个
    }

    public WindowsType m_WindowsType = WindowsType.Fixed;

    [HideInInspector]
    public int m_UDID;

    [HideInInspector]
    public int m_WindowsID;

    protected virtual void OnEnter()
    {}

    protected virtual void OnPause()
    {}

    protected virtual void OnResume()
    {}

    protected virtual void OnExit()
    {}


}//end class
