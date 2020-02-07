using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgm1 : MonoBehaviour
{
    public AudioSource bgm_m;

    // Start is called before the first frame update
    void Start()
    {
        if (bgm.bgmflg == false)
        {
            bgm_m.Play();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
