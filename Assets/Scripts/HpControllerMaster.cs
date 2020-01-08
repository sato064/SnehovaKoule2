using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpControllerMaster : MonoBehaviour
{
    private static float HP1p;
    private static float HP2p;
    // Start is called before the first frame update
    void Start()
    {
        HP1p = 20f;
        HP2p = 20f;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void ChangeHP1(float a){
        HP1p -= a;
    }
    public static void ChangeHP2(float a){
        HP2p -= a;
    }
    public static float getHP1(){
        return HP1p;
    }
    public static float getHP2(){
        return HP2p;
    }

}
