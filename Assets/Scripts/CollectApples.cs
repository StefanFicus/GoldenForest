using UnityEngine;

public class CollectApples : MonoBehaviour
{
    public int ApplesCollected;
    private bool PrasleainRange;
    private GameObject GoldAppleinRange;
    void Awake()
    {
        ApplesCollected = 0;
    }
    void OnTriggerEnter2D(Collider2D collectible)
    {
        if (collectible.CompareTag("GoldApple"))
        {
            PrasleainRange = true;
            GoldAppleinRange = collectible.gameObject;
        }

    }
    void OnTriggerExit2D(Collider2D collectible)
    {
        if (collectible.CompareTag("GoldApple"))
        { 
        PrasleainRange = false;
        GoldAppleinRange = null;
    }

    }
    void CollectDamnApples()
    {
        if (GoldAppleinRange != null)
        {
            ApplesCollected++;
            Destroy(GoldAppleinRange);
            PrasleainRange = false;
            GoldAppleinRange = null;

        }
    }
    void Update()
    { 
        if (PrasleainRange == true && Input.GetKeyDown(KeyCode.E))
            CollectDamnApples();


    }
}
