#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

public class ResizeGoldAppleColliders
{
    [MenuItem("Tools/Resize GoldApple Colliders")]
    static void ResizeColliders()
    {
        GameObject[] allObjects = GameObject.FindGameObjectsWithTag("GoldApple");
        int updated = 0;

        Debug.Log($"Found {allObjects.Length} GoldApple tagged objects.");

        foreach (GameObject obj in allObjects)
        {
            BoxCollider2D collider = obj.GetComponent<BoxCollider2D>();
            if (collider != null)
            {
                Undo.RecordObject(collider, "Resize GoldApple Collider");

                Vector2 oldSize = collider.size;
                collider.size = new Vector2(2f, 2f);
                collider.offset = Vector2.zero;
                EditorUtility.SetDirty(collider);

                Debug.Log($"{obj.name}: resized from {oldSize} to {collider.size}");
                updated++;
            }
        }
foreach (GameObject obj in allObjects)
{
    Collider2D col = obj.GetComponent<Collider2D>();
    if (col != null)
    {
        Debug.Log($"{obj.name} has a collider of type {col.GetType()}");
    }
    else
    {
        Debug.LogWarning($"{obj.name} has no Collider2D component");
    }
}

        Debug.Log($"✅ Resized {updated} colliders on tagged GoldApple objects.");
    }
}
#endif

