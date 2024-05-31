using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowtoProgram2 : MonoBehaviour
{

    private void Start()
    {

        // Untuk print out messages to the console.
        print("this is from print");

        Debug.Log("this is from debug");

        // Contoh operasi sederhana
        int  a = 17;
        int b = 5;
        int c = a / b;

        // Kalo mau presisi 
        float d = 17;
        float e = 5;
        float f = d / e;

        // Cara operasi string
        string name = "Carl";
        string lastName = "Florian";
        string fullName = name + lastName;

        // Cara tampilin
        Debug.Log("A + B = " + c);

        // Cara lain buat tampilin
        Debug.Log(d + " / " + e + " = " + f);

        Debug.Log("The full name is " + fullName);


    }

}
