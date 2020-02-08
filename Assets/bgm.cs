using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class bgm : MonoBehaviour
{
    public bool DontDestroyEnabled = true;
    public AudioSource bgm1;

    public static bool bgmflg;

    public bool p;



    // Use this for initialization
    void Start()
    {


        p = cpu_ctrl.getp();

        if (p == true)
        {
            if (DontDestroyEnabled)
            {
                bgm1.Play();
                DontDestroyOnLoad(this);
                cpu_ctrl.changep();
                bgmflg = true;

            }

        }
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Init")
        {
            cpu_ctrl.truep();
            this.gameObject.SetActive(false);

        }

    }


    // Update is called once per frame


}