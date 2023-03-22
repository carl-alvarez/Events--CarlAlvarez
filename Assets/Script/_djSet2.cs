using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _djSet2 : MonoBehaviour
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
        _EventManager.djSet2 += _combo2;
    }

    void _combo2()
    {
        C1.SetActive(false);
        C2.SetActive(true);
        C3.SetActive(false);
        C4.SetActive(false);
        Debug.Log("Estas escuchando Gangnam Style de Psy");
    }
}
