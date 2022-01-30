using UnityEngine;
using UnityEngine.UI;

public class EllipseUI : Graphic
{
    protected override void OnPopulateMesh(VertexHelper vh)
    {
        base.OnPopulateMesh(vh);
        UIVertex vertex = UIVertex.simpleVert;
        vertex.position = new Vector2(100, 100);         // top right corner
        vh.AddVert(vertex);
        vertex.position = new Vector3(-100, 100);        // top left corner
        vh.AddVert(vertex);
        vertex.position = new Vector3(-100, -100);       // bottom left corner
        vh.AddVert(vertex);
        vertex.position = new Vector3(100, -100);        // bottom right corner


        vh.AddTriangle(0, 1, 2);
        vh.AddTriangle(2, 3, 0);
    }
}
