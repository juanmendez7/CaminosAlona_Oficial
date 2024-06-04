using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dado : MonoBehaviour
{

    public TextMeshProUGUI texto;
    public Cara[] caras;

    public int NumeroActual;


    public
    // Start is called before the first frame update
    void Start()
    {
        NumeroDado(); 
    }


    // Update is called once per frame
    void Update()
    {
        texto.text = "Numero: " + NumeroActual;

    }

    void NumeroDado()
    {
        for(int i= 0; i< caras.Length; i++){
            if(caras[i].TocaSuelo){
                NumeroActual = 20 - caras[i].Numero;
            }
        }

        Invoke("NumeroDado", 0.5f);
    }

    public void LanzarDado()
    {
        float fuerzaInicial = Random.Range(1,6);
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Rigidbody>().AddForce(new Vector3(0,fuerzaInicial*100,0));
        GetComponent<Rigidbody>().rotation = Random.rotation;
    }
}
