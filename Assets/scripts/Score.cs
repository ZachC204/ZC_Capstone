using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    int s = 0;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = s.ToString("0");
        s++;
    }
}
