using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinDetechScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject wintext1;
    public GameObject wintext2;

    //public GameObject nextbutton;

    public GameObject mainbutton;

    private float hp1;
    private float hp2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
    hp1 = HpControllerMaster.getHP1();
    hp2 = HpControllerMaster.getHP2();


    {
        if(hp1 <= 0){
            wintext1.SetActive(true);
            //nextbutton.SetActive(false);
            mainbutton.SetActive(true);
            Time.timeScale = 0;

        }
        if(hp2 <= 0){
            wintext2.SetActive(true);
            //nextbutton.SetActive(false);
            mainbutton.SetActive(true);
            Time.timeScale = 0;
        }
        
    }
    }
}

