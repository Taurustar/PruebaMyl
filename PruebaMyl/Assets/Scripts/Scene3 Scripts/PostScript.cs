using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using UnityEngine.UI;

public class PostScript : MonoBehaviour {

    public GameObject ShowCommentBox;
    string commentText;


    public void GetPost()
    {
        StartCoroutine(RequestLastPost());
    }

    IEnumerator RequestLastPost()
    {

        WWW www = new WWW("https://jsonplaceholder.typicode.com/posts");
        yield return www;
        yield return new WaitUntil(() => www.isDone);

        string jsonFixed = "{ \n\"results\" : " + www.text + "\n}";
        Debug.Log(jsonFixed);
        var N = JSON.Parse(jsonFixed);

        commentText = "--------------------------------";
            commentText = commentText + "\nUser Id: " + N["results"][N["Results"].Count]["userId"].ToString() +
                       "\nPost Id: " + N["results"][N["Results"].Count]["id"].ToString() +
                       "\nTitle: " + N["results"][N["Results"].Count]["title"].ToString() +
                        "\nPost: " + N["results"][N["Results"].Count]["body"].ToString() +
                        "\n--------------------------------";
        

        Debug.Log(commentText);

        ShowCommentBox.GetComponent<Text>().text = commentText;
    }
}
