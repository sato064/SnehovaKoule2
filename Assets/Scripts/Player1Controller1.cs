﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller1 : MonoBehaviour
{
    public GameObject RB0;
    public GameObject RB1;
    public GameObject RB2;
    public GameObject RB3;
    public GameObject RB4;

    public GameObject BigBarrier;
    
    public GameObject KBarrier0;
    public GameObject KBarrier1;
    public GameObject KBarrier2;

    public static float HP;
    
    public static int bar;

    private bool flg;

    private int Boll;



    void Start()
    {
        //HpBarCtrl.DownHp(20);
        HP = HpControllerMaster.getHP1();
        flg = true;
        bar = MasterController.getBarrier();
        Boll = MasterController.getKyushu();
    }

    void Update()
    {
        
        if(bar == 1 && flg){
                Debug.Log("kkits");
                Instantiate(BigBarrier);
                YpControllerMaster.ChangeYP2(5);
                flg = false;
                return;

            }
            if(bar == 2 && flg){
                //Debug.Log("INsta ni totatu");
                Instantiate(RB0);
                Instantiate(RB1);
                Instantiate(RB2);
                Instantiate(RB3);
                Instantiate(RB4);
                YpControllerMaster.ChangeYP2(4);

                flg = false;
                return;


            }
            if(bar == 3 && flg){
                //Debug.Log("ALIVE");
                Instantiate(KBarrier0);
                Instantiate(KBarrier1);
                Instantiate(KBarrier2);
                YpControllerMaster.ChangeYP2(5);
                flg = false;
                return;
            }
    }
    

   
    


    
    void OnTriggerEnter2D(Collider2D coll){

        if(coll.gameObject.tag == "Renia"){
            Debug.Log("ATARI");
            HP = HP - 2;
            HpControllerMaster.ChangeHP2(2);
       

        }

        if(coll.gameObject.tag == "Big"){
            //HP = HP - BulletController1.BIGiryoku;
            if(bar == 1){
                HpControllerMaster.ChangeHP2(2);
       
            }
            if(bar == 2){
                HpControllerMaster.ChangeHP2(3);
       
            }
            if(bar == 3){
                HpControllerMaster.ChangeHP2(5);
       
            }
            if(bar == 0 ){
                HpControllerMaster.ChangeHP2(8);
            }
        }

        if(coll.gameObject.tag == "All"){
            //Debug.Log(PBulletControllerR.iryoku);
            //HP = HP - UpperBulletController.iryoku;
            HpControllerMaster.ChangeHP2(UpperBulletController.iryoku);
    

        }

    }
}
        


  