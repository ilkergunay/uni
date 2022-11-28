using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunuDurdur : MonoBehaviour
{
    public bool onay=false;
    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && onay)
        {
            SceneManager.LoadScene("Menu");
            Time.timeScale=1;
        }
    }
    void OnCollisionEnter2D(Collision2D coll) {
        Destroy(coll.gameObject);
        Time.timeScale=0;
        onay=true;
    }
}
