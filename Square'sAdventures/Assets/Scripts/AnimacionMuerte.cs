using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionMuerte : MonoBehaviour
{

    public GameObject BossMuerte;
    public GameObject pasillo;

    // Start is called before the first frame update
    void Start()
    {
        BossMuerte.SetActive(false);
    }

    // Update is called once per frame
    private void OnEnable()
    {
        StartCoroutine(Muerte());
    }

    IEnumerator Muerte()
    {
        yield return new WaitForSeconds(5);
        pasillo.SetActive(true);
        BossMuerte.SetActive(false);
    }
}
