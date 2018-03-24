using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAsyncLoader : MonoBehaviour {

	void Awake()
    {
        Scene activeScene = SceneManager.GetActiveScene();
    }
}
