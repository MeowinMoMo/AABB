using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public Shape MainCharacter;
    private void Awake()
    {
        MainCharacter = GetComponent<Shape>();
        var Colliders = FindObjectsOfType<Shape>();
    }
    private void Update()
    {
        var Colliders = FindObjectsOfType<Shape>();

        foreach (var c in Colliders)
        {
            
            if (MainCharacter == c) continue;
            if( CheckCollision(MainCharacter, c))
            {
                Debug.LogError("Collision Detected");
            }
        }
    }

    private bool CheckCollision(Shape shapeA, Shape shapeB)
    {
        if(shapeA is BoxCollision && shapeB is BoxCollision)
        {
            var boxA = (BoxCollision)shapeA;
            var boxB = (BoxCollision)shapeB;
            return CollisionLibrary.DidCollide(boxA, boxB);
        }

        return false;
    }

    private void OnDrawGizmos()
    {
        var Colliders = FindObjectsOfType<Shape>();
        foreach (var c in Colliders)
        {
            c.DrawCollider();
        }
    }
}
