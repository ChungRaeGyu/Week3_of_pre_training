using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject normalCat;
    public GameObject fatCat;

    public GameObject retryBtn;

    public RectTransform levelFront;
    public Text levelTxt;

    int level =0;
    int score = 0;

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
    public void AddScore(){
        score++;
        level = score/5;
        levelTxt.text = level.ToString();
        levelFront.localScale = new Vector3((score-level*5)/5.0f,1,1);
    }
}
