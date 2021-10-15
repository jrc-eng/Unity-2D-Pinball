using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using TMPro;

public class PinballScore : MonoBehaviour
{
    GameManager gameManager;

    private long scoreTemp;

    private TextMeshProUGUI textMesh;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager != null)
        {
            scoreTemp = gameManager.GetScore();

            textMesh.text = scoreTemp + "";
        }
    }
}
