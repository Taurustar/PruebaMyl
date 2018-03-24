using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question10 : MonoBehaviour {

    public GameObject questionLabel;
    public GameObject resultBox;
    public GameObject correct;
    public GameObject wrong;
    public GameObject confused;
    string[] word = { "Cat", "One", "Beer","Dog", "Force", "Blue"  };
    int index;
    string response;


    // Use this for initialization
    void Start()
    {
        index = Random.Range(0, 6);
        questionLabel.GetComponent<Text>().text = "Write an anagram of " + word[index] + "?";
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
            switch (index)
            {
                case 0: response = "Act"; break;
                case 1: response = "Eon"; break;
                case 2: response = "Be Re"; break;
                case 3: response = "God"; break;
                case 4: response = "Rec Of"; break;
                case 5: response = "Lube"; break;
            }

            if (resultBox.GetComponent<InputField>().text.Equals(response, System.StringComparison.CurrentCultureIgnoreCase))
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
}
