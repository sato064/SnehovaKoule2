using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Barrierchanger2 : MonoBehaviour
{
    private string[] barriers = new string[] {"iku", "KUSO-DEKA", "MILLE-FEUILLE","ZENHOUI" };



    public Text barriertext;
    private int barrier;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        barrier = MasterController2.getBarrier();
        barriertext.text = "Barrier:" +  barriers[barrier];



    }

}
