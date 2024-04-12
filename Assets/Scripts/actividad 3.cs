using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Comparador : MonoBehaviour
{
    private int input; // Variable encargada de guardar la informaci�n del InputText
    private int numeroSecreto; // Variable para almacenar el n�mero secreto generado aleatoriamente
    public TMP_Text Dialogo;

    // Start is called before the first frame update
    void Start()
    {
        // Generar un n�mero aleatorio entre 1 y 10 como el n�mero secreto al inicio del juego
        numeroSecreto = Random.Range(1, 11);
        Debug.Log("N�mero secreto generado: " + numeroSecreto);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ConvertirStringAInt(string textoInput) // M�todo encargado de comparar el valor del input
    {
        int.TryParse(textoInput, out input); // L�nea de c�digo encargada de convertir un dato tipo String a Int. Esta l�nea toma los datos de "textoInput" y los guarda como entero dentro de la variable "input"

        Comparar();
    }

    void Comparar()
    {
        if (input == numeroSecreto)
        {
            Dialogo.SetText("�Correcto! Has adivinado el n�mero secreto.");

        }
        else
        {
            Dialogo.SetText("�Incorrecto! Intenta de nuevo.");
        }
    }
}