using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoKontrol : MonoBehaviour
{
    public GameObject [] prefabs;
private float sz=1f;
    void Start()
    {
    }
public float zaman=3f;
    void Update()
    {
        if (zaman>0)
        {
            zaman-=Time.deltaTime;
        }else
        {
            sz=Random.Range(10f,11f);
            print(sz);
            zaman=3f;
            Invoke("Olustur",0.1f);
        }
    }
    public Transform ailesi;
    void Olustur()
    {
            int salla=Random.Range(0,prefabs.Length);
            Vector2 position=this.transform.position;
            var x=Instantiate(prefabs[salla],position,Quaternion.identity);
            x.transform.SetParent(ailesi);
    }

}
