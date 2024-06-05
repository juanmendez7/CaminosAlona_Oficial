using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeCargado : MonoBehaviour
{
    public GameObject samuraiPer;
    public GameObject baseHombrePer;
    public GameObject baseWomanPer;
    public GameObject altoHombrePer;
    public GameObject altoWomanPer;

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
            Destroy(baseHombrePer);
            Destroy(baseWomanPer);
            Destroy(altoHombrePer);
            Destroy(altoWomanPer);
        }

        if (baseHombre == true)
        {
            baseHombrePer.SetActive(true);
            Destroy(baseWomanPer);
            Destroy(altoHombrePer);
            Destroy(altoWomanPer);
            Destroy(samuraiPer);

        }

        if (baseWoman == true)
        {
            baseWomanPer.SetActive(true);
            Destroy(altoWomanPer);
            Destroy(altoHombrePer);
            Destroy(samuraiPer);
            Destroy(baseHombrePer);
        }

        if (altoHombre == true)
        {
            altoHombrePer.SetActive (true);
            Destroy(altoWomanPer);
            Destroy(baseHombrePer);
            Destroy(samuraiPer);
            Destroy(baseWomanPer);

        }

        if (altoWoman == true)
        {
            altoWomanPer.SetActive (true);
            Destroy(altoHombrePer);
            Destroy(baseWomanPer);
            Destroy(samuraiPer);
            Destroy(baseHombrePer);

        }

    }


}
