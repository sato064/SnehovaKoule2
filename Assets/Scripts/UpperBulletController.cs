﻿
using System.Collections;

using UnityEngine;

public class UpperBulletController : MonoBehaviour
{
    public static float iryoku;

    void Start(){
        iryoku = 3.0f;
    }


    void Update()
    {
        if(transform.position.x > -2){
            
            transform.Translate(0.1f, -0.025f, 0);
            Vector3 m_scale = transform.localScale;
            m_scale.x += 0.0023f;
            m_scale.y += 0.0023f;
            transform.localScale = m_scale;

        }
        if(transform.position.x < -2){
            transform.Translate(0.1f, 0.0442f, 0);
            Vector3 m_scale = transform.localScale;
            m_scale.x -= 0.005f;
            m_scale.y -= 0.005f;
            transform.localScale = m_scale;
        }

        if (transform.position.x > 10)
        {
            Destroy(gameObject);
        }


    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Renia"){
            //Debug.Log("HITREINA");
            iryoku = iryoku - 1;
            if(iryoku < 1){
                Destroy(this.gameObject);
            }
        }
        if (coll.gameObject.tag == "player2")
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