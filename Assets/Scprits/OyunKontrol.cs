using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OyunKontrol : MonoBehaviour
{
    public float arttir=0;
    public GameObject al;
    public GameObject [] prefabs;

    void Start()
    {

        al.GetComponent<TextMeshProUGUI>().text="0";
        InvokeRepeating("Olustur",0.1f,1f);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            arttir++;
        }
    }
    void Olustur()
    {
            int salla=Random.Range(0,prefabs.Length);
            Vector2 position=new Vector2(Random.Range(-7,7),18);
            var x=Instantiate(prefabs[salla],position,Quaternion.identity);
    }
}
