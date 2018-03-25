using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Country Capital
/// </summary>
public class Question7 : MonoBehaviour {

    public GameObject questionLabel;
    public GameObject resultBox;
    public GameObject correct;
    public GameObject wrong;
    public GameObject confused;
    string[] country = { "Chile", "Peru", "Bolivia", "Argentina", "Brazil", "Mexico" };
    int index;
    string capital;

    // Use this for initialization
    void Start()
    {
        index = Random.Range(0, 6);
        questionLabel.GetComponent<Text>().text = "What's the Capital of" + country[index]; ;

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
                case 0: capital = "Santiago"; break;
                case 1: capital = "Lima"; break;
                case 2: capital = "La Paz"; break;
                case 3: capital = "Buenos Aires"; break;
                case 4: capital = "Brasilia"; break;
                case 5: capital = "Mexico"; break;
           
            }

            if (resultBox.GetComponent<InputField>().text.Equals(capital,System.StringComparison.CurrentCultureIgnoreCase))
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
