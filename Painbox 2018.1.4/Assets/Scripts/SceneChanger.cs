using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour {
    public Button nextSceneButton;
    public InputField path, rot, pos;
    public Scene nextScene;

    // Use this for initialization
    void Start () {
        Button nextScene = nextSceneButton.GetComponent<Button>();
        nextScene.onClick.AddListener(sceneClick);
	}

    void sceneClick()
    {
        VariableController.path = path.text;
        VariableController.positionUnits = float.Parse(pos.text);
        VariableController.rotationUnits = float.Parse(rot.text);
        SceneManager.LoadScene("TestCameraAngle");
        nextScene = SceneManager.GetSceneAt(1);
        SceneManager.MoveGameObjectToScene(this.gameObject, nextScene);
    }
	

}
