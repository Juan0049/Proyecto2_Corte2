using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderScenes : MonoBehaviour
{
    public void LectorEscena(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }
}