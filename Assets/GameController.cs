using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public string randomOperator;
    public int answer;

    public int a;
    public int b;

    public GameObject question;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;

    public GameObject realAnswerOption;

	void Start () 
    {
        GenerateQuestion();
	}

    void Update()
    {

    }

    public void GenerateQuestion()
    {

        option1.GetComponent<TextMesh>().color = Color.white;
        option2.GetComponent<TextMesh>().color = Color.white;
        option3.GetComponent<TextMesh>().color = Color.white;

        int a = Random.Range(0, 100);
        int b = Random.Range(0, 100);

        int operatorNumber = Random.Range(0,3);
        
        if (operatorNumber == 0)
        {
            randomOperator = "+";
            answer = a + b;
        }
        else if (operatorNumber == 1)
        {
            randomOperator = "-";
            answer = a - b;
        }
        else if (operatorNumber == 2)
        {
            randomOperator = "*";
            answer = a * b;
        }

        int option = Random.Range(0, 3);
        
        if (option == 0)
        {
            realAnswerOption = option1;

            option1.GetComponent<TextMesh>().text = answer.ToString();
            option1.GetComponent<Option>().isCorrect = true;
            option2.GetComponent<TextMesh>().text = (answer + Random.Range(0, 3) * 2 - 1).ToString();
            option2.GetComponent<Option>().isCorrect = false;
            option3.GetComponent<TextMesh>().text = (answer + Random.Range(0, 3) * 2 - 1).ToString();
            option3.GetComponent<Option>().isCorrect = false;
        }
        else if (option == 1)
        {
            realAnswerOption = option2;

            option1.GetComponent<TextMesh>().text = (answer + Random.Range(0, 3) * 2 - 1).ToString();
            option1.GetComponent<Option>().isCorrect = false;
            option2.GetComponent<TextMesh>().text = answer.ToString();
            option2.GetComponent<Option>().isCorrect = true;
            option3.GetComponent<TextMesh>().text = (answer + Random.Range(0, 3) * 2 - 1).ToString();
            option3.GetComponent<Option>().isCorrect = false;
        }
        else
        {
            realAnswerOption = option3;

            option1.GetComponent<TextMesh>().text = (answer + Random.Range(0, 3) * 2 - 1).ToString();
            option1.GetComponent<Option>().isCorrect = false;
            option2.GetComponent<TextMesh>().text = (answer + Random.Range(0, 3) * 2 - 1).ToString();
            option2.GetComponent<Option>().isCorrect = false;
            option3.GetComponent<TextMesh>().text = answer.ToString();
            option3.GetComponent<Option>().isCorrect = true;
        }

        question.GetComponent<TextMesh>().text = a + " " + randomOperator + " " + b + " = ?";
    }
}
