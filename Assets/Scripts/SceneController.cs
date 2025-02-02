using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class SceneController : MonoBehaviour
{
    public void OpenMainScene()
    {
        SceneManager.LoadScene(0);
    }

    public void OpenGameScene()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }
}
