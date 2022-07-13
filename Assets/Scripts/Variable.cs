using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable : MonoBehaviour
{

    
    public int var = 0;



    private void ChangeVarP()
    {
        var += 1;
    }

    private void ChangeVarN()
    {
        var -= 1;
    }

    void Start()
    {
       
    }

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.A))
        {
            ChangeVarP();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            ChangeVarN();
        }
    }
}
