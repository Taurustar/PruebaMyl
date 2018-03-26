using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPrincipal : MonoBehaviour {

    
    public GameObject canvasCargar;
    public GameObject loadSceneBar;
    bool isloading = false;
    AsyncOperation asyncOp;
	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
    void Update()
    {
        if(isloading)
        loadSceneBar.GetComponent<RectTransform>().localScale.Set(asyncOp.progress,1,1);
    }

    public void ShowLoadBar(int index)
    {
        canvasCargar.GetComponent<Canvas>().enabled = true;
        
        StartCoroutine(FillTheBar(index));
    }

    IEnumerator FillTheBar(int index)
    {
        asyncOp = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(index);
        isloading = true;
        while (!asyncOp.isDone)
        {
            yield return null;
        }
    }



}
