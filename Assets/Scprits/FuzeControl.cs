using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FuzeControl : MonoBehaviour
{
    public float hiz;
    public float zaman=3f;
    public GameObject[] prefabs;
    private bool onay=false;
    public TextMeshProUGUI yazAtis;
    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition= Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 kendiPos= new Vector3(transform.position.x, transform.position.y,0);
        transform.position=Vector3.MoveTowards(kendiPos,new Vector3(mousePosition.x,transform.position.y,0),Time.deltaTime*hiz);
        var pos=transform.position;
        pos.x=Mathf.Clamp(pos.x,-6f,6f);
        transform.position=pos; 
            if (zaman>0)
            {
                zaman-=Time.deltaTime;
                onay=false;
            }else
            {
                onay=true;
            }
        if (Input.GetMouseButtonDown(0) && onay)
        {
            Invoke("Olustur",0.01f);
            onay=false;
            zaman=3f;
        }
        yazAtis.text=Mathf.Ceil(zaman).ToString();
        //Aldığımız Puanları yazdırma
        yaz.GetComponent<TextMeshProUGUI>().text=Hesapla.rekor.ToString();
    }
    public GameObject yaz;
    public Transform ailesi;
    void Olustur()
    {
            int salla=Random.Range(0,prefabs.Length);
            Vector2 position=this.transform.position;
            var x=Instantiate(prefabs[salla],position,Quaternion.identity);
            x.transform.SetParent(ailesi);
    }
}
