using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void Next()
    {
        var current = SceneManager.GetActiveScene().buildIndex + 1;
        if(current >= SceneManager.sceneCountInBuildSettings) current = 1;
        SceneManager.LoadScene(current);
    }

    public void Retry() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}