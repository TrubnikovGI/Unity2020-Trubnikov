using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Oscillate : MonoBehaviour

{

    public Vector3 pos;
    public float Amplitude1, Amplitude2, Omega1, Omega2, Omega3, Phase, t;

    void Start()

    {

        pos = new Vector3(0, 0, 0);

        Omega1 = 1;
        Omega2 = 2;
        Amplitude1 = 8;
        Amplitude2 = 3;
        Phase = 5;
        t = 0;

    }

    void Update()

    {
        t = t + Time.deltaTime;
        pos = new Vector3((float)(Amplitude1 * Math.Sin(Omega1 * t + Phase)), 0, (float)(Amplitude2 * Math.Sin(Omega2 * t + Phase)));
        transform.position = pos;
    }

}