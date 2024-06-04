using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cara : MonoBehaviour
{

    public int Numero;

    public bool TocaSuelo;

    // Start is called before the first frame update
    void Start()
    {
        Numero = int.Parse(GetComponent<TextMeshPro>().text);    
    }


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Piso")
        {
            print("toca suelo");
            TocaSuelo = true;

        }
    }

     void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Piso")
        {
            print("toca suelo");
            TocaSuelo = false;

        }
    }
}
