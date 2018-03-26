using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleJSON;

public class CommentsScript : MonoBehaviour {

    public InputField postID;
    public GameObject ShowCommentBox;
    string commentText;


    public void GetComments()
    {
        StartCoroutine(RequestComments());
    }

    IEnumerator RequestComments()
    {
       
       WWW www = new WWW("https://jsonplaceholder.typicode.com/comments?postId=" + postID.text);
       yield return www;
       yield return new WaitUntil(() => www.isDone);

        string jsonFixed = "{ \n\"results\" : " + www.text + "\n}";
        Debug.Log(jsonFixed);
       var N = JSON.Parse(jsonFixed);

       commentText = "--------------------------------";

       for (int i = 0; i <= N["results"].Count; i++)
       {
           commentText = commentText + "\nPost Id: " + N["results"][i]["postId"].ToString() +
                      "\nId: " + N["results"][i]["id"].ToString() +
                      "\nname: " + N["results"][i]["name"].ToString() +
                       "\nemail: " + N["results"][i]["email"].ToString() +
                       "\nComment: " + N["results"][i]["body"].ToString() +
                       "\n--------------------------------";
       }

           Debug.Log(commentText);

           ShowCommentBox.GetComponent<Text>().text = commentText;
    }

}
