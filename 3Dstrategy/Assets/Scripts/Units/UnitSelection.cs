using UnityEngine;

public class UnitSelection : MonoBehaviour
{
    [SerializeField] private LayerMask m_layerMask;
    [SerializeField] private Outline m_outline;

    [Header("On Hover")]
    [SerializeField][Range(0f, 10f)] private float m_hoverOutlineWidth;
    [SerializeField] private Color m_hoverOutlineColor;

    void Update()
    {
        
    }

    public void OnHoverEnter()
    {
        m_outline.OutlineWidth = m_hoverOutlineWidth;
        m_outline.OutlineColor = m_hoverOutlineColor;
    }
}
