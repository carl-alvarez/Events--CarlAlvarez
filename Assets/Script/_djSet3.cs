using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _djSet3 : MonoBehaviour
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
        _EventManager.djSet3 += _combo3;
    }

    void _combo3()
    {
        C1.SetActive(false);
        C2.SetActive(false);
        C3.SetActive(true);
        C4.SetActive(false);
        Debug.Log("Estas escuchando The Twist de Chubby Checker");
    }
}
