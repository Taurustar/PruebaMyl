using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question10 : MonoBehaviour {

    public RandomQuestion QuestionManager;
    public GameObject questionLabel;
    public GameObject resultBox;
    public GameObject correct;
    public GameObject wrong;
    public GameObject confused;
    string[] word = { "Cat", "One", "Beer","Dog", "Force", "Blue"  };
    int index;
    string response;
    public Material wrongMat, correctMat, confusedMat, normalMat;
    public Color wrongColor = Color.yellow, correctColor = Color.green, confusedColor = Color.blue;
    public GameObject RobotEye, RobotLight,RobotBody;

    // Use this for initialization
    void Start()
    {
        index = Random.Range(0, 6);
        questionLabel.GetComponent<Text>().text = "Write an anagram of " + word[index] + "?";
    }

    public void CheckResult()
    {
        RobotLight.GetComponent<Light>().enabled = true;
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
                RobotEye.GetComponent<MeshRenderer>().material = correctMat;
                RobotLight.GetComponent<Light>().color = correctColor;
                StartCoroutine(OtherQuestion());
                RobotBody.GetComponent<Animation>().clip = RobotBody.GetComponent<Animation>().GetClip("Good");
                RobotBody.GetComponent<Animation>().Play();
            }
            else
            {
                wrong.SetActive(true);
                RobotEye.GetComponent<MeshRenderer>().material = wrongMat;
                RobotLight.GetComponent<Light>().color = wrongColor;
                StartCoroutine(OtherQuestion());
                RobotBody.GetComponent<Animation>().clip = RobotBody.GetComponent<Animation>().GetClip("Wrong");
                RobotBody.GetComponent<Animation>().Play();
            }
        }
        else
        {
            confused.SetActive(true);
            RobotEye.GetComponent<MeshRenderer>().material = confusedMat;
            RobotLight.GetComponent<Light>().color = confusedColor;
            StartCoroutine(QuestionAgain());
            RobotBody.GetComponent<Animation>().clip = RobotBody.GetComponent<Animation>().GetClip("Confused");
            RobotBody.GetComponent<Animation>().Play();
        }
    }

    IEnumerator QuestionAgain()
    {
        yield return new WaitForSeconds(3);
        confused.SetActive(false);
        RobotLight.GetComponent<Light>().enabled = false;
        RobotEye.GetComponent<MeshRenderer>().material = normalMat;
        RobotBody.GetComponent<Animation>().Stop();
    }

    IEnumerator OtherQuestion()
    {
        yield return new WaitForSeconds(3);
        confused.SetActive(false);
        wrong.SetActive(false);
        correct.SetActive(false);
        RobotLight.GetComponent<Light>().enabled = false;
        RobotEye.GetComponent<MeshRenderer>().material = normalMat;
        QuestionManager.TextChange();
        resultBox.GetComponent<InputField>().text = "";
        RobotBody.GetComponent<Animation>().Stop();
        Start();
    }
}
