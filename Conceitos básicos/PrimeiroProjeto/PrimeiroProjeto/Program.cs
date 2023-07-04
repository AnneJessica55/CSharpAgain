using System;
namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
           //Todos abaixo são para números inteiros
           /*
           -sbyte: Suporta de -128 até 127
           -short
           -int
           -long
           -byte
           -ushort
           -unit
           -ulog
           */
           //Decimais
           /*
            -float: numero decimal de até 4 bytes
            -double: número decimal de até 8 bytes
            -decimal: aceita até 12 bytes
            */
           //Poucos bytes
           /*
            -char: para qualquer tipo de caractere de até 2bytes
            -bool: variável booleana, que só aceita valores "true" ou "false"
            */
            int variavel2 = 2023 - 1991;
            var nome = "Anne J. R. Monteiro";
            char sexo = 'F';
            var variavel = $"Olá. Meu nome é {nome},eu tenho {variavel2} anos de idade e sou do sexo {sexo}.";
            Console.WriteLine(variavel);
            /*
             Para interpolação, a forma correta de se escrever é:
            tipo Nome = $" odfhodsihfodi {var1} saofbds {var2}.";
             */
        }
    }
}