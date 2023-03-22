using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class _EventManager : MonoBehaviour
{
    public static event Action djSet1;
    public static event Action djSet2;
    public static event Action djSet3;
    public static event Action djSet4;
    public static event Action djSetF;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            djSetF?.Invoke();
        }

        if (Input.GetKey(KeyCode.Q))
        {
            djSet1?.Invoke();
        }

        if (Input.GetKey(KeyCode.W))
        {
            djSet2?.Invoke();
        }

        if (Input.GetKey(KeyCode.E))
        {
            djSet3?.Invoke();
        }

        if (Input.GetKey(KeyCode.R))
        {
            djSet4?.Invoke();
        }
    }
}
