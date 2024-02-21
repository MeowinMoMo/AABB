public static class CollisionLibrary
{
     public static bool DidCollide(Shape shape, BoxCollision box)
    {
        return true;
    }

    public static bool DidCollide(BoxCollision box1, BoxCollision box2)
    {
        return BoxCheck(box1.xMin, box1.xMax, box2.xMin, box2.xMax) &&
            BoxCheck(box1.yMin, box1.yMax, box2.yMin, box2.yMax);
    }
    public static bool DidCollide(SphereCollision sphere,BoxCollision box )
    {
        return true;
    }

    private static bool BoxCheck(float minA, float maxA, float minB, float maxB)
    {
        return maxA >= minB && minA <= maxB;
    }
}
