using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question1 : MonoBehaviour {

    public int X, Y;
    public GameObject questionLabel;
    public GameObject resultBox;
    public int result;
    public GameObject correct;
    public GameObject wrong;
    public GameObject confused;
	// Use this for initialization
	void Start () {

        X = Random.Range(0, 1500);
        Y = Random.Range(0, 1500);
        questionLabel.GetComponent<Text>().text = "How much is " + X.ToString() + " + " + Y.ToString() + "?";

	}

    public void CheckResult()
    {
        if(int.TryParse(resultBox.GetComponent<InputField>().text,out result))
        {
            if(result == X + Y)
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
