using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// What's my purpose?
/// </summary>

public class Question5 : MonoBehaviour {

    public RandomQuestion QuestionManager;
    public GameObject questionLabel;
    public GameObject resultBox;
    public GameObject correct;
    public GameObject wrong;
    public GameObject confused;
    public Material wrongMat, correctMat, confusedMat, normalMat;
    public Color wrongColor = Color.yellow, correctColor = Color.green, confusedColor = Color.blue;
    public GameObject RobotEye, RobotLight, RobotBody;

    // Use this for initialization
    void Start()
    {

        questionLabel.GetComponent<Text>().text = "What is my purpose?";

    }

    public void CheckResult()
    {
        RobotLight.GetComponent<Light>().enabled = true;
        resultBox.GetComponent<InputField>().text = resultBox.GetComponent<InputField>().text.ToLower();
        if (resultBox.GetComponent<InputField>().text.Contains("give") && resultBox.GetComponent<InputField>().text.Contains("butter") || resultBox.GetComponent<InputField>().text.Contains("make") && resultBox.GetComponent<InputField>().text.Contains("questions"))
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
        
        if (resultBox.GetComponent<InputField>().text.Equals("be my friend", System.StringComparison.CurrentCultureIgnoreCase))
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
