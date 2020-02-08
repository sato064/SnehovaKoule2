
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cpu_ctrl : MonoBehaviour
{
    private static int cflg = 0;

    public static bool p = true;

    public void TestEvent1()
    {


    }
    public static void changep()
    {
        p = false;
    }
    public static void truep()
    {
        p = true;
    }
    public static bool getp()
    {
        return p;
    }
    public static int Getcflg()
    {
        return cflg;

    }
    public static void onflg()
    {
        cflg = 1;
    }
    public static void offflg()
    {
        cflg = 0;
    }


}