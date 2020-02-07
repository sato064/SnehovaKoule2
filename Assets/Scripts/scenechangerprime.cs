using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scenechangerprime : MonoBehaviour
{
    public void ButtonClicked()
    {
        cpu_ctrl.offflg();

        SceneManager.LoadScene("Decide1");
    }
}
