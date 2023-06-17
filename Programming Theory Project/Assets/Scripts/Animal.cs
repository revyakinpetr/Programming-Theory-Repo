using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Animal : MonoBehaviour
{
    public TextMeshProUGUI screenText;

    private void OnMouseDown()
    {
        MakeSound(); // ABSTRACTION
    }

    protected virtual void MakeSound()
    {
        screenText.text = "Animal saying 'Hello' to you";
    }
}
