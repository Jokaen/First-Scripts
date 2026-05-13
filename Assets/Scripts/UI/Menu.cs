using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject btnMenu;
    [SerializeField] private GameObject btnStart;
    [SerializeField] private GameObject btnExit;

    [SerializeField] private GameObject panelOptions;

    public void StartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void ShowOptions()
    {
        Debug.Log("Options");
        panelOptions.SetActive(true);
        btnMenu.SetActive(false);
        btnStart.SetActive(false);
        btnExit.SetActive(false);
    }

    public void ClosesOptions()
    {
        Debug.Log("Close Options");
        panelOptions.SetActive(false);
        btnMenu.SetActive(true);
        btnStart.SetActive(true);
        btnExit.SetActive(true);
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
    }
}
