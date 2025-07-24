using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RetourMenu : MonoBehaviour
{
    public string nomSceneMenu = "Menu";

    public void RetournerAuMenuApresDelai()
    {
        StartCoroutine(RetourMenuCoroutine());
    }

    private IEnumerator RetourMenuCoroutine()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(nomSceneMenu);
    }
}
