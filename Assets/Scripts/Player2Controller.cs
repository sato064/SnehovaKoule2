using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
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



    void Start()
    {
        //HpBarCtrl.DownHp(20);
        //HP = HPstore.getHP1();
        flg = true;
        bar = MasterController.getBarrier();
    }

    void Update()
    {
        
        if(bar == 1 && flg){
                Debug.Log("kkits");
                Instantiate(BigBarrier);
                //YPstore.LoseYP2(5);
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
                //YPstore.LoseYP2(4);

                flg = false;
                return;


            }
            if(bar == 3 && flg){
                //Debug.Log("ALIVE");
                Instantiate(KBarrier0);
                Instantiate(KBarrier1);
                Instantiate(KBarrier2);
                //YPstore.LoseYP2(5);
                flg = false;
                return;
            }
    }
    

   
    


    
    void OnTriggerEnter2D(Collider2D coll){
        if(coll.gameObject.tag == "Renia"){
            HP = HP - 2;
            //HPstore.ChangeHP2(2);
       

        }
        if(coll.gameObject.tag == "Big"){
            //HP = HP - BulletController1.BIGiryoku;
            //HPstore.ChangeHP2(MBulletController1.BIGiryoku);
       
        }
        if(coll.gameObject.tag == "All"){
            //Debug.Log(PBulletControllerR.iryoku);
            //HP = HP - UpperBulletController.iryoku;
            //HPstore.ChangeHP2(UpperBulletController.iryoku);
    

        }

    }
}
        


  