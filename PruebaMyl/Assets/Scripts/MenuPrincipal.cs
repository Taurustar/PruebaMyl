using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPrincipal : MonoBehaviour {

    public static MenuPrincipal instance;
    public GameObject canvasCargar;
    public GameObject loadSceneBar;

    void awake()
    {
        if(!instance)
        {
            instance = this;
        }

        if(this != instance)
        {
            Destroy(this);
        }

        DontDestroyOnLoad(instance);
    }

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowLoadBar(int levelToGo)
    {
        canvasCargar.GetComponent<Canvas>().enabled = true;
        StartCoroutine(FillTheBar(levelToGo));
    }

    IEnumerator FillTheBar(int levelToGo)
    {
        yield return new WaitForSeconds(1);
        loadSceneBar.GetComponent<UnityEngine.UI.Image>().transform.localScale.Set(20,1,1);
        yield return new WaitForSeconds(1);
        loadSceneBar.GetComponent<UnityEngine.UI.Image>().transform.localScale.Set(40, 1, 1);
        yield return new WaitForSeconds(1);
        loadSceneBar.GetComponent<UnityEngine.UI.Image>().transform.localScale.Set(60, 1, 1);
        yield return new WaitForSeconds(1);
        loadSceneBar.GetComponent<UnityEngine.UI.Image>().transform.localScale.Set(80, 1, 1);
        yield return new WaitForSeconds(1);
        loadSceneBar.GetComponent<UnityEngine.UI.Image>().transform.localScale.Set(100, 1, 1);
        yield return new WaitForSeconds(1);
        UnityEngine.SceneManagement.SceneManager.SetActiveScene(UnityEngine.SceneManagement.SceneManager.GetSceneByBuildIndex(levelToGo));
    }



}
