using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterController2 : MonoBehaviour
{

    private static int kyushu = 0;

    private static int barrier = 0;

    void Start()
    {
        kyushu = 0;
        barrier = 0;
        //YPstore.AddYP1(2);
        //YPstore.AddYP2(2);
        
     
    }
    public static int getKyushu(){
        return kyushu;
    }
    public static int getBarrier(){
        return barrier;
    }

    void Update()
    {
            if(Input.GetKeyDown(KeyCode.Q) ){
                Debug.Log("Q");
          
                barrier = 1;

            }
            if(Input.GetKeyDown(KeyCode.W)){

                barrier = 2;

            }
            if(Input.GetKeyDown(KeyCode.E)) {
             
                barrier = 3;

            }
            if(Input.GetKeyDown(KeyCode.I)) {
             
                kyushu = 1;

            }
            if(Input.GetKeyDown(KeyCode.O)) {
             
                kyushu = 2;

            }
            if(Input.GetKeyDown(KeyCode.P)) {
             
                kyushu = 3;

            }
        

    }

}