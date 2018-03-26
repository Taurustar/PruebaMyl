using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Even or Odd
/// </summary>
public class Question4 : MonoBehaviour {

    public RandomQuestion QuestionManager;
    public int X;
    public GameObject questionLabel;
    public GameObject resultBox;
    public GameObject correct;
    public GameObject wrong;
    public GameObject confused;
    bool evenState;
    public Material wrongMat, correctMat, confusedMat, normalMat;
    public Color wrongColor = Color.yellow, correctColor = Color.green, confusedColor = Color.blue;
    public GameObject RobotEye, RobotLight, RobotBody;

    // Use this for initialization
    void Start()
    {

        X = Random.Range(1, 100);
        questionLabel.GetComponent<Text>().text = X.ToString() + " is Even or Odd?";
        evenState = X % 2 == 0? true : false;
    }

    public void CheckResult()
    {
        RobotLight.GetComponent<Light>().enabled = true;
        if (resultBox.GetComponent<InputField>().text.Equals("even",System.StringComparison.CurrentCultureIgnoreCase) || resultBox.GetComponent<InputField>().text.Equals("odd",System.StringComparison.CurrentCultureIgnoreCase))
        {
            bool even = resultBox.GetComponent<InputField>().text.Equals("even", System.StringComparison.CurrentCultureIgnoreCase) ? true : false;
            if (even == evenState)
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
