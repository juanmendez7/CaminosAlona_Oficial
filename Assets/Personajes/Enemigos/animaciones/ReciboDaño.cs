using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReciboDaño : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("arma"))
        {
            print("daño");
        }
    }

}
