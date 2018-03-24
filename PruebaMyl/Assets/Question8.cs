using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question8 : MonoBehaviour {


    public GameObject questionLabel;
    public GameObject correct;
    public GameObject wrong;
    // Use this for initialization
    void Start()
    {
        questionLabel.GetComponent<Text>().text = "Which of these words is not a Synonym?";
    }

    public void CheckResult(int id)
    {

            if (id == 3)
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
}
