using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketKontrol : MonoBehaviour
{
    public float hiz;
    public float max;
    public float min;
    public bool x;
    public bool y;
    private Rigidbody2D rg;
    public float yon=1;
    public float deger;
    void Start()
    {
        rg=this.gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        var pos=transform.position;
        if(pos.x==min || pos.x==max){ yon=yon*-1;}
        if(pos.y==min || pos.y==max){ yon=yon*-1;}  
        if (x==true)
        {
            pos.x=Mathf.Clamp(pos.x,min,max);
            rg.velocity=new Vector2(Time.deltaTime*hiz*yon,0);
        }
        deger=pos.x;
        if (y==true)
        {
            pos.y=Mathf.Clamp(pos.y,min,max);
            rg.velocity=new Vector2(0,Time.deltaTime*hiz*yon);
        }
        pos.z=0;
        this.transform.position=pos;
    }
}
