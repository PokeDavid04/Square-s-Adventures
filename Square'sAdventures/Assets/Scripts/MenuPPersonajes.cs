using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPPersonajes : MonoBehaviour
{

    public GameObject PPPersonajes;
    public GameObject Player;
    public GameObject PPausa;

    

    public void PBlanco()
    {
        PlayerPrefs.SetString("PlayerSelected", "Blanco");
        ResetPlayerSkin2();
        
    }
    public void PAzul()
    {
        PlayerPrefs.SetString("PlayerSelected", "Azul");
        ResetPlayerSkin2();

    }
    public void PVerde()
    {
        PlayerPrefs.SetString("PlayerSelected", "Verde");
        ResetPlayerSkin2();

    }
    public void PRojo()
    {
        PlayerPrefs.SetString("PlayerSelected", "Rojo");
        ResetPlayerSkin2();

    }
    public void PRosa()
    {
        PlayerPrefs.SetString("PlayerSelected", "Rosa");
        ResetPlayerSkin2();

    }
    public void PAmarillo()
    {
        PlayerPrefs.SetString("PlayerSelected", "Amarillo");
        ResetPlayerSkin2();

    }


    public void ResetPlayerSkin2()
    {
        Player.GetComponent<PlayerSelect>().ChangeColor();
        PPPersonajes.gameObject.SetActive(false);
        PPausa.gameObject.SetActive(true);
    }


    
}
