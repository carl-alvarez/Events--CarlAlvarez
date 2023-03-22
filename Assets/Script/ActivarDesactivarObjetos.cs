using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActivarDesactivarObjetos : MonoBehaviour
{
    public GameObject[] objetos; // arreglo de objetos a controlar

    public UnityEvent activarObjetoQ;
    public UnityEvent activarObjetoW;
    public UnityEvent activarObjetoE;
    public UnityEvent activarObjetoR;
    public UnityEvent desactivarTodo;

    void Update()
    {
        // revisar si se presiona la tecla Q
        if (Input.GetKeyDown(KeyCode.Q))
        {
            activarObjetoQ.Invoke();
            Debug.Log("Estas escuchando Chicken Dance");
        }

        // revisar si se presiona la tecla W
        if (Input.GetKeyDown(KeyCode.W))
        {
            activarObjetoW.Invoke();
            Debug.Log("Estas escuchando Gangnam Style de Psy");
        }

        // revisar si se presiona la tecla E
        if (Input.GetKeyDown(KeyCode.E))
        {
            activarObjetoE.Invoke();
            Debug.Log("Estas escuchando The Twist de Chubby Checker");
        }

        // revisar si se presiona la tecla R
        if (Input.GetKeyDown(KeyCode.R))
        {
            activarObjetoR.Invoke();
            Debug.Log("Estas escuchando Vato de Snoop Dogg");
        }

        // revisar si se presiona la tecla Espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            desactivarTodo.Invoke();
            Debug.Log("Se cortó la música");
        }
    }

    // activar o desactivar un objeto según su índice en el arreglo
    public void ToggleObject(int index)
    {
        if (index >= 0 && index < objetos.Length)
        {
            objetos[index].SetActive(!objetos[index].activeSelf);
        }
    }

    // activar o desactivar todos los objetos
    public void ToggleAllObjects(bool value)
    {
        foreach (GameObject objeto in objetos)
        {
            objeto.SetActive(value);
        }
    }
}
