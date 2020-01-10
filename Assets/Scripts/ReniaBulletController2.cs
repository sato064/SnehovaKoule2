using System.Collections;
using UnityEngine;



public class ReniaBulletController2 : MonoBehaviour
{
    public static float iryoku;
    void Start(){
        iryoku = 2.0f;
    }


    void Update()
    {
        transform.Translate(-0.2f, 0, 0);

        if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }


    }
    
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Renia"){
            //Debug.Log("HITREINA");
            
            //Destroy(coll.gameObject);
            
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