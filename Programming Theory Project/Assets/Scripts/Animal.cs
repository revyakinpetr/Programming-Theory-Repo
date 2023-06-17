using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Animal : MonoBehaviour
{
    public TextMeshProUGUI screenText;
    private string animalName { get; set; } // ENCAPSULATION

    private void OnMouseDown()
    {
        animalName = "Animal";
        MakeSound(); // ABSTRACTION
    }

    protected virtual void MakeSound()
    {
        screenText.text = animalName + " saying 'Hello' to you";
    }
}
