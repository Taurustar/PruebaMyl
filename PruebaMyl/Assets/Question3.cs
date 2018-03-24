using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Power
/// </summary>
public class Question3 : MonoBehaviour {
    public int X, Y;
    public GameObject questionLabel;
    public GameObject resultBox;
    public int result;
    public GameObject correct;
    public GameObject wrong;
    public GameObject confused;
    // Use this for initialization
    void Start()
    {

        X = Random.Range(0, 100);
        Y = Random.Range(0, 100);
        questionLabel.GetComponent<Text>().text = "How much is " + X.ToString() + " x " + Y.ToString() + "?";

    }

    public void CheckResult()
    {
        if (int.TryParse(resultBox.GetComponent<InputField>().text, out result))
        {
            if (result == X * Y)
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
