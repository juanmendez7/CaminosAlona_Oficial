using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ciclo_dia : MonoBehaviour
{
    [Range(0.0f, 24.0f)] public float hora = 12;
    public Transform sol;
    public float durDia = 1;

    private float solx;

    void rotacionSol()
    {
        solx = 15 * hora;
        sol.localEulerAngles = new Vector3 (solx, 0, 0);

        if (hora < 6 || hora > 18)
        {
            sol.GetComponent<Light>().intensity = 0;
        }
        else
        {
            sol.GetComponent <Light>().intensity = 1;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hora += Time.deltaTime * (24 / (60 * durDia));
        if (hora >= 24)
        {
            hora = 0;
        }
        rotacionSol();
    }
}
