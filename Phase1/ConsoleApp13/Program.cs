using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp13
{
    public class Program 
    {
        static void Print1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(1);
            }
        }
        static void CountTo(int maxNum)
        {
            for (int i = 0; i <= maxNum; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            /*//simple Thread 
            Thread t = new Thread(Print1);
            t.Start();

            for(int i = 0;i < 1000;i++) {
                Console.Write(0);
            }*/

            //-----sleep-----

           /* int num = 1;
            for (int i = 0;i < 10; i++) { 
                Console.WriteLine(num);
                Thread.Sleep(1000);
                num++;
            }
            Console.WriteLine("Thread is Ends");*/

            /*//----lock----
            BankAcct acct = new BankAcct(10);
            Thread[] threads = new Thread[15];

            // CurrentThread gets you the current
            // executing thread
            Thread.CurrentThread.Name = "main";

            // Create 15 threads that will call for 
            // IssueWithdraw to execute
            for (int i = 0; i < 15; i++)
            {
               
                Thread t = new Thread(new
                    ThreadStart(acct.IssueWithdraw));
                t.Name = i.ToString();
                threads[i] = t;
            }

            // Have threads try to execute
            for (int i = 0; i < 15; i++)
            {
                // Check if thread has started
                Console.WriteLine("Thread {0} Alive : {1}",
                    threads[i].Name, threads[i].IsAlive);

                // Start thread
                threads[i].Start();

                // Check if thread has started
                Console.WriteLine("Thread {0} Alive : {1}",
                    threads[i].Name, threads[i].IsAlive);
            }

           
            Console.WriteLine("Current Priority : {0}",
                Thread.CurrentThread.Priority);

            Console.WriteLine("Thread {0} Ending",
                Thread.CurrentThread.Name);
*/
            // ----- Passing Data to Threads -----
            // You can pass arguments to a thread using a lambda expression

          
                Thread t = new Thread(() => CountTo(10));
                t.Start();

                // You can use multiline lambdas
                new Thread(() =>
                {
                    CountTo(5);
                    CountTo(6);
                }).Start();

               
            

            


        }
    
            
    }

}

