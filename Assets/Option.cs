using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour {

    public GameObject core;
    public bool isCorrect ;

    void OnMouseDown()
    {
        if (isCorrect)
        {
            GetComponent<TextMesh>().color = Color.green;
        }
        else
        {
            GetComponent<TextMesh>().color = Color.red;
            core.GetComponent<GameController>().realAnswerOption.GetComponent<TextMesh>().color = new Color(0.7f,0.0f,0.7f,1);
        }
    }
}
