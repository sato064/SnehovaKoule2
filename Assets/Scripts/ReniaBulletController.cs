using System.Collections;
using UnityEngine;



public class ReniaBulletController : MonoBehaviour
{
    public static float iryoku;
    void Start(){
        iryoku = 3.0f;
    }


    void Update()
    {
        transform.Translate(0.2f, 0, 0);

        if (transform.position.x > 10)
        {
            Destroy(gameObject);
        }


    }
    
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "RB"){
            //Debug.Log("HITREINA");
            iryoku = iryoku - 1;
            if(iryoku < 1){
                Destroy(this.gameObject);
            }
        }
        if (coll.gameObject.tag == "player2")
        {   Destroy(this.gameObject);
        }

        if(coll.gameObject.tag == "RoundBarrier"){
            //Debug.Log("ROUND HIT CENTER");
            iryoku = iryoku - 3;
            if(iryoku <= 1){
                Destroy(this.gameObject);
            }

        
        }
        if(coll.gameObject.tag == "BigBarrier"){
            iryoku = iryoku - 6;
            if(iryoku <= 1){
                Destroy(this.gameObject);
            }

        
        }

            

        }
    }