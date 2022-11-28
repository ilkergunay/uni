using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sabitHiz : MonoBehaviour
{
    public float sabithizi;
    private Rigidbody2D rg;
    void Start()
    {
        rg=this.gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        rg.velocity=new Vector2(0,-sabithizi*Time.deltaTime);
    }
}
