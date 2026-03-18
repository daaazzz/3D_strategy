using UnityEngine;

public class Cell : MonoBehaviour
{
    [Header("Current cell data")]
    [SerializeField] private CellData m_cellData;
    private Vector2Int m_coords;
    private bool isOccupied = false;

    public Vector2Int coords { get { return m_coords; } set { m_coords = value; } }
}
