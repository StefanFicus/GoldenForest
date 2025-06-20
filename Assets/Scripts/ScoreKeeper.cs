using UnityEngine;
using TMPro;
public class ScoreKeeper : MonoBehaviour
{
    public CollectApples Ihateyou;
    public TextMeshProUGUI Score;
    void Awake()
    {
        Score = GetComponent<TextMeshProUGUI>();
        Score.text = "Mere: 0";

    }
    void Update()
    {
        Score.text = "Mere: " + Ihateyou.ApplesCollected.ToString();

    }
}
