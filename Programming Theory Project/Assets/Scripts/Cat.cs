using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal // INHERITANCE
{
    protected override void MakeSound() // POLYMORPHISM
    {
        screenText.text = "Cat saying 'meow-meow'";
    }
}
