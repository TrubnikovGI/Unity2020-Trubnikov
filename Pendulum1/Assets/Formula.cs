using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class Formula : MonoBehaviour
{
    public Vector3 pos;
    public float phi, phi_0, vol, Lenght;
    private float t;

    void Start()
    {
        Lenght = 5.0f;
        vol = 1f;
        t = 0;
        phi_0 = 0.75f;
        pos = new Vector3((float)(Lenght * Math.Sin(phi_0)), (float)(Lenght * Math.Cos(phi_0)), 0);
    }

    void Update()
    {
        t = t + Time.deltaTime;
        phi = (float)(phi_0 * Math.Cos(Math.Sqrt(9.81 / Lenght) * t) + vol * Math.Sqrt(Lenght / 9.81) * Math.Sin(Math.Sqrt(9.81 / Lenght) * t));
        pos = new Vector3((float)(Lenght * Math.Sin(phi)), -(float)(Lenght * Math.Cos(phi)), 0);
        transform.position = pos;
    }
}
