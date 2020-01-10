using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterController : MonoBehaviour
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
          
                kyushu = 1;

            }
            if(Input.GetKeyDown(KeyCode.W)){

                kyushu = 2;

            }
            if(Input.GetKeyDown(KeyCode.E)) {
             
                kyushu = 3;

            }
            if(Input.GetKeyDown(KeyCode.I)) {
             
                barrier = 1;

            }
            if(Input.GetKeyDown(KeyCode.O)) {
             
                barrier = 2;

            }
            if(Input.GetKeyDown(KeyCode.P)) {
             
                barrier = 3;

            }
        

    }

}