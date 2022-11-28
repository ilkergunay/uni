using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerKontroler : MonoBehaviour
{
    public float hiz;
    public float skor;
    public GameObject al;
    public GameObject maxSkorYaz;
    public GameObject efect;
    void Update()
    {
        /*
        float yatay=Input.GetAxis("Horizontal")*hiz*Time.deltaTime;
        float x=Mathf.Clamp(yatay,-6,6);
        gameObject.transform.Translate(x,0,0);
        */
        maxSkorYaz.GetComponent<TextMeshProUGUI>().text="Max Skor:"+PlayerPrefs.GetFloat("rekor").ToString();
    
    Vector2 mousePosition= Camera.main.ScreenToWorldPoint(Input.mousePosition);
    Vector3 kendiPos= new Vector3(transform.position.x, transform.position.y,0);
    transform.position=Vector3.MoveTowards(kendiPos,new Vector3(mousePosition.x,transform.position.y,0),Time.deltaTime*hiz);
    var pos=transform.position;
    pos.x=Mathf.Clamp(pos.x,-6f,6f);
    transform.position=pos; 


    }
    public GameObject [] efect2;
    public AudioClip bom;
    void OnCollisionEnter2D(Collision2D coll)
    {
        AudioSource.PlayClipAtPoint(bom,coll.transform.position);

        if(coll.gameObject.tag=="para")
        {
            skor=skor+10;
            Instantiate(efect2[0],coll.transform.position,Quaternion.identity);
        }
        else if(coll.gameObject.tag=="kalp")
        {
            skor=skor+100;
            Instantiate(efect2[1],coll.transform.position,Quaternion.identity);
        }
        else if(coll.gameObject.tag=="simsek")
        {
            skor=skor+50;
            Instantiate(efect2[0],coll.transform.position,Quaternion.identity);
        }
        else {}
        Destroy(coll.gameObject);
        al.GetComponent<TextMeshProUGUI>().text=skor.ToString();
        if (skor>PlayerPrefs.GetFloat("rekor"))
        {
            PlayerPrefs.SetFloat("rekor",skor);
        }
        
    
    }



}
