using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class saveCamera : MonoBehaviour {

    public Button saveButton;

	// Use this for initialization
	void Start () {
        Debug.Log("App started");

        Button btn1 = saveButton.GetComponent<Button>();
        btn1.onClick.AddListener(onSavePressed);

        //Setup a new file for writing
        //Create new file based on current time
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    //Save
    void onSavePressed()
    {
        Debug.Log("You have clicked the button!");
        Vector3 position = transform.position;
        float xRotation = transform.eulerAngles.x;

        //Open the file

        //Append the new data values

        //Close the file
    }
}
