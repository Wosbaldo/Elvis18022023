using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contador.Negocio
{
    public class ClsContador
    {

        public static void Main()
    {
        int j;
        char i;
        string frase;
        int vocales = 0;
        int consonates = 0;
        int espacio = 0;

     

         Console.WriteLine("Ingrese una oración");

        for (j = 0; j < frase.Length; j++)
         {
            i = frase [j];
            int c = char .ToLower(i);
            if ((c == 'a') | (c == 'e') | (c == 'i') | (c == 'o') | (c == 'u'))
            {
                vocales++;
            }
            else if ((c == 'b') | (c == 'c') | (c == 'd') | (c == 'f') | (c == 'g') | 
            (c == 'h') | (c == 'j') | (c == 'k') | (c == 'l') | (c == 'm') | 
            (c == 'n') | (c == 'p') | (c == 'q') | (c == 'r') | (c == 's') | 
            (c == 't') | (c == 'v') | (c == 'w') | (c == 'x') | (c == 'y') | (c == 'z'))
            {
                consonates++;
            }
            else if ((c == ' '))
            {
                espacio++;
            }
            

         } 
     
     
    }
    }
}