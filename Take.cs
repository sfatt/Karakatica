using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Take : MonoBehaviour
{
    public TMP_Text txt;
    public GameObject block, block1, compass,c2;

    void Start()
    {
       txt.enabled = false;
       block.SetActive(false); 
       compass.SetActive(false);
       c2.SetActive(false);
    }

    private void OnTriggerEnter(Collider coll)
    {
        txt.enabled = true;
        block.SetActive(true);
        compass.SetActive(true);

    }

    private void OnTriggerExit(Collider coll)
    {
        txt.enabled = false;
        Destroy(block1);
    }
}
