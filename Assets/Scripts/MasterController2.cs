﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MasterController2 : MonoBehaviour
{

    private static int kyushu = 0;

    private static int barrier = 0;

    public AudioClip sound1;
    public AudioSource audioSource;

    private float yp1;
    private float yp2;

    private int flg1;

    private int flg2;

    private bool isShift;

    private bool isShift2;

    public GameObject img1;

    public GameObject img2;

    public GameObject img3;

    public GameObject img4;
    public GameObject img5;

    public GameObject img6;

    public GameObject img7;

    public GameObject img8;


    void Start()
    {
        kyushu = 0;
        barrier = 0;
        if (YpControllerMaster.getYP1() <= 25)
        {
            YpControllerMaster.PlusYP1(2);
        }
        if (YpControllerMaster.getYP2() <= 25)
        {
            YpControllerMaster.PlusYP2(2);
        }

        //YPstore.AddYP1(2);
        //YPstore.AddYP2(2);

        int c_b = Random.Range(1, 4);
        Debug.Log(cpu_ctrl.Getcflg());
        if (cpu_ctrl.Getcflg() == 1)
        {
            if (YpControllerMaster.getYP2() >= 6)
            {
                kyushu = c_b;
            }
            else if (YpControllerMaster.getYP2() >= 4 && c_b == 2)
            {
                kyushu = c_b;
            }


        }



    }
    public static int getKyushu()
    {
        return kyushu;
    }
    public static int getBarrier()
    {
        return barrier;
    }
    public void dimimg()
    {
        img1.SetActive(false);
        img2.SetActive(false);
        img3.SetActive(false);
        img4.SetActive(false);


    }
    public void dimimg2()
    {
        img5.SetActive(false);
        img6.SetActive(false);
        img7.SetActive(false);
        img8.SetActive(false);


    }
    public void aprimg()
    {
        img1.SetActive(true);
        img2.SetActive(true);
        img3.SetActive(true);
        img4.SetActive(true);


    }
    public void aprimg2()
    {
        img5.SetActive(true);
        img6.SetActive(true);
        img7.SetActive(true);
        img8.SetActive(true);


    }

    void Update()
    {
        yp1 = YpControllerMaster.getYP1();
        yp2 = YpControllerMaster.getYP2();

        if (flg1 == 0)
        {

            isShift = Input.GetKey(KeyCode.A);

            if (isShift)
            {

                if (Input.GetKeyDown(KeyCode.Q))
                {
                    if (yp1 >= 6)
                    {
                        barrier = 1;
                        flg1 = 1;
                        //audioSource.Play();
                        audioSource.PlayOneShot(sound1);
                        dimimg();

                    }
                }
                if (Input.GetKeyDown(KeyCode.W))
                {
                    if (yp1 >= 4)
                    {
                        barrier = 2;
                        flg1 = 1;
                        audioSource.PlayOneShot(sound1);
                        dimimg();

                    }
                }
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (yp1 >= 6)
                    {
                        barrier = 3;
                        flg1 = 1;
                        audioSource.PlayOneShot(sound1);
                        dimimg();

                    }
                }
                if (Input.GetKeyDown(KeyCode.R))
                {

                    barrier = 0;
                    flg1 = 1;
                    audioSource.PlayOneShot(sound1);
                    dimimg();


                }

            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {

            //Debug.Log("Q");

            barrier = 0;
            flg1 = 0;
            aprimg();
        }

        if (flg2 == 0)
        {

            isShift2 = Input.GetKey(KeyCode.L);

            if (isShift2)
            {

                if (Input.GetKeyDown(KeyCode.I))
                {
                    if (yp2 >= 5)
                    {

                        kyushu = 1;
                        flg2 = 1;
                        dimimg2();

                    }
                }

                if (Input.GetKeyDown(KeyCode.O))
                {
                    if (yp2 >= 4)
                    {

                        kyushu = 2;
                        flg2 = 1;
                        audioSource.PlayOneShot(sound1);
                        dimimg2();

                    }

                }
                if (Input.GetKeyDown(KeyCode.P))
                {
                    if (yp2 >= 5)
                    {

                        kyushu = 3;
                        flg2 = 1;
                        audioSource.PlayOneShot(sound1);
                        dimimg2();
                    }


                }
                if (Input.GetKeyDown(KeyCode.U))
                {

                    kyushu = 0;
                    flg1 = 1;
                    audioSource.PlayOneShot(sound1);
                    dimimg2();


                }
            }



        }
        if ((flg1 == 1) && (flg2 == 1))
        {
            SceneManager.LoadScene("Calculation2");


        }
    }
}

