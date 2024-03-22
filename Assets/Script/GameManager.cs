using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject normalCat;
    public GameObject fatCat;

    public GameObject retryBtn;
    // Start is called before the first frame update
    private void Awake() {
        if(Instance==null){
            Instance = this;
        }
        Application.targetFrameRate = 60;
    }
    void Start()
    {
        InvokeRepeating("MakeCat",0f,1f);
        Time.timeScale=1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void MakeCat(){
        Instantiate(normalCat);
    }
    public void GameOver(){
        retryBtn.SetActive(true);
        Time.timeScale=0f;
    }
}
