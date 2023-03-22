using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _djSet1 : MonoBehaviour
{
    public GameObject C1;
    public GameObject C2;
    public GameObject C3;
    public GameObject C4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _EventManager.djSet1 += _combo1;
    }

    void _combo1()
    {
        C1.SetActive(true);
        C2.SetActive(false);
        C3.SetActive(false);
        C4.SetActive(false);
        Debug.Log("Estas escuchando Chicken Dance");
    }
}
