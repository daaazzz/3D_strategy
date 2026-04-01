using UnityEngine;

public class UnitSelection : MonoBehaviour
{
    [SerializeField] private LayerMask m_layerMask;
    [SerializeField] private Outline m_outline;

    [Header("On Hover")]
    [SerializeField][Range(0f, 10f)] private float m_hoverOutlineWidth;
    [SerializeField] private Color m_hoverOutlineColor;

    [Header("On select")]
    [SerializeField][Range(0f, 10f)] private float m_selectOutlineWidth;
    [SerializeField] private Color m_selectOutlineColor;


    private void Awake()
    {
        m_outline.OutlineWidth = 0f;
    }

    public void OnHoverEnter()
    {
        m_outline.OutlineWidth = m_hoverOutlineWidth;
        m_outline.OutlineColor = m_hoverOutlineColor;
    }

    public void OnHoverExit()
    {
        m_outline.OutlineWidth = 0f;
    } 

    public void OnSelect()
    {
        m_outline.OutlineWidth = m_selectOutlineWidth;
        m_outline.OutlineColor = m_selectOutlineColor;
    }

    public void OnDeselect()
    {
        m_outline.OutlineWidth = 0f;
    }
}
