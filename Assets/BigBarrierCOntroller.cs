using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBarrierCOntroller : MonoBehaviour
{
    private float HP; 
    // Start is called before the first frame update
    void Start()
    {
        HP = 6.0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Renia"){
            
            HP = HP - 1;
            if(HP < 1){
                Destroy(this.gameObject);
            }
        }

        
        
        if(coll.gameObject.tag == "All"){
            HP = HP - 3;
            if(HP <= 1){
                Destroy(this.gameObject);
            }

        
        }

        if(coll.gameObject.tag == "Big"){
            
            HP = HP - 6;
            if(HP <= 1){
                Destroy(this.gameObject);
            }

        
        }
        if (coll.gameObject.tag == "player2")
        {   Destroy(this.gameObject);
        }

            

        }
}
