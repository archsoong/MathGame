using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public string randomOperator;
    public int answer;

    public int a;

    public GameObject question;
    public GameObject option1;
    public GameObject option2;

	void Start () 
    {
        // Random.InitState((int) System.DateTime.Now.Ticks);
        GenerateQuestion();
	}

    void Update()
    {

    }

    public void GenerateQuestion()
    {
        int a = Random.Range(0, 100);
        int b = Random.Range(0, 100);

        int operatorNumber = Random.Range(0,2);
        
        if (operatorNumber == 1)
        {
            randomOperator = "+";
            answer = a + b;
        }
        else if (operatorNumber == 2)
        {
            randomOperator = "-";
            answer = a - b;
        }

        int option = Random.Range(0, 2);
        
        if (option == 0)
        {
            option1.GetComponent<TextMesh>().text = answer.ToString();
            option1.GetComponent<Option>().isCorrect = true;

            option2.GetComponent<TextMesh>().text = (answer + Random.Range(-2, 2)).ToString();
            option2.GetComponent<Option>().isCorrect = false;
        }
        else
        {
            option1.GetComponent<TextMesh>().text = (answer + Random.Range(-2, 2)).ToString();
            option1.GetComponent<Option>().isCorrect = false;

            option2.GetComponent<TextMesh>().text = answer.ToString();
            option2.GetComponent<Option>().isCorrect = true;
        }

        question.GetComponent<TextMesh>().text = a + " " + randomOperator + " " + b + " = ?";
    }
}
