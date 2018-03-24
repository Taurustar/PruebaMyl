using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question9 : MonoBehaviour {


    public GameObject questionLabel;
    public GameObject resultBox;
    public GameObject correct;
    public GameObject wrong;
    public GameObject confused;
    string[] word = { "Short Message System", "Girlfriend" , "Facebook", "Mitos y Leyendas", "Laughing out loud" , "Frequently Asked questions" };
    int index;
    string response;


    // Use this for initialization
    void Start()
    {
        index = Random.Range(0, 6);
        questionLabel.GetComponent<Text>().text = "Write the Acronym of " + word[index] + "?";
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
                case 0: response = "SMS"; break;
                case 1: response = "GF"; break;
                case 2: response = "FB"; break;
                case 3: response = "MYL"; break;
                case 4: response = "LOL"; break;
                case 5: response = "FAQ"; break;
            }

            if (resultBox.GetComponent<InputField>().text.Equals(response,System.StringComparison.CurrentCultureIgnoreCase))
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
