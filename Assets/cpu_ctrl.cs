﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cpu_ctrl : MonoBehaviour
{
    private static int cflg = 0;

    public void TestEvent1()
    {
        if (cflg != 1)
        {
            cflg = 1;

            //Debug.Log("Toggle1 TestEvent");
        }
        else if (cflg != 0)
        {
            cflg = 0;

            //Debug.Log("Toggle0 TestEvent");
        }


    }
    public static int Getcflg()
    {
        return cflg;

    }


}