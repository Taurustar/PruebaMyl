using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Even or Odd
/// </summary>
public class Question4 : MonoBehaviour {

    public int X;
    public GameObject questionLabel;
    public GameObject resultBox;
    public GameObject correct;
    public GameObject wrong;
    public GameObject confused;
    bool evenState;

    // Use this for initialization
    void Start()
    {

        X = Random.Range(1, 100);
        questionLabel.GetComponent<Text>().text = "What is the" + X.ToString() + " is Even or Odd?";
        evenState = X % 2 == 0? true : false;
    }

    public void CheckResult()
    {
        if (resultBox.GetComponent<InputField>().text.Equals("even",System.StringComparison.CurrentCultureIgnoreCase) || resultBox.GetComponent<InputField>().text.Equals("odd",System.StringComparison.CurrentCultureIgnoreCase))
        {
            bool even = resultBox.GetComponent<InputField>().text.Equals("even", System.StringComparison.CurrentCultureIgnoreCase) ? true : false;
            if (even == evenState)
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
