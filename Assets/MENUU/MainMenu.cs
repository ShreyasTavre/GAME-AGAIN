using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void playgame()
    {
        SceneManager.LoadScene(1);
    }

    public void preplaygame()
    {
        SceneManager.LoadScene(2);
    }

    public void playgame2()
    {
        SceneManager.LoadScene(3);
    }
}
