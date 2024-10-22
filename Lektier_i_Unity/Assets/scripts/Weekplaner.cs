using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weekplaner : MonoBehaviour
{ 
    string [] weekDays = new string [] { "monday: tag i skole med p1 gruppe arbejde", "tuesday:codeing class in shcool", "wednesday: hjemme arbejde", "thrusday: sove længe", "friday: fredags bar", "saturday: fødselsdagsfest", "sunday: læse op til mandag"};
    public string today;
    // Start is called before the first frame update 
    void Start()
    {
         
        foreach(string day in weekDays)    
        {
        Debug.Log(day);
        }
        
       switch(today)
    {
     case "monday":
     Debug.Log("tag i skole med p1 gruppe arbejde");
     break; 
     
     case "tuesday":
     Debug.Log("codeing class in shcool");
     break;

     case "wednesday":
     Debug.Log("hjemme arbejde");
     break;

     case "thrusday":
     Debug.Log("sove længe");
     break;

     case "friday":
     Debug.Log("fredags bar");
     break;

     case "saturday":
     Debug.Log("fødselsdagsfest");
     break;

     case "sunday":
     Debug.Log("læse op til mandag");
     break;

     
    }
    }
   

   
}
