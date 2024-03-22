using UnityEngine;
using Cinemachine;

public class SwitchConfinerBoundingShape : MonoBehaviour
{
    private void Start()
    {
        SwitchBoundingShape();
    }

    private void SwitchBoundingShape()
    {
        PolygonCollider2D collider = GameObject.FindGameObjectWithTag(Tags.BoundsConfiner).GetComponent<PolygonCollider2D>();
        CinemachineConfiner2D confiner = GetComponent<CinemachineConfiner2D>();
        confiner.m_BoundingShape2D = collider;
        confiner.InvalidateCache();
    }
}
