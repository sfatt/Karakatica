using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Buy : MonoBehaviour
{   
    public GameObject block,b1;
    public TMP_Text text;

    void Start()
    {
        text.enabled = false;
        block.SetActive(false);
    }

    private void OnTriggerEnter(Collider coll)
    {
        text.enabled = true;
        block.SetActive(true);
    }

    private void OnTriggerExit(Collider collid)
    {
        text.enabled = false;
        Destroy(b1);
    }
}
