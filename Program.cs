using System;
using System.Collections.Generic;
using lista.Classes;

namespace lista
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Produto> produtos = new List<Produto>();
            string[] lista = new string[5];

            lista[2] = "batata";

            // CRUD = Create, Read, Update, Delete
            // Creat = Criação
            produtos.Add(new Produto(1, "Apple Watch", 3522.56f) );
            produtos.Add(new Produto(2, "Xiaomi Watch", 1522.56f) );
            produtos.Add(new Produto(3, "Zenfone ASUS", 2522.56f) );
            produtos.Add(new Produto(4, "Samsung S9", 2522.56f) );
            produtos.Add(new Produto(5, "Motorola G8", 2522.56f) );

            Produto iphone = new Produto();
            iphone.Codigo = 6;
            iphone.Nome = "Iphone 12";
            iphone.Preco = 7322.56f;

            produtos.Add(iphone);

            // Read = Leitura, Exibição
            foreach (Produto item in produtos)
            {
                Console.WriteLine($"{item.Nome} - R${item.Preco}");
            }
            Console.WriteLine("");

            // Delete = Deletar

            // Deletar todos
            // produtos.RemoveAll( item => item.Nome != "");

            // Deletar todos e permanecer apenas 1
            // produtos.RemoveAll( item => item.Nome != 3 || "Xiaomi Watch");
            produtos.RemoveAt(5);

            produtos.RemoveAll( item => item.Nome == "Apple Watch");

            foreach (Produto item in produtos)
            {
                Console.WriteLine($"{item.Nome} - R${item.Preco}");
            }
            Console.WriteLine("");

            // Update = Atualizar
            Produto atualizacao = produtos.Find(item => item.Codigo == 4);
            atualizacao.Preco = 1300.45f;

            produtos.RemoveAll(item => item.Codigo == 4);

            produtos.Insert(3, atualizacao);

            foreach (Produto item in produtos)
            {
                Console.WriteLine($"{item.Nome} - R${item.Preco}");
            }
            Console.WriteLine("");

            switch (value)
            {
                case value1:
                    break;
                default:
                    break;
            }
            

        }
    }
}
