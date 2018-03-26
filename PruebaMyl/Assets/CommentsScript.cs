using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleJSON;

public class CommentsScript : MonoBehaviour {

    public InputField postID;
    public GameObject ShowCommentBox;
    string commentText;

    [System.Serializable]
    private class JsonData
    {
        public List<Comment> results { get; set; }
    }

    [System.Serializable]
    private class Comment
    {
        public string postId;
        public string id;
        public string name;
        public string email;
        public string body;
    }

    public void GetComments()
    {
        StartCoroutine(RequestComments());
    }

    IEnumerator RequestComments()
    {
       
       WWW www = new WWW("https://jsonplaceholder.typicode.com/comments?postId=" + postID.text);
       yield return www;
       yield return new WaitUntil(() => www.isDone);
        Debug.Log("JSON: \n " + www.text);

        string jsonFixed = "{ \n\"results\" : " + www.text + "\n}";
        Debug.Log(jsonFixed);
       //Comment com = new Comment();
      // var N = JSON.Parse(www.text);
      // var N = JSON.Parse(jsonFixed);

    //for( int i = 0 ; i )
       //if (N["result"] != null)  
       //{
          // commentText = commentText + "Post Id: " + N["results"][3]["postId"].ToString() +
          //            "\nId: " + N["results"][3]["id"].ToString() +
          //            "\nname: " + N["results"][3]["name"].ToString() +
          //             "\nemail: " + N["results"][3]["email"].ToString() +
          //             "\nComment: " + N["results"][3]["body"].ToString();
       //}

            JsonData json = new JsonData();
            json = JsonUtility.FromJson<JsonData>(jsonFixed);
            JsonUtility.FromJsonOverwrite(jsonFixed, json);


            foreach (Comment com in json.results )
            {
                commentText = commentText + "Post Id: " + com.postId +
                                "\nId: " + com.id +
                                "\nname: " + com.name +
                                "\nemail: " + com.email +
                                "\nComment: " + com.body;
            }
           Debug.Log(commentText);   
    }

}
