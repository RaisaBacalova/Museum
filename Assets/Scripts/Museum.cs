using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Museum : MonoBehaviour {

	// Use this for initialization
	public void GoToMuseum(string sceneName)
    {
        //Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(sceneName);
    }
}
