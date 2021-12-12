using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoScene : MonoBehaviour
{
    

    

    public void Home(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    
    
}
