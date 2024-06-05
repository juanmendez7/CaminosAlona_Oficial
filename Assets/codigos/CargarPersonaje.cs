using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargarPersonaje : MonoBehaviour
{
    public bool samurai;
    public bool baseHombre;
    public bool baseWoman;
    public bool altoHombre;
    public bool altoWoman;


    private void Awake()
    {
        samurai = PlayerPrefs.GetInt("samuraiSelect") == 1;
        baseHombre = PlayerPrefs.GetInt("baseHombreSelect") == 1;
        baseWoman = PlayerPrefs.GetInt("baseWomanSelect") == 1;
        altoHombre = PlayerPrefs.GetInt("altoHombreSelect") == 1;
        altoWoman = PlayerPrefs.GetInt("altoWomanSelect") == 1;
    }


    private void Update()
    {
        if(baseWoman == false && samurai == false && baseHombre == false && altoHombre == false && altoWoman == false)
        {
            baseWoman = true;
        }


    }


    public void PersonajeSamurai()
    {
        samurai = true;
        baseHombre = false; 
        baseWoman = false;
        altoHombre = false;
        altoWoman = false;
        Guardar();
    }


    public void PersonajeBaseHombre()
    {
        baseHombre = true;
        baseWoman = false;
        altoHombre = false;
        altoWoman = false;
        samurai=false;
        Guardar();
    }


    public void PersonajeBaseWoman()
    {
        baseWoman = true;
        altoWoman = false;
        samurai=false;
        baseHombre=false;
        altoHombre=false;
        Guardar();
    }


    public void PersonajeAltoHombre()
    {
        altoHombre = true;
        altoWoman = false;
        samurai=false;
        baseHombre=false;
        baseWoman=false;
        Guardar();

    }


    public void PersonajeAltoWoman()
    {
        altoWoman = true;
        samurai=false;
        baseHombre=false;
        baseWoman=false;
        altoHombre = false;
        Guardar();
    }



    public void Guardar()
    {
        PlayerPrefs.SetInt("samuraiSelect", samurai ? 1 : 0);
        PlayerPrefs.SetInt("baseHombreSelect", baseHombre ? 1 : 0);
        PlayerPrefs.SetInt("baseWomanSelect", baseWoman ? 1 : 0);
        PlayerPrefs.SetInt("altoHombreSelect", altoHombre ? 1 : 0);
        PlayerPrefs.SetInt("altoWomanSelect", altoWoman ? 1 : 0);
    }


}
