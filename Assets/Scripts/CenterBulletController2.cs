
using System.Collections;

using UnityEngine;

public class CenterBulletController2 : MonoBehaviour
{
    public static float iryoku;

    void Start(){
        iryoku = 3.0f;
    }


    void Update()
    {
     
    transform.Translate(-0.1f, 0, 0);

    if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }


        

    

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Renia"){
            //Debug.Log("HITREINA");
            iryoku = iryoku - 2;
            if(iryoku < 1){
                Destroy(this.gameObject);
            }
        }
        if (coll.gameObject.tag == "player")
        {   Destroy(this.gameObject);
        }

        if(coll.gameObject.tag == "All"){
            //Debug.Log("ROUND HIT CENTER");
            iryoku = iryoku - 3;
            if(iryoku <= 1){
                Destroy(this.gameObject);
            }

        
        }
        if(coll.gameObject.tag == "Big"){
            iryoku = iryoku - 6;
            if(iryoku <= 1){
                Destroy(this.gameObject);
            }

        
        }
    }
}