using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _djSet1 : MonoBehaviour
{
    public GameObject C1;
    public GameObject C2;
    public GameObject C3;
    public GameObject C4;

private bool comboUno = false;
    // Start is called before the first frame update
    void Start()
    {
        _EventManager.djSet1 += _combo1;
    }

    // Update is called once per frame
    void Update()
    {
        if (comboUno == true){
	C1.SetActive(true);
        C2.SetActive(false);
        C3.SetActive(false);
        C4.SetActive(false);
        Debug.Log("Estas escuchando Chicken Dance");

}
    }

    void _combo1()
    {
     	   comboUno = true;
    }

	void OnDisable(){
}
}
