using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _baileControl : MonoBehaviour
{
    
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q) && anim.GetBool("Combo1") == false)
        {
            anim.SetBool("Combo1", true);
            anim.SetBool("Combo4", false);
            anim.SetBool("Combo3", false);
            anim.SetBool("Combo2", false);
        }

        if (Input.GetKey(KeyCode.W) && anim.GetBool("Combo2") == false)
        {
            anim.SetBool("Combo2", true);
            anim.SetBool("Combo1", false);
            anim.SetBool("Combo3", false);
            anim.SetBool("Combo4", false);
        }

        if (Input.GetKey(KeyCode.E) && anim.GetBool("Combo3") == false)
        {
            anim.SetBool("Combo3", true);
            anim.SetBool("Combo1", false);
            anim.SetBool("Combo4", false);
            anim.SetBool("Combo2", false);
        }

        if (Input.GetKey(KeyCode.R) && anim.GetBool("Combo4") == false)
        {
            anim.SetBool("Combo4", true);
            anim.SetBool("Combo1", false);
            anim.SetBool("Combo3", false);
            anim.SetBool("Combo2", false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("Combo4", false);
            anim.SetBool("Combo1", false);
            anim.SetBool("Combo3", false);
            anim.SetBool("Combo2", false);
        }
    }
}
