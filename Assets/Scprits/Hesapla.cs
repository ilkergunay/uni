using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hesapla : MonoBehaviour
{
    private static float _puan;
    public static void PuanArttir()
    {
        _puan++;
    }
    public static float puanGoster()
    {
        return _puan;
    }
    private static float _rekor;
    public static float rekor
    {
        set{ _rekor=value; }
        get{ return _rekor;}
    }
    private static float _renk;
    public static float Renk
    {
        set{ _renk=value; }
        get{ return _renk;}
    }
            
         

}
