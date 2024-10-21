using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Age_difference : MonoBehaviour
{
    short age = 21;             
    short yearAdd = 1;           
    double height = 1 / 3.0;  // Korrekt division      
    string name = "Sofik";     
    bool isStudent = true;  
    char myChar = 'a';   
          
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(name + " Current age: " + age );
        print(char.GetNumericValue(myChar) );

        // Calculate next year
        short resultOneYear = Add(age, yearAdd); 
        Debug.Log("After a year, age will be: " + resultOneYear);

        //identify an amount of years you want to add to age
        short yearsToAdd = 5;

        // Calculate age after additional years
        short resultYearsToAdd = Add(age, yearsToAdd);
        Debug.Log("After " + yearsToAdd + " years, age will be: " + resultYearsToAdd);
    }

    // Method to get age after adding years
    short Add(short currentAge, short yearsToAdd)
    {
        return (short)(currentAge + yearsToAdd);  // Return the updated age (cast til short)
    }

    // Update is called once per frame
    void Update()
    {
        // Update age once every second
        if (age < 100 && Time.frameCount % 60 == 0) // Every 60 frames (around 1 second)
        {
            age += 1; // increase age by 1
            Debug.Log("Current age after one year added: " + age);
        }
        if (age >= 100)
        {
            Debug.Log("Age now 100, " + name + " is dead."); // Tilføjet mellemrum og bedre besked
        }
    }
}
