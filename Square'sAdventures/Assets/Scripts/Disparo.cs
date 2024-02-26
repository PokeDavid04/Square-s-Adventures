using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{

    public GameObject Bala;
    public Transform SpawnBala;

    public float FuerzaDisparoy = 8f;
    public float FuerzaDisparox = 0f;
    public float TiempoDisparo = 0.75f;
    public float TiempoMuerte = 1f;

    private void Start()
    {
        StartCoroutine(Disparar());
    }
    IEnumerator Disparar()
    {
        
        GameObject newBala;
        newBala = Instantiate(Bala,SpawnBala.position,SpawnBala.rotation);
        newBala.GetComponent<Rigidbody2D>().velocity = new Vector2(FuerzaDisparox, FuerzaDisparoy);
        Destroy(newBala, TiempoMuerte);
        yield return new WaitForSeconds(TiempoDisparo);
        StartCoroutine(Disparar());
    }
}
