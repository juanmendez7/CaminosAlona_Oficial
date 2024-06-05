using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomNumberHandler : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public Button botonDado;
    public Button botonModelos;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public GameObject objeto1;
    public GameObject objeto2;
    public GameObject objeto3;
    public GameObject objeto4;
    public GameObject objeto5;

    private bool dadoLanzado = false;
    private bool modelosActivados = false;

    public void OnBotonDadoClick()
    {
        if (!dadoLanzado)
        {
            int randomNumber = Random.Range(1, 21); // Genera un número aleatorio entre 1 y 20 inclusive
            textMeshPro.text = randomNumber.ToString(); // Muestra el número en el TextMeshPro

            // Desactiva todos los botones al inicio
            button1.gameObject.SetActive(false);
            button2.gameObject.SetActive(false);
            button3.gameObject.SetActive(false);
            button4.gameObject.SetActive(false);
            button5.gameObject.SetActive(false);

            // Activa los botones según el número generado
            if (randomNumber >= 1 && randomNumber <= 10)
            {
                button1.gameObject.SetActive(true);
                button2.gameObject.SetActive(true);
            }
            else if (randomNumber >= 11 && randomNumber <= 18)
            {
                button1.gameObject.SetActive(true);
                button2.gameObject.SetActive(true);
                button3.gameObject.SetActive(true);
                button4.gameObject.SetActive(true);
            }
            else if (randomNumber >= 19 && randomNumber <= 20)
            {
                button1.gameObject.SetActive(true);
                button2.gameObject.SetActive(true);
                button3.gameObject.SetActive(true);
                button4.gameObject.SetActive(true);
                button5.gameObject.SetActive(true);
            }

            // Marca que el dado ha sido lanzado y desactiva el botón dado
            dadoLanzado = true;
            botonDado.interactable = false;

            // Si los modelos están activados, activar los objetos correspondientes
            if (modelosActivados)
            {
                ActivarObjetos(randomNumber);
            }
        }
    }

    public void OnBotonModelosClick()
    {
        modelosActivados = true;
        // Si ya se lanzó el dado, activar los objetos correspondientes
        if (dadoLanzado)
        {
            int randomNumber;
            if (int.TryParse(textMeshPro.text, out randomNumber))
            {
                ActivarObjetos(randomNumber);
            }
        }
    }

    private void ActivarObjetos(int randomNumber)
    {
        // Desactiva todos los objetos al inicio
        objeto1.SetActive(false);
        objeto2.SetActive(false);
        objeto3.SetActive(false);
        objeto4.SetActive(false);
        objeto5.SetActive(false);

        // Activa los objetos según el número generado
        if (randomNumber >= 1 && randomNumber <= 10)
        {
            objeto1.SetActive(true);
            objeto2.SetActive(true);
        }
        else if (randomNumber >= 11 && randomNumber <= 18)
        {
            objeto1.SetActive(true);
            objeto2.SetActive(true);
            objeto3.SetActive(true);
            objeto4.SetActive(true);
        }
        else if (randomNumber >= 19 && randomNumber <= 20)
        {
            objeto1.SetActive(true);
            objeto2.SetActive(true);
            objeto3.SetActive(true);
            objeto4.SetActive(true);
            objeto5.SetActive(true);
        }
    }
}
