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
        
        hp1.text = "HP:" + HpControllerMaster.getHP1() + "/20";
        hp2.text = "HP:" + HpControllerMaster.getHP2()+ "/20";;
        mp1.text = "YP:" + YpControllerMaster.getYP1()+ "/25";;
        mp2.text = "YP:" + YpControllerMaster.getYP2()+ "/25";;

    }
}
