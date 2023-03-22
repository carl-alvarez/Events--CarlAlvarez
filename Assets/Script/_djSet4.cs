using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _djSet4 : MonoBehaviour
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
        _EventManager.djSet4 += _combo4;
    }

    void _combo4()
    {
        C1.SetActive(false);
        C2.SetActive(false);
        C3.SetActive(false);
        C4.SetActive(true);
        Debug.Log("Estas escuchando Vato de Snoop Dogg");
    }
}
