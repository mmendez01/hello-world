using System;
//Compilar desde consola varias clases >>> csc -out: nombre del ejecutable y las clases que intervienen

public class HolaMundo
{
    public static void Main (String[] arg)
    {   
        int opcion;
        do
        {
           #region "MENU"
           System.Console.WriteLine("Ingrese la opcion de bucles o condicionales a utilizar: ");   
           System.Console.WriteLine("1.Usar el If else");
           System.Console.WriteLine("2.Utilizar el For");
           System.Console.WriteLine("3.Utilizar el While");
           System.Console.WriteLine("4.Utilizar el Operadores ternarios");
           System.Console.WriteLine("5.Utilizar el For Each");
           #endregion         

            opcion = Int32.Parse(Console.ReadLine());
        

           switch (opcion)
            {
               
                #region "CASO 1"
                case 1:

                    Console.WriteLine("Que tipo de valor desea usar para su validacion: \n 1.Strin  \n 2.Int " );
                    string eleccion = Console.ReadLine();
                    if (eleccion == "1")
                    {
                        Console.WriteLine("Ingresa una cadena de texto: \n >");
                        string cadena = Console.ReadLine();

                        Console.WriteLine("Ingresa  la cadena de texto a comparar");
                        string cadena2 = Console.ReadLine();

                        if (cadena == cadena2)
                        {
                            Console.WriteLine("Las cadenas insertadas son iguales la uno contiene {0} caracteres y " +
                                "la cadena  2 contiene {1} caracteres \n",cadena.Length,cadena2 .Length);
                        }
                        else
                        {

                            Console.WriteLine("Las cadenas insertadas son diferentes, la cadena uno contiene {0} caracteres y " +
                                "la cadena 2 contiene {1} caracteres \n", cadena.Length, cadena2.Length);
                        }


                    }
                    else
                    {
                        Console.WriteLine("Ingresa los digitos a comparar: \n >");
                        int digito = int.Parse(Console.ReadLine());
                     
                        Console.WriteLine("Ingresa  los digitos a comparar");
                        int digito2 = int.Parse(Console.ReadLine());

                        if (digito == digito2)
                        {
                            Console.WriteLine("Los digitos insertados son iguales");

                        }
                        else
                        {

                            Console.WriteLine("Las cadenas insertadas son diferentes");
                        }

                    }

                    break;

                #endregion

                #region "CASO 2"
                case 2:

                    Console.WriteLine("Bienvenido al ciclo For te invido a contar palabras:");

                    Console.WriteLine("Ingresa la palabra que quieres contar");

                    string texto = Console.ReadLine();

                    char[] letras = texto.ToCharArray();

                    Console.WriteLine("Comenzamos...");

                    int almacen=0;

                    for (int i = 0; i <letras.Length;++i)
                    {
                        almacen++;
                        
                        Console.WriteLine("El caracter no.{0} de su cadena es {1}",almacen,letras[i]);
                        if (letras[i] == ' ')
                        {

                            Console.Write("un espacio en blanco\n ");
                        }

                    }

                    Console.WriteLine("Total de caracteres: {0} ",almacen);
                     
                    break;
                #endregion //Terminar logica de espacio en blanco

                #region "CASO 3"
                case 3:

                    break;
                #endregion

                #region "CASO 4"
                case 4:

                    break;
                #endregion

                #region "CASO 5"
                case 5:

                    break;
                #endregion
                    
                #region "CASO 6"
                case 6:

                    break;
                #endregion
                    
                #region "CASO 7"
                case 7: 

                    break;
                #endregion
            }
            System.Console.WriteLine("Marque la opcion deseada: 1 para continuar en el programa - 2 para salir?");
         opcion=Int32.Parse(Console.ReadLine());
        }
        while (opcion==1);
    
    }
}
