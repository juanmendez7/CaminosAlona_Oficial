using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeCargado : MonoBehaviour
{
    public GameObject samuraiPerPanel;
    public GameObject baseHombrePerPanel;
    public GameObject baseWomanPerPanel;
    public GameObject altoHombrePerPanel;
    public GameObject altoWomanPerPanel;

    public GameObject samuraiPer;
    public GameObject baseHombrePer;
    public GameObject baseWomanPer;
    public GameObject altoHombrePer;
    public GameObject altoWomanPer;

    public GameObject[] camaras;

    public bool samurai;
    public bool baseHombre;
    public bool baseWoman;
    public bool altoHombre;
    public bool altoWoman;

    private void Update()
    {
        

        samurai = PlayerPrefs.GetInt("samuraiSelect") == 1;
        baseHombre = PlayerPrefs.GetInt("baseHombreSelect") == 1;
        baseWoman = PlayerPrefs.GetInt("baseWomanSelect") == 1;
        altoHombre = PlayerPrefs.GetInt("altoHombreSelect") == 1;
        altoWoman = PlayerPrefs.GetInt("altoWomanSelect") == 1;

        if (samurai == true)
        {
            samuraiPer.SetActive(true);
            samuraiPerPanel.SetActive(true);
            Destroy(baseHombrePer);
            Destroy(baseWomanPer);
            Destroy(altoHombrePer);
            Destroy(altoWomanPer);
            Destroy(baseHombrePerPanel);
            Destroy(baseWomanPerPanel);
            Destroy(altoHombrePerPanel);
            Destroy(altoWomanPerPanel);

        }

        if (baseHombre == true)
        {
            baseHombrePer.SetActive(true);
            baseHombrePerPanel.SetActive(true);
            Destroy(baseWomanPer);
            Destroy(altoHombrePer);
            Destroy(altoWomanPer);
            Destroy(samuraiPer);
            Destroy(baseWomanPerPanel);
            Destroy(altoHombrePerPanel);
            Destroy(altoWomanPerPanel);
            Destroy(samuraiPerPanel);

        }

        if (baseWoman == true)
        {
            baseWomanPer.SetActive(true);
            baseWomanPerPanel.SetActive(true);
            Destroy(altoWomanPer);
            Destroy(altoHombrePer);
            Destroy(samuraiPer);
            Destroy(baseHombrePer);
            Destroy(altoWomanPerPanel);
            Destroy(altoHombrePerPanel);
            Destroy(samuraiPerPanel);
            Destroy(baseHombrePerPanel);
        }

        if (altoHombre == true)
        {
            altoHombrePer.SetActive(true);
            altoHombrePerPanel.SetActive (true);
            Destroy(altoWomanPer);
            Destroy(baseHombrePer);
            Destroy(samuraiPer);
            Destroy(baseWomanPer);
            Destroy(altoWomanPerPanel);
            Destroy(baseHombrePerPanel);
            Destroy(samuraiPerPanel);
            Destroy(baseWomanPerPanel);

        }

        if (altoWoman == true)
        {
            altoWomanPer.SetActive (true);
            altoWomanPerPanel.SetActive(true);
            Destroy(altoHombrePer);
            Destroy(baseWomanPer);
            Destroy(samuraiPer);
            Destroy(baseHombrePer);
            Destroy(altoHombrePerPanel);
            Destroy(baseWomanPerPanel);
            Destroy(samuraiPerPanel);
            Destroy(baseHombrePerPanel);

        }

    }

    public void camarafue()
    {
        if (samurai == true)
        {
            camaras[3].SetActive(true);
            for (int i = 0; i < camaras.Length; i++)
            {
                if (i != 3 && camaras[i] != null)
                {
                    Destroy(camaras[i]);
                }
            }
        }

        if (baseHombre == true)
        {
            camaras[4].SetActive(true);
            for (int i = 0; i < camaras.Length; i++)
            {
                if (i != 4 && camaras[i] != null)
                {
                    Destroy(camaras[i]);
                }
            }

        }

        if (baseWoman == true)
        {
            camaras[0].SetActive(true);
            for (int i = 0; i < camaras.Length; i++)
            {
                if (i != 0 && camaras[i] != null)
                {
                    Destroy(camaras[i]);
                }
            }
        }

        if (altoHombre == true)
        {
            camaras[1].SetActive(true);
            for (int i = 0; i < camaras.Length; i++)
            {
                if (i != 1 && camaras[i] != null)
                {
                    Destroy(camaras[i]);
                }
            }

        }

        if (altoWoman == true)
        {
            camaras[2].SetActive(true);
            for (int i = 0; i < camaras.Length; i++)
            {
                if (i != 2 && camaras[i] != null)
                {
                    Destroy(camaras[i]);
                }
            }

        }
    }

}
