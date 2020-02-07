using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cs1 : MonoBehaviour
{
    public void ButtonClicked()
    {
        cpu_ctrl.onflg();

        SceneManager.LoadScene("Decide1");
    }
}
