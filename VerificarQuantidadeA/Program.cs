using System;

public class VerificarA
{
    public static void Main(string[] args)
    {
       
        Console.WriteLine("Informe um texto para verificar a quantidade de vogal A:");
        string texto = Console.ReadLine();

       
        int contadorA = 0;

        // Como eu nao sei o tamanho do texto vou usar um foreach para pecorrer
        foreach (char letra in texto)
        {
            
            if (letra == 'A' || letra == 'a')
            {
                contadorA++;
            }
        }

        
            Console.WriteLine($"A vogal 'a' aparece {contadorA} vezes.");
      
            
        
    }
}