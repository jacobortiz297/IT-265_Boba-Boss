using UnityEngine;
using TMPro;

public class player : MonoBehaviour
{
    public int points;
    public TextMeshProUGUI pointText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = "Points: " + points.ToString();
    }
}
