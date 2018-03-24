using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomQuestion : MonoBehaviour {

    GameObject[] Questions;
    GameObject[] texts;
    int currentText;
    int currentQuestion;

    void Start()
    {
        currentQuestion = Random.Range(0, Questions.Length - 1);
        currentText = 0;
        texts[currentText].SetActive(true);
    }


    void QuestionChange()
    {
        currentText++;
        if(currentText >= texts.Length - 1)
        {
            currentText = texts.Length - 1;
            StartCoroutine(GoToQuestion());
        }
    }

    IEnumerator GoToQuestion()
    {
        Questions[currentQuestion].SetActive(false);
        yield return new WaitForEndOfFrame();
        currentQuestion = Random.Range(0, Questions.Length - 1);
        Questions[currentQuestion].SetActive(true);
    }
}
