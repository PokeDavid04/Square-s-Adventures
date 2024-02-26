using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{

    public GameObject PPausa;
    public GameObject PPPersonajes;


    private void Start()
    {
        PPausa.gameObject.SetActive(false);
        PPPersonajes.gameObject.SetActive(false);
    }
    public void BPausa()
    {
        Time.timeScale = 0;
        PPausa.gameObject.SetActive(true);
    }

    public void BAtras()
    {
        PPausa.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void BResetSala()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void BPPPersonajes()
    {
        PPPersonajes.gameObject.SetActive(true);
        PPausa.gameObject.SetActive(false);
    }

    public void BMenuPrincipal()
    {
        SceneManager.LoadScene("MenuPrincipal");
        Time.timeScale = 1;
    }

    public void BSalir()
    {
        Application.Quit();
    }

  



}
