using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HizKontroler : MonoBehaviour
{
    public float hiz;
    public Rigidbody2D rg;

    void Start()
    {
        rg=this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rg.velocity=new Vector2(0,-hiz*Time.deltaTime);
    }
}
