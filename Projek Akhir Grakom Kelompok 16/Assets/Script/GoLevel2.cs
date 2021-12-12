using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoLevel2 : MonoBehaviour
{
    public void Golev2(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(4);
    }
}
