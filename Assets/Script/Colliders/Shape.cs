using System;
using UnityEngine;

[System.Serializable]
public class Shape : MonoBehaviour
{
    public Vector2 originPoint;

    public event Action OnCollision = null;

    public virtual void DrawCollider()
    {

    }

    public virtual void Collide(Shape shape)
    {

    }
}
