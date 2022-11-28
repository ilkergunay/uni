using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    //[SerializeField] private double sec=0;
    [SerializeField] private Button Ayarlar =null;
    //[SerializeField] private Button Kapat =null;
    void Start() {
        Ayarlar.onClick.AddListener(()=>OyunuBaslat());
    }
    
    public void OyunuBaslat()
    {
            SceneManager.LoadScene("Oyun");
    }
    public void CikisYap()
    {
        Application.Quit();     
    }



}
