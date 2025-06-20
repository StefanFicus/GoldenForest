#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

public static class CheckGoldAppleColliders
{
    [MenuItem("Tools/Check GoldApple Colliders")]
    public static void CheckColliders()
    {
        GameObject[] allObjects = GameObject.FindGameObjectsWithTag("GoldApple");
        Debug.Log($"Found {allObjects.Length} GoldApple tagged objects.");

        foreach (GameObject obj in allObjects)
        {
            var collider2D = obj.GetComponent<Collider2D>();
            var collider3D = obj.GetComponent<Collider>();

            if (collider2D != null)
            {
                Debug.Log($"{obj.name} has a 2D collider of type {collider2D.GetType()} with size {(collider2D is BoxCollider2D box2D ? box2D.size.ToString() : "N/A")}");
            }
            else if (collider3D != null)
            {
                Debug.Log($"{obj.name} has a 3D collider of type {collider3D.GetType()}");
            }
            else
            {
                Debug.LogWarning($"{obj.name} has no collider component.");
            }
        }
    }
}
#endif

