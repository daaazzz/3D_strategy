using UnityEngine;

public class ShaderTest : MonoBehaviour
{
    [SerializeField] private float m_frequency = 1f;
    [SerializeField] private float m_phaseOffset = 0f;
    [SerializeField] private string m_Alpha = "_Alpha";

    private Renderer m_rend;
    private MaterialPropertyBlock m_propBlock;
    private int m_propId;

    void Start()
    {
        m_rend = GetComponent<Renderer>();
        m_propBlock = new MaterialPropertyBlock();
        m_propId = Shader.PropertyToID(m_Alpha);
    }

    // Update is called once per frame
    void Update()
    {
        float alpha = (Mathf.Sin(Time.time * m_frequency + m_phaseOffset) * 0.5f + 0.5f);
        m_propBlock.SetFloat(m_propId, alpha);
        m_rend.SetPropertyBlock(m_propBlock);
    }
}
