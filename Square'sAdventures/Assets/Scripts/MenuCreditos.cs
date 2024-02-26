using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCreditos : MonoBehaviour
{
    void Start()
    {
        
    }

    public void BotonCreditosAtras()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
