using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void GameStart()
    {
        Debug.Log("START");
        SceneManager.LoadScene("LV1");
    }

    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
