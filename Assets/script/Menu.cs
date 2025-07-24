using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Jouer()
    {
        SceneManager.LoadScene("Jeu");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Quitter()
    {
        Application.Quit();
    }
}
