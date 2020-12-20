using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager: MonoBehaviour
{
    public void OnPlayClicked()
    {
        SetTimeScale(1f);
        SceneManager.LoadScene(1);
    }

    private void SetTimeScale(float timeScale)
    {
        Time.timeScale = timeScale;
    }

    public void OnExitClicked()
    {
        Application.Quit();
    }
}
