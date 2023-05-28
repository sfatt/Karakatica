using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Money : MonoBehaviour
{
    public GameObject block,c2, block2;
    public TMP_Text money, exp, lvl, needexp;
    public int Plus = 150, exppl = 3;
    public int mon,expi,inexp ,ilvl;
    private string str, exps, lvls, snexp, slvl;

    void Start(){
       str = money.text;
       exps = exp.text;
       snexp = needexp.text;
       slvl = lvl.text;
       int.TryParse(str, out mon);
       int.TryParse(exps, out expi);
       int.TryParse(snexp, out inexp);
       int.TryParse(slvl, out ilvl);
    

    }


    private void OnTriggerEnter(Collider coll)
    {
        mon = mon + Plus;
        expi = expi + exppl;
        Destroy(block);
        str = mon.ToString();
        exps = expi.ToString();
        money.text = str;
        exp.text = exps;
        c2.SetActive(true); 
        if(expi >= inexp){
            inexp = inexp + (inexp/2) ;
            snexp = inexp.ToString();
            needexp.text = snexp;
            ilvl = ilvl + 1;
            slvl = ilvl.ToString();
            lvl.text = slvl;

            
        }
        Destroy(block2);
    }
}

