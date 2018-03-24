using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// What's my purpose?
/// </summary>

public class Question5 : MonoBehaviour {


    public GameObject questionLabel;
    public GameObject resultBox;
    public GameObject correct;
    public GameObject wrong;
    public GameObject confused;


    // Use this for initialization
    void Start()
    {

        questionLabel.GetComponent<Text>().text = "What is my purpose?";

    }

    public void CheckResult()
    {
        if (resultBox.GetComponent<InputField>().text.Contains("give") && resultBox.GetComponent<InputField>().text.Contains("butter") && resultBox.GetComponent<InputField>().text.Contains("make") && resultBox.GetComponent<InputField>().text.Contains("questions"))
        {
            correct.SetActive(true);
            //TODO: LightChange
        }
        else
        {
            wrong.SetActive(true);
            //TODO: LightChange
        }
        
        if (resultBox.GetComponent<InputField>().text.Equals("be my friend", System.StringComparison.CurrentCultureIgnoreCase))
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
