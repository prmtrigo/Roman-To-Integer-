using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public virtual int value (char r)
        {
            if(r=='I'){
                return 1;
            }
            if(r=='V'){
                return 5;
            }
            if(r=='X'){
                return 10;
            }
            if(r=='L'){
                return 50;
            }
            if(r=='C'){
                return 100;
            }
            if(r=='D'){
                return 500;
            }
            if(r=='M'){
                return 1000;
            }
            return -1;
        }

        public virtual int romanoParaDecimal(string numero)
        {
            //aqui, começamos o resultado
            int resultado = 0;

            for(int i = 0; i< numero.Length; i++){
                //inicializar o valor do caractere
                int string1 = value(numero[i]);

                if(i + 1 < numero.Length){
                    //inicializar o valor do caractere seguinte
                    int string2 = value(numero[i+1]);

                    //então, vamos comparar os valores
                    if(string1 >= string2){
                        //se o valor for igual ou maior que o próximo símbolo, haverá uma soma (tipo III)
                        resultado = resultado + string1;
                    }
                    else{
                        //se isso não for verdade, diminuir o valor do símbolo
                        resultado = resultado + string2 - string1;
                        i++;
                    }
                }
                else{
                    resultado = resultado + string1;
                    i++;
                }
            }
            return resultado;
        }
        public static void Main(string[] args)
        {
            Program converter = new Program();

            string numero = "MCMIV";

            Console.WriteLine("Esse número, convertido para Decimal Inteiro é: " + converter.romanoParaDecimal(numero));

        }
    }
}