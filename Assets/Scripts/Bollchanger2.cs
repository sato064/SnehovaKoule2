using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bollchanger2 : MonoBehaviour
{
    private string[] kyushus = new string[] {"iku", "KUSO-DEKA", "RENSHA","ZENHOUI" };



    public Text bolltext;
    private int boll;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        boll = MasterController2.getKyushu();
        bolltext.text = "Kyushu:" + kyushus[boll];



    }

}
