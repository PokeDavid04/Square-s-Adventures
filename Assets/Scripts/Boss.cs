using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    Rigidbody2D rb2D;

    public GameObject SpawnBala1;
    public GameObject SpawnBala2;
    public GameObject SpawnBala3;
    public GameObject SpawnBala4;
    public GameObject SpawnBala5;
    

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        StartCoroutine(Vuelta1());  
    }

    IEnumerator Vuelta1()
    {
        yield return new WaitForSeconds(10);
        SpawnBala1.SetActive(false);
        SpawnBala2.SetActive(false);
        SpawnBala3.SetActive(false);
        SpawnBala4.SetActive(false);
        SpawnBala5.SetActive(false);
        yield return new WaitForSeconds(2);
        rb2D.velocity = new Vector2(0, -8);
        StartCoroutine(Vuelta2());
    }

    IEnumerator Vuelta2()
    {
        yield return new WaitForSeconds(15);
        SpawnBala1.SetActive(false);
        SpawnBala2.SetActive(false);
        SpawnBala3.SetActive(false);
        SpawnBala4.SetActive(false);
        SpawnBala5.SetActive(false);
        yield return new WaitForSeconds(2);
        rb2D.velocity = new Vector2(-8, 0);
        StartCoroutine(Vuelta3());
    }

    IEnumerator Vuelta3()
    {
        yield return new WaitForSeconds(20);
        SpawnBala1.SetActive(false);
        SpawnBala2.SetActive(false);
        SpawnBala3.SetActive(false);
        SpawnBala4.SetActive(false);
        SpawnBala5.SetActive(false);
        yield return new WaitForSeconds(2);
        rb2D.velocity = new Vector2(8, 0);
        
    }


}
