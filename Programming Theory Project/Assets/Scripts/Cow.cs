using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : Animal // INHERITANCE
{
    protected override void MakeSound() // POLYMORPHISM
    {
        screenText.text = "Cow saying 'muuuuu'";
    }
}
