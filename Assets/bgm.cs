using UnityEngine;
using System.Collections;

public class bgm : MonoBehaviour
{
    public bool DontDestroyEnabled = true;
    public AudioSource bgm1;

    private bool p = true;

    // Use this for initialization
    void Start()
    {
        if (p)
        {
            if (DontDestroyEnabled)
            {
                bgm1.Play();
                // Sceneを遷移してもオブジェクトが消えないようにする
                DontDestroyOnLoad(this);
                p = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}