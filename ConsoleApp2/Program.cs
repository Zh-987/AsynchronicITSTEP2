using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        async static Task Main(string[] args)
        {
            /*
             * void
             * 
             * Account account = new Account();
             account.Added += Print;
             account.Put(400);*/

            /*
             * Task
             * 
             * var task = Print("qwerty");

            await Task.Delay(1000);

            await task;*/

            /* int n1 = await Square(5);
             int n2 = await Square(7);

             Console.WriteLine($"n1 = {n1}, n2 = {n2}");*/

            /*Person person = await GetPerson("Zhassulan");

            Console.WriteLine(person.personname);*/

            /* var square1 = Square(7);
             var square2 = Square(9);
             var square3 = Square(3);

             *//*int[] results =*//* await Task.WhenAll(square1, square2, square3);

            Console.WriteLine($"result1 = {square1.Result}, result2 = {square2.Result} result3 = {square3.Result}");*/

            /*     foreach (int result in results)
                 {
                     Console.WriteLine(result);
                 }*/

            /*
             Console.WriteLine("------");

             int n1 = await square1;
             int n2 = await square2;

             Console.WriteLine($"n1 = {n1}, n2 = {n2}");*/

            /*var result = await Add(3,5);
            Console.WriteLine(result);*/

            /*var getMessage = GetMessage();
            string message = await getMessage.AsTask();
            Console.WriteLine(message);*/


            /* var v1 = Print("ItStep");
             var v2 = Print("System Programming");
             var v3 = Print("Asynchronic");*/

            /* await v1;
             await v2;
             await v3;*/

            /* await Task.WhenAll(v1, v2, v3);

            await Task.WhenAny(v1, v2, v3);*/
            /*var task1 = Print("Hi");
            var task2 = Print("H");
            var task3 = Print("Ho");
            var alltasks = Task.WhenAll(task1, task2, task3);
            try
            {
                *//* await Print("Hello ItStep");*//*
                await alltasks;
                await Task.Delay(1000);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"IsFaulted: {alltasks.IsFaulted}");

                if (alltasks.Exception != null)
                {
                    foreach(var exception in alltasks.Exception.InnerExceptions)
                    {
                        Console.WriteLine($"InnerException: {exception.Message}");
                    }

                }*/

            /*Console.WriteLine($"IsFaulted: {task.IsFaulted}");
            Console.WriteLine($"Status: {task.Status}");
            Console.WriteLine($"IsCanceled: {task.IsCanceled}");*/
            /*  }*/
            /*Print("Hello ItStep");
            Print("Hi");
           await Task.Delay(1000);*/
            /*   await foreach (var number in GetNumbers())
               {
                   Console.WriteLine(number);
               }*/
            Repository repo = new Repository();
            IAsyncEnumerable<string> data = repo.GetData();
            await foreach (var name in data)
            {
                Console.WriteLine(name);

            }

        }

       /* static async IAsyncEnumerable<int> GetNumbers()
        {
            for(int i = 0; i< 10; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }*/

        /*
         *   void 
         * async static void Print(object obj,string message)
        {
            await Task.Delay(100);
            Console.WriteLine(message);
        }*/

        /*
         *  Task
         * async static Task Print (string message)
          {
              await Task.Delay(100);
              Console.WriteLine(message);
          }*/


        /* async static Task<int> Square(int n)
         {
             await Task.Delay(1000);
             return n * n;
         }*/
        /* async static Task<Person> GetPerson(string name)
         {
             await Task.Delay(1000);
             return new Person(name);
         }*/
        /*async static Task<int> Square(int n)
        {
            await Task.Delay(1000);
            var result = n * n;
            Console.WriteLine($"Square of the {n} equal to {result}");
            return result;
        }*/

        /* static ValueTask<int> Add(int a, int b)
         {
             return new ValueTask<int>(a + b);
         }*/

        /* static async ValueTask<string> GetMessage()
         {
             await Task.Delay(1000);
             return "ItStep";
         }*/


      /*  static async Task Print(string message)
        {
            if (message.Length < 3)
            {
                throw new ArgumentException($"Invalid string length : {message.Length}");
            }
            await Task.Delay(new Random().Next(1000, 2000));
            Console.WriteLine(message);
        }*/
        /*  static async void Print(string message)
          {
              try
              {
                  if (message.Length < 3)
                  {
                      throw new ArgumentException($"Invalid string length : {message.Length}");
                  }
                  await Task.Delay(100);
                  Console.WriteLine(message);
              }
              catch (Exception ex)
              {
                  Console.WriteLine(ex.Message);
              }

          }*/
    }

   /*
    * void 
    * 
    * class Account
    {
        int sum = 0;
        public event EventHandler<string>? Added;
        public void Put(int sum)
        {
            this.sum += sum;
            Added.Invoke(this, $"Added: {sum}");
        }
    }*/

    /* class Person
    {
        public string personname;
        public Person(string Name)
        {
            personname = Name;
        }
    }*/
}
