using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Hp1TC : MonoBehaviour
{
    public Text hp1;
    public Text hp2;
    public Text mp1;
    public Text mp2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        hp1.text = "体力:" + HpControllerMaster.getHP1() + "/20";
        hp2.text = "体力:" + HpControllerMaster.getHP2() + "/20";
        mp1.text = "煌力:" + YpControllerMaster.getYP1() + "/25";
        mp2.text = "煌力:" + YpControllerMaster.getYP2() + "/25";

    }
}
