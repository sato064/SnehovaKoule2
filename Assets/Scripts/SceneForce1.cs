using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneForce1 : MonoBehaviour
{
    // Start is called before the first frame update
    private float now;
    private float delta;
    void Start()
    {
        now = Time.time;
        
    }

    // Update is called once per frame
    void Update()
    {
        delta = Time.time - now;
        //Debug.Log ("経過時間(秒)" + delta );
        if(delta > 5.0){
            SceneManager.LoadScene("Decide2");
        }
    }
}
