using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class url : MonoBehaviour
{
    public string URL = "https://forms.gle/9aqsivHcTUghrfgX8";    

    // Update is called once per frame
    public void Url1()
    {
        Application.OpenURL(URL);
    }
}
