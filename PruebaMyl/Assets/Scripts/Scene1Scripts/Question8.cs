using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question8 : MonoBehaviour {

    public RandomQuestion QuestionManager;
    public GameObject questionLabel;
    public GameObject correct;
    public GameObject wrong;
    public Material wrongMat, correctMat, normalMat;
    public Color wrongColor = Color.yellow, correctColor = Color.green;
    public GameObject RobotEye, RobotLight, RobotBody;


    // Use this for initialization
    void Start()
    {
        questionLabel.GetComponent<Text>().text = "Which of these words is not a Synonym?";
    }

    public void CheckResult(int id)
    {
        RobotLight.GetComponent<Light>().enabled = true;
            if (id == 3)
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

    IEnumerator OtherQuestion()
    {
        yield return new WaitForSeconds(3);
        wrong.SetActive(false);
        correct.SetActive(false);
        RobotLight.GetComponent<Light>().enabled = false;
        RobotEye.GetComponent<MeshRenderer>().material = normalMat;
        QuestionManager.TextChange();
        RobotBody.GetComponent<Animation>().Stop();
        Start();

    }

    }


