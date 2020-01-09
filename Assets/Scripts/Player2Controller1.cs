using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller1 : MonoBehaviour
{

   
    public GameObject BigBullet;
    public GameObject CenterBullet;

    public GameObject Downbullet;

    public GameObject AutoBullet;
    public GameObject Upbullet;
     private int Boll;
    private bool bflag;
    private int i;

    



    void Start()
    {
        Boll = MasterController.getKyushu();
        bflag = true;
    }

    void Update()
    {
        MakeBullet();

    }

    void MakeBullet()
    {

     

            if(Boll == 1 && bflag)
            {
                Instantiate(BigBullet, transform.position, Quaternion.identity);
                YpControllerMaster.ChangeYP1(6);
                //Debug.Log("YP :" + YpControllerMaster.getYP1());
                bflag = false;
                return;
            }
            if(Boll == 2 && bflag)
            {
                
                StartCoroutine("Auto");
                YpControllerMaster.ChangeYP1(4);
                Debug.Log("weiwei");
                bflag = false;
                return;

            }
            if(Boll == 3 && bflag)
            {
                //Debug.Log("ZENHOUI");
                Instantiate(CenterBullet, transform.position, Quaternion.identity);
                Instantiate(Downbullet,transform.position, Quaternion.identity);
                Instantiate(Upbullet,transform.position, Quaternion.identity);
                YpControllerMaster.ChangeYP1(6);

                bflag = false;
                return;

            }
            
            

            
        }
    


   
    IEnumerator Auto(){
        for(i=0;i<5;i++){
            //Debug.Log("weiweiwei");
            shoot();
            yield return new WaitForSeconds(0.5f);
            
        }
        


    }
    private void shoot(){
        //Debug.Log("weeel");
        Instantiate(AutoBullet, transform.position, Quaternion.identity);

    }
}
  