using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal // INHERITANCE
{
 
    protected override void MakeSound() // POLYMORPHISM
    {
        screenText.text = "Dog saying 'woof-woof'";
    }
}
