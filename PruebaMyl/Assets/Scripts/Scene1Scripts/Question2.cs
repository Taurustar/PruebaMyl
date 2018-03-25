using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



/// <summary>
/// Question 2: Find X Fibonacci number
/// </summary>
public class Question2 : MonoBehaviour {


    public int X;
    public GameObject questionLabel;
    public GameObject resultBox;
    public int result;
    public GameObject correct;
    public GameObject wrong;
    public GameObject confused;
    int[] fibonacci = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };

	// Use this for initialization
	void Start () {

        X = Random.Range(1, 11);
        questionLabel.GetComponent<Text>().text = "What is the" + X.ToString() + " number in the Fibonacci Sequence ?";
	}

    public void CheckResult()
    {
        if (int.TryParse(resultBox.GetComponent<InputField>().text, out result))
        {
            if (result == fibonacci[X-1])
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
	void Update () {

	}
}
