namespace Aula24Fibonacci
{
    public class Recursividade
    {
        // Exemplo para gerar uma sequencia Fibonacci começando de um valor, intervalo específico equantidade de repetições
        public void GerarSequenciaFibonacci(int numero1, int numero2, int vezes){
            // condição obrigatória para quebrar a recursividade do método
            if(vezes >= 0){
                System.Console.WriteLine(numero1);
                GerarSequenciaFibonacci(numero2, numero1 + numero2, vezes - 1);
            }

        }
            //exemplo fatorial
            //5! = 5* 4* 3* 2* 1*
            public int GerarFatorial(int numero){
                //Condição para querbrar a recursividade do método
                if(numero == 1){
                    return 1;
                }else{
                    return numero * GerarFatorial(numero -1);
                }
            }
            //exemplo tribonacci
            public void GerarTribonacci(int numero1, int numero2, int numero3, int vezes){
                //Condição para quebrar a recursividade
                if(vezes >= 0 ){
                    System.Console.WriteLine(numero1);
                    System.Console.WriteLine(numero2);
                    System.Console.WriteLine(numero3);
                    GerarTribonacci(numero3, numero1 + numero2, numero1 + numero3, vezes -3);
                }
            }
    }
}