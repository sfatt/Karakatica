using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Car : MonoBehaviour
{
    public TMP_Text money;
    private int mon;
    private string smon;
    public GameObject b1,b2,b3,b4,t1;

    void Start()
    {
        smon = money.text;
        int.TryParse(smon, out mon);
    }

    private void OnTriggerEnter(Collider coll)
    {
        if( mon >= 1000){
            mon = mon - 1000;
            Destroy(b1);
            Destroy(b2);
            Destroy(b3);
            Destroy(b4);
            smon = mon.ToString();
            money.text = smon;
            Destroy(t1);


        }
       
    }
}


