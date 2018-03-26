using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Question 1: Add
/// </summary>
public class RandomQuestion : MonoBehaviour {

    public GameObject[] Questions;
    public GameObject[] texts;
    public int currentText;
    public int currentQuestion;
    public GameObject ButtonToStart;

    void Start()
    {
        currentQuestion = Random.Range(0, Questions.Length - 1);
        currentText = 0;
        texts[currentText].SetActive(true);
    }

    void Update()
    {

    }

    public void TextChange()
    {
        texts[currentText].GetComponent<Canvas>().enabled = false;
        currentText++;
        if(currentText > texts.Length - 1)
        {
            currentText = texts.Length - 1;
            StartCoroutine(GoToQuestion());
        }
         texts[currentText].GetComponent<Canvas>().enabled = true;
    }

    IEnumerator GoToQuestion()
    {
        
        Questions[currentQuestion].GetComponent<Canvas>().enabled = false;
        yield return new WaitForEndOfFrame();
        currentQuestion = Random.Range(0, Questions.Length - 1);
        Questions[currentQuestion].GetComponent<Canvas>().enabled = true;
        texts[currentText].GetComponent<Canvas>().enabled = false;
        //ButtonToStart.GetComponent<Button>().enabled = false;
        ButtonToStart.GetComponent<Image>().raycastTarget = false;
    }
}
