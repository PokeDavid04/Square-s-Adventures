using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DefinirColorBlanco : MonoBehaviour
{


    void Start()
    {
        StartCoroutine(Cargando());
    }
    IEnumerator Cargando()
    {
        float TiempoEspera = Random.Range(3,8f);
        yield return new WaitForSeconds(TiempoEspera);
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("MenuPrincipal");
    }
  
}
