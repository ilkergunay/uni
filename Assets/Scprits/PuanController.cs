using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuanController : MonoBehaviour
{
    public GameObject efect;

    private void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag=="ufoplayer")
        {
            Hesapla.rekor++;
            Hesapla.Renk++;
            col.gameObject.GetComponent<SpriteRenderer>().color=Color.HSVToRGB(0,0,100);
            Destroy(this.gameObject);
        }
        else if(col.gameObject.tag=="simsek")
        {
            Destroy(this.gameObject);
            Destroy(col.gameObject);
            var x=Instantiate(efect,transform.position,Quaternion.identity);
        }
    }
}
