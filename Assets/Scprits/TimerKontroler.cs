using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TimerKontroler : MonoBehaviour
{
    public float zaman=5f;
    public GameObject yaz;
    public GameObject top;
    public float guc;
    public Transform parent;
    void Update()
    {
        if (zaman>=0)
        {
            zaman=zaman-Time.deltaTime;
            float zaman2=Mathf.Floor(zaman);
            yaz.GetComponent<TextMeshProUGUI>().text=zaman2.ToString();
        }
        Vector2 mousePosition=Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(Input.GetMouseButtonDown(0))
        {
            var x=Instantiate(top,new Vector3(0,0,0),Quaternion.identity);
            x.transform.SetParent(parent);
            x.GetComponent<Rigidbody2D>().AddForce(new Vector2(mousePosition.x,mousePosition.y).normalized*guc);
            Destroy(x,2f);
        }
     }
}
