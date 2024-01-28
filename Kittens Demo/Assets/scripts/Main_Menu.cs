using UnityEngine;
using UnityEngine.SceneManagement;


public class Main_Menu : MonoBehaviour
{
    public void GoToScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
    public void ExitGame(){
        Application.Quit();
        Debug.Log("Application has quit.");
    }
}
