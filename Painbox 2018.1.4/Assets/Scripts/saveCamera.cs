using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class saveCamera : MonoBehaviour {

    private System.IO.StreamWriter file;
    private string logName;
    public Button saveButton;
    private string directoryPath;

	// Use this for initialization
	void Start () {
        directoryPath = VariableController.path;
        string time = System.DateTime.Now.ToFileTimeUtc().ToString();
        logName = @directoryPath + @"\Log-" + time + ".txt";
        using (file =
            new System.IO.StreamWriter(logName))
        {
            file.WriteLine("file initialized on " + System.DateTime.Now.ToUniversalTime() + "\n");
        }
        
        Button btn1 = saveButton.GetComponent<Button>();
        btn1.onClick.AddListener(onSavePressed);

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

        using (file =
            new System.IO.StreamWriter(logName, true))
        {
            file.WriteLine("===========================================================================");
            file.WriteLine("Save pressed at " + System.DateTime.Now.ToString());
            file.WriteLine("Position: x: " + position.x + ", y:" + position.y + ", z:" + position.z);
            file.WriteLine("x Rotation: " + xRotation);
            file.WriteLine("===========================================================================");
            file.WriteLine("\n");
        }
       

    }
}
