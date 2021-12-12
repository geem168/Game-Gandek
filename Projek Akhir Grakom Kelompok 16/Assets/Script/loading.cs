using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loading : MonoBehaviour
{
    public Transform loadingBar;

    [SerializeField]
    public float nilaiSekarang;
    [SerializeField]
    public float nilaiKecepatan;

    // Update is called once per frame
    void Update()
    {
        if(nilaiSekarang<100){
            nilaiSekarang += nilaiKecepatan * Time.deltaTime;
            Debug.Log ((int)nilaiSekarang);
        }
        else{
            Application.LoadLevel("Main_Menu");
        }
        loadingBar.GetComponent<Image>().fillAmount = nilaiSekarang/100;
    }
}
