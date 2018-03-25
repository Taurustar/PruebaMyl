using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question6 : MonoBehaviour {


    public GameObject questionLabel;
    public GameObject resultBox;
    public GameObject correct;
    public GameObject wrong;
    public GameObject confused;


    // Use this for initialization
    void Start()
    {


        questionLabel.GetComponent<Text>().text = "Write a Palindrome";

    }

    public void CheckResult()
    {
        if (!resultBox.GetComponent<InputField>().text.Contains("1") &&
            !resultBox.GetComponent<InputField>().text.Contains("2") &&
            !resultBox.GetComponent<InputField>().text.Contains("3") &&
            !resultBox.GetComponent<InputField>().text.Contains("4") &&
            !resultBox.GetComponent<InputField>().text.Contains("5") &&
            !resultBox.GetComponent<InputField>().text.Contains("6") &&
            !resultBox.GetComponent<InputField>().text.Contains("7") &&
            !resultBox.GetComponent<InputField>().text.Contains("8") &&
            !resultBox.GetComponent<InputField>().text.Contains("9") &&
            !resultBox.GetComponent<InputField>().text.Contains("0"))
        {

            
            char[] charArray = resultBox.GetComponent<InputField>().text.ToCharArray();
            Array.Reverse( charArray );
            string reversedString = new string(charArray);

          if (resultBox.GetComponent<InputField>().text.Equals(reversedString,StringComparison.CurrentCultureIgnoreCase))
            {
                correct.SetActive(true);
                //TODO: LightChange
            }
            else
            {
                wrong.SetActive(true);
                //TODO: LightChange
            }
        }
        else
        {
            confused.SetActive(true);
            //TODO: LightChange
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
