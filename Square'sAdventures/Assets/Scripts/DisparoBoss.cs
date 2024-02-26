using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoBoss : MonoBehaviour
{
    public GameObject Bala;
    public Transform SpawnBala;

    public float FuerzaDisparoy = 0f;
    public float FuerzaDisparox = 0f;
    public float TiempoDisparo = 0.3f;
    public float TiempoMuerte = 5f;

   
    private void OnEnable()
    {
        StartCoroutine(Espera());
    }

    IEnumerator Espera()
    {
        yield return new WaitForSeconds(1);
        StartCoroutine(Disparar());

    }
    IEnumerator Disparar()
    {
        
        GameObject newBala;
        newBala = Instantiate(Bala, SpawnBala.position, SpawnBala.rotation);
        newBala.GetComponent<Rigidbody2D>().velocity = new Vector2(FuerzaDisparox, FuerzaDisparoy);
        Destroy(newBala, TiempoMuerte);
        yield return new WaitForSeconds(TiempoDisparo);
        StartCoroutine(Disparar());
    }
}
