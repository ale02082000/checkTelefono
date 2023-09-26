using System;
using System.Collections.Generic;

public class Telefono
{
    public static string Check(string[] numeri)
    {

        
        foreach (string numero in numeri)


        {
            string cleanedNumero = "";
            bool hasInitialPlus = false; 

            
            foreach (char c in numero)
            
            
            {
                if (char.IsDigit(c))
                {
                    cleanedNumero += c;
                }
                else if (c == '+' && cleanedNumero.Length == 0)
                {
                    hasInitialPlus = true; 
             
                }
            
            
            }

          
          
          
            if (hasInitialPlus) 
            {
                cleanedNumero = "+" + cleanedNumero;
            }




            if ((cleanedNumero.StartsWith("+39") && (cleanedNumero.Length == 13 || cleanedNumero.Length == 14)) ||
                (cleanedNumero.StartsWith("0039") && (cleanedNumero.Length == 14 || cleanedNumero.Length == 15)) ||
                (cleanedNumero.StartsWith("3") && (cleanedNumero.Length == 10 || cleanedNumero.Length == 11)))
           
           
            {
                return cleanedNumero;
            }
        }

        return "";
    }
}
