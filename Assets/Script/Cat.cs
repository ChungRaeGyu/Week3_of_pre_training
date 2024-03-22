using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public GameObject hungryCat;
    public GameObject fullCat;

    public RectTransform front;
    
    float full = 5.0f;
    float energy = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-9.0f,9.0f);
        float y = 30.0f;
        transform.position=new Vector2(x,y);
    }

    // Update is called once per frame
    void Update()
    {
        if(energy<full){
            transform.position += Vector3.down * 0.05f;
            if(transform.position.y<-16){
                GameManager.Instance.GameOver();
            }
        }else{
            if(transform.position.x>0){
                transform.position += Vector3.right * 0.05f;
            }else{
                transform.position += Vector3.left * 0.05f;
            }
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Food")){
            if(energy<full){
                energy += 1.0f;
                front.localScale = new Vector3(energy / full, 1.0f, 1.0f);
                Destroy(other.gameObject);
                if(energy==5){
                    hungryCat.SetActive(false);
                    fullCat.SetActive(true);
                    Destroy(gameObject, 3.0f);
                }
            }
        }
    }
}
