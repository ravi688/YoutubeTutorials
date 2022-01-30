using UnityEngine;
using UnityEngine.UI;

public class EllipseUI : Graphic
{
    [SerializeField]
    private float thickness = 40;
    [SerializeField]
    private int divisions = 20;
    [SerializeField]
    private float minorRadius = 200;
    [SerializeField]
    private float majorRadius = 300;

    protected override void OnPopulateMesh(VertexHelper vh)
    {
        base.OnPopulateMesh(vh);
        vh.Clear();
        UIVertex vertex = UIVertex.simpleVert;
        float deltaAngle = Mathf.PI * 2 / divisions;
        int vertexCount = divisions * 2;
        for(int i = 0; i < divisions; i++)
        {
            float angle = i * deltaAngle;
            // bottom right corner
            vertex.position = new Vector2(Mathf.Sin(angle) * (majorRadius - thickness), Mathf.Cos(angle) * (minorRadius - thickness));
            vh.AddVert(vertex);

            // top right corner
            vertex.position = new Vector2(Mathf.Sin(angle) * majorRadius, Mathf.Cos(angle) * minorRadius);
            vh.AddVert(vertex);

            int offset = i * 2;
            vh.AddTriangle(offset + 0, offset + 1, (offset + 3) % vertexCount);
            vh.AddTriangle((offset + 3) % vertexCount, (offset + 2) % vertexCount, offset + 0);
        }
    }
}
