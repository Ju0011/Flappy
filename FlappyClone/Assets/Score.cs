using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    TextMeshProUGUI resourceText;
    public static int score = 0;
    public static int bestscore = 0;
    // Start is called before the first frame update
    void Start()
    {
        //resourceText = GetComponent<TextMeshProUGUI>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = score.ToString(); //str(score) ÆÄÀÌ½ã
    }
}
