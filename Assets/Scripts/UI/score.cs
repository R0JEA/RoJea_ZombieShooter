using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour

{

    public static int ScoreValue = 0;
    private Text scre;

    // Start is called before the first frame update
    void Start()
    {
        scre = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scre.text = "Kills: " + ScoreValue;
        if (ScoreValue == 15)
        {

            Debug.Log("You win");
            SceneManager.LoadScene("EndScene");
            ScoreValue = 0;
        }
    }
}
