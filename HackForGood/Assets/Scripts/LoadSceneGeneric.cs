using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadSceneGeneric : MonoBehaviour {

    public string nextScene = "";
	// Use this for initialization
	
        void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || (Input.GetButtonDown("Back Button"))) {
            Debug.Log("Saliendo...");
            Application.Quit();
        }
    }
    
    public void loadScene()
    {
        SceneManager.LoadScene(this.nextScene);
    }
}
