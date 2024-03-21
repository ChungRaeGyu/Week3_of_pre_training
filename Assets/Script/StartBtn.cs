using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBtn : MonoBehaviour
{
    // Start is called before the first frame update
    public void Startbtn(){
        SceneManager.LoadScene("MainScene");
    }
}
