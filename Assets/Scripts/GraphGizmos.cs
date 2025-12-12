using System;
using UnityEngine;

public class GraphGizmos : MonoBehaviour {
    public float lineLen = 1f;
    private void OnDrawGizmos()
    {
        Node[] nodes = GetComponentsInChildren<Node>();
        foreach (Node node in nodes)
        {
            Vector3 basePos = node.transform.position;

            if (node.availableDirections != null)
            {
                foreach (Vector2 dir in node.availableDirections)
                {
                    Vector3 endPos = basePos + new Vector3(dir.x, dir.y, 0f) * lineLen;

                    Gizmos.color = Color.red;
                    Gizmos.DrawLine(basePos, endPos);
                }
            }
        }
    }
}
