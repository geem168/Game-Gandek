using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoLevel1 : MonoBehaviour
{
    public void Golev1(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(3);
    }
}
