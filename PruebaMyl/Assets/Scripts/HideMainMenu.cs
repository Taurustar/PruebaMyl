using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MenuPrincipal.instance.gameObject.GetComponent<Canvas>().enabled = false;
	}

    public void ShowMenu()
    {
        
        MenuPrincipal.instance.gameObject.GetComponent<Canvas>().enabled = true;
    }
}
