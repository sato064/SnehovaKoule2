using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MasterController : MonoBehaviour
{

    private static int kyushu = 0;

    private static int barrier = 0;
    private float yp1;
    private float yp2;

    private int flg1;

    private int flg2;

    private int aflg;
    
    private int qflg;

    bool isShift = false;

    bool isShift2 = false;

    void Start()
    {
        kyushu = 0;
        barrier = 0;
        if(YpControllerMaster.getYP1() <= 25){
        YpControllerMaster.PlusYP1(2);
        }

        if(YpControllerMaster.getYP2() <= 25){
        YpControllerMaster.PlusYP2(2);
        }

        int c_b = Random.Range(1, 4);
        Debug.Log(c_b);

        if(cpu_ctrl.Getcflg() == 1){
            Debug.Log("imakarahareruyo");
            if(YpControllerMaster.getYP2() >= 6){
                Debug.Log("imakarahareruyo2");
                barrier = c_b;
            }
            else if(YpControllerMaster.getYP2() >= 4 && c_b == 2){
                barrier = c_b;
            }


        }
   
     
    }
    public static int getKyushu(){
        return kyushu;
    }
    public static int getBarrier(){
        return barrier;
    }

    void Update()
    {
        yp1 = YpControllerMaster.getYP1();
        yp2 = YpControllerMaster.getYP2();

        if(flg1 == 0){

            isShift = Input.GetKey(KeyCode.A);

            if(isShift){

            if(Input.GetKeyDown(KeyCode.Q)){
                    if(yp1 >= 6){
                        kyushu = 1;
                        flg1 = 1;

                    }
                }
            if(Input.GetKeyDown(KeyCode.W)){
                    if(yp1 >= 4){
                        kyushu = 2;
                        flg1 = 1;

                    }
                }
            if(Input.GetKeyDown(KeyCode.E)){
                    if(yp1 >= 6){
                        kyushu = 3;
                        flg1 = 1;

                    }
                }
            
            }
        }
        if(Input.GetKeyDown(KeyCode.R)) {
                
            //Debug.Log("Q");
          
            kyushu = 0;
            flg1 = 0;
        }
        if(flg2 == 0){

            isShift2 = Input.GetKey(KeyCode.L);

            if(isShift2){
                if(Input.GetKeyDown(KeyCode.I)) {
                if(yp2 >= 5){

                    barrier = 1;
                    flg2 = 1;

                }
            }
            if(Input.GetKeyDown(KeyCode.O)) {
                if(yp2 >= 4){

                    barrier = 2;
                    flg2 = 1;
                }

            }
            if(Input.GetKeyDown(KeyCode.P)) {
                if(yp2 >= 5){

                    barrier = 3;
                    flg2 = 1;
                }


            }
        }
        }

        if(Input.GetKeyDown(KeyCode.U)) {
                
                    //Debug.Log("Q");
          
                    barrier = 0;
                    flg2 = 0;
            }
        }
        

    }



