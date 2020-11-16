using UnityEngine.SceneManagement;
using UnityEngine;

public class LVM : MonoBehaviour
{
   public void Next()
    {

    }
    public void Again()
    {
        SceneManager.LoadScene("LV1");
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("Menu");

    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
