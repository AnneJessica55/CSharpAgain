namespace M06A06
{
    internal class Calculadora
    {//com o modificador de parâmetro params, dá pra listar os elementos de soma do vetor, sem que seja necessário o new int [] na parte do programa.
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for ( int i =0; i< numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
