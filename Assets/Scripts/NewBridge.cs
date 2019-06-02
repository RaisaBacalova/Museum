using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBridge : MonoBehaviour {

    public GameObject objectToCreate;

	// Use this for initialization
	void Start () {
        //Object.Instantiate(objectToCreate, new Vector3(0.02f, 0.07f, -19.39f), Quaternion.identity);
        for (int i = 50; i < 500; i++)
        {
            Object.Instantiate(objectToCreate, new Vector3(0.02f, 0.07f, -i), Quaternion.identity);
            //GameObject newBridge = (GameObject)Object.Instantiate(objectToCreate, new Vector3(0.02f, 0.07f, -i), Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
