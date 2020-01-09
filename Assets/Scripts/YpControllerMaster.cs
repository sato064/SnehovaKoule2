using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YpControllerMaster : MonoBehaviour


{

    private static float YP1p;
    private static float YP2p;
        // Start is called before the first frame update
    void Start()
    {
        YP1p = 25;
        YP2p = 25;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void ChangeYP1(float a){
        YP1p -= a;
    }
    public static void ChangeYP2(float a){
        YP2p -= a;
    }
    public static void PlusYP1(float a){
        YP1p += a;
    }
    public static void PlusYP2(float a){
        YP2p += a;
    }
    public static float getYP1(){
        return YP1p;
    }
    public static float getYP2(){
        return YP2p;
    }
}
