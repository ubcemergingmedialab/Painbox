using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class saveCamera : MonoBehaviour {

    public Camera camera;
    public Button saveButton;

	// Use this for initialization
	void Start () {
        Debug.Log("App started");
        saveButton.onClick.AddListener(Save); //Click only works once... Fix it

        //Setup a new file for writing
        //Create new file based on current time
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    //Save
    void Save()
    {
        Debug.Log("You have clicked the button!");
        //Record the camera.position and camera.rotation

        //Open the file

        //Append the new data values

        //Close the file
    }
}
