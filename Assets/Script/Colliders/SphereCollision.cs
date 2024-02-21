using System.Diagnostics;
using UnityEngine;

public class SphereCollision : Shape
{
    public float Length;
    public float Width;
    public float Radius;

    public void InitSphere(float length, float width, Vector2 origin)
    {
        Length = length;
        Width = width;
        /*originPoint = transform.position;*/
        origin = this.originPoint;
        

    }
    public SphereCollision(float radius)
    {
        Radius = radius;
    }

    public override void DrawCollider()
    {
        base.DrawCollider();
        Gizmos.DrawWireSphere(originPoint , Radius);
    }
}
