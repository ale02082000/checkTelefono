# Check Telefono

***Ricevuto come parametro un vettore di string, ritornare al chiamante la prima stringa che assomiglia molto ad un numero di telefono cellulare italiano ovvero:***
***- che inizia con +39 (esattamente lungo  13)***
***- oppure con 0039 (esattamente lungo 14)***
***- oppure con un 3 (esattamente lungo 10)***

***Se il numero non viene trovato, ritornare stringa vuota ""***


``` c#
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
``` 

 
***Questo codice C# è una funzione chiamata "Check" che accetta un array di stringhe "numeri" come input e restituisce una stringa,***
***Itera attraverso ogni numero nell'array numeri***
***Per ciascun numero, crea una nuova stringa "cleanedNumero" e un flag "hasInitialPlus".***
***Se il carattere è un numero, lo aggiunge a "cleanedNumero".***
***Se il carattere è un "+" e "cleanedNumero è vuoto", imposta "hasInitialPlus" su "true".***
***Alla fine, restituisce "cleanedNumero se il numero soddisfa alcuni criteri specifici, altrimenti restituisce una stringa vuota".***


``` c#

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
```

***Successivamente se il numero inizia con un "+", lo aggiunge all'inizio del numero.
 poi verifica se il numero rispetta questi canoni:***

***Inizia con "+39" e ha 13 o 14 cifre.***
***Inizia con "0039" e ha 14 o 15 cifre.***
***Inizia con "3" e ha 10 o 11 cifre.***
***Se il numero rispetta uno di questi formati, viene considerato valido e restituito come risultato. In caso contrario, viene restituita una stringa vuota.***

