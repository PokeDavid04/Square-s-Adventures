using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPersonajes : MonoBehaviour
{

    public GameObject PPersonajes;
    public GameObject Player;

    void Start()
    {
        PPersonajes.gameObject.SetActive(true);  
    }

    public void Blanco()
    {
        PlayerPrefs.SetString("PlayerSelected", "Blanco");
        ResetPlayerSkin();
        
    }
    public void Azul()
    {
        PlayerPrefs.SetString("PlayerSelected", "Azul");
        ResetPlayerSkin();

    }
    public void Verde()
    {
        PlayerPrefs.SetString("PlayerSelected", "Verde");
        ResetPlayerSkin();

    }
    public void Rojo()
    {
        PlayerPrefs.SetString("PlayerSelected", "Rojo");
        ResetPlayerSkin();

    }
    public void Rosa()
    {
        PlayerPrefs.SetString("PlayerSelected", "Rosa");
        ResetPlayerSkin();

    }
    public void Amarillo()
    {
        PlayerPrefs.SetString("PlayerSelected", "Amarillo");
        ResetPlayerSkin();

    }


    public void ResetPlayerSkin()
    {
        Player.GetComponent<PlayerSelect>().ChangeColor();
        SceneManager.LoadScene("MenuPrincipal");
    }


    
}
