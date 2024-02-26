using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBotones : MonoBehaviour
{

    public GameObject PanelBotones;
    

    


    void Start()
    {
        PanelBotones.gameObject.SetActive(true);

    }

    public void BJugar()
    {
        SceneManager.LoadScene("Tutorial");       

    }

    public void BPersonajes()
    {
        SceneManager.LoadScene("Personajes");
    }

    public void BCreditos()
    {
        SceneManager.LoadScene("Creditos");

    }

    public void BSalir()
    {
        Application.Quit();
    }


}
