using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRespawn : MonoBehaviour
{
    public GameObject SpawnPointBoss;

    public GameObject BossMuerte;
    public GameObject Boss;

    public GameObject Cor1;
    public GameObject Cor2;
    public GameObject Cor3;

    public GameObject SpawnBala1;
    public GameObject SpawnBala2;
    public GameObject SpawnBala3;
    public GameObject SpawnBala4;
    public GameObject SpawnBala5;

    public float tiempoespera = 0.000005f;

    Rigidbody2D rb2D;



    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        PlayerPrefs.SetString("Corazones","3corazones");
        Debug.Log("3 Corazones");
        SpawnBala1.SetActive(true);
        SpawnBala2.SetActive(true);
        SpawnBala3.SetActive(true);
        SpawnBala4.SetActive(true);
        SpawnBala5.SetActive(true);
        Cor1.SetActive(true);
        Cor2.SetActive(true);
        Cor3.SetActive(true);
    }

    public void BossDamage()
    {
        
        rb2D.velocity = new Vector2(0,0);

        switch (PlayerPrefs.GetString("Corazones"))
        {
            case "3corazones":
                gameObject.transform.position = new Vector3(SpawnPointBoss.transform.position.x, SpawnPointBoss.transform.position.y, 0);
                SpawnBala1.SetActive(true);
                SpawnBala2.SetActive(true);
                SpawnBala3.SetActive(true);
                SpawnBala4.SetActive(true);
                SpawnBala5.SetActive(true);
                Debug.Log("1corazon menos");
                Cor1.SetActive(false);
                PlayerPrefs.SetString("Corazones", "corazones2");
                break;
            case "corazones2":
                StartCoroutine(Espera2());
                break;
            case "2corazones":
                gameObject.transform.position = new Vector3(SpawnPointBoss.transform.position.x, SpawnPointBoss.transform.position.y, 0);
                SpawnBala1.SetActive(true);
                SpawnBala2.SetActive(true);
                SpawnBala3.SetActive(true);
                SpawnBala4.SetActive(true);
                SpawnBala5.SetActive(true);
                Debug.Log("otro mesnos");
                Cor2.SetActive(false);
                PlayerPrefs.SetString("Corazones", "corazones");
                break;
            case "corazones":
                StartCoroutine(Espera());
                break;
            case "1corazones":
                gameObject.transform.position = new Vector3(-1000, -1000, 0);
                Debug.Log("todos fuera");
                Cor3.SetActive(false);
                AnimMuerte();
                PlayerPrefs.SetString("Corazones", "0corazones");
                break;
            default:    
                break;
        }
    }

    private void AnimMuerte()
    {
        StartCoroutine(Anim1());
    }
    IEnumerator Anim1()
    {
        BossMuerte.SetActive(true);
        yield return new WaitForSeconds(tiempoespera);

        Boss.SetActive(false);
    }


    
    IEnumerator Espera()
    {
        yield return new WaitForSeconds(1);
        PlayerPrefs.SetString("Corazones", "1corazones");
    }
    IEnumerator Espera2()
    {
        yield return new WaitForSeconds(1);
        PlayerPrefs.SetString("Corazones", "2corazones");
    }
}
