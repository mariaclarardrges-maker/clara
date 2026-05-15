using UnityEngine;
using UnityEngine.SceneManagement; // Required for SceneManager

public class SceneLoader : MonoBehaviour
{
    public void LoadGameScene()
    {
        // Load the scene by its name
        SceneManager.LoadScene("Jogo");
    }
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
}