using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
[RequireComponent(typeof(GraphicRaycaster))]
[DisallowMultipleComponent]
public class UIManager : MonoBehaviour
{
    /// <summary>
    /// The m normal transform.放置普通全屏的ui
    /// </summary>
    private RectTransform m_NormalTransform;

    /// <summary>
    /// The m fixed transform.放置固定UI
    /// </summary>
    private RectTransform m_FixedTransform;

    /// <summary>
    /// The m pop up transform.带有canvas组件方便显示在最上层；
    /// </summary>
    private RectTransform m_PopUpTransform;

    private Transform m_Transform;

    private void Awake()
    {
        m_Transform = transform;
        m_NormalTransform = m_Transform.Find("Normal").GetComponent<RectTransform>();
        m_FixedTransform = m_Transform.Find("Fixed").GetComponent<RectTransform>();
        m_PopUpTransform = m_Transform.Find("PopUp").GetComponent<RectTransform>();
    }

    public void SwitchWindow(int windowID)
    {
        
    }





}//end class
