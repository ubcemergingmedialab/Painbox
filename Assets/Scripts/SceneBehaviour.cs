using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBehaviour : MonoBehaviour {



        // Update is called once per frame
        public void ChangeToScene(string SceneToChangeTo)
        {
            SceneManager.LoadScene(SceneToChangeTo);
        }

    public void ExitGame()
    {
        Application.Quit();
    }



}
