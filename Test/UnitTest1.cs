using lab1;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;

namespace Test
{ 
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        /* public void TestMethod1()
         {
             List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
                  foreach (int n in sizes)
                  {

                         Problem problem = new Problem(n, 2);
                         Assert.AreEqual(n, problem.list.Count);

                         foreach (var item in problem.list)
                         {
                             Assert.IsNotNull(item.value);

                         }
             }
         }*/

        /* public void TestMethod2() //Sprawdzenie, czy je�li co najmniej jeden przedmiot spe�nia ograniczenia, to zwr�cono co najmniej jeden element.
         {
             Problem problem = new Problem(4, 2);
             problem.list[0].weight = 1;
             lab1.Result result = problem.Solve(10);
             Assert.IsTrue(result.TotalWeight > 0, "Oczekiwano co najmniej jednego elementu w wyniku rozwi�zania.");
         }*/

        /*public void TestMethod3() //Sprawdzenie, czy je�li �aden przedmiot nie spe�nia ogranicze�, to zwr�cono puste rozwi�zanie.
        {
            int capacity = 10;
            Problem problem = new Problem(4, 2);
            
            foreach (var item in problem.list)
            {
                item.weight = capacity + 1; 
            }
            lab1.Result result = problem.Solve(capacity);
            Assert.AreEqual(0, result.TotalValue, "Oczekiwano, �e TotalValue b�dzie r�wne zero.");
            Assert.AreEqual(0, result.TotalWeight, "Oczekiwano, �e TotalWeight b�dzie r�wne zero.");
            Assert.IsFalse(result.index.Any(), "Oczekiwano, �e lista indeks�w b�dzie pusta.");
        }*/  
        /* public void TestMethod4() // Sprawdzenie poprawno�ci wyniku dla konkretnej instancji.
         {


             Problem problem = new Problem(5, 2);
             lab1.Result result = problem.Solve(15);

            
             int expectedTotalValue = 22;
             int expectedTotalWeight = 15;
             int[] expectedIndexes = { 0, 1, 2, 3 };

             
             Assert.AreEqual(expectedTotalValue, result.TotalValue, "Oczekiwano, �e TotalValue b�dzie r�wne " + expectedTotalValue);
             Assert.AreEqual(expectedTotalWeight, result.TotalWeight, "Oczekiwano, �e TotalWeight b�dzie r�wne " + expectedTotalWeight);
             CollectionAssert.AreEqual(expectedIndexes, result.index.ToArray(), "Oczekiwano, �e indeksy b�d� r�wne " + string.Join(", ", expectedIndexes));
         }*/

        /* public void TestMethod5() //czy je�li ustawimy max pojemno�� plecaka na sume wszytkich wag czy totalweight b�dzie taka sama
         {

             Problem problem = new Problem(4, 2);
             int maxCapacity = problem.list.Sum(item => item.weight);
             lab1.Result result = problem.Solve(maxCapacity);
          
             Assert.AreEqual(maxCapacity, result.TotalWeight, "Oczekiwano, �e TotalWeight b�dzie r�wne maksymalnej pojemno�ci plecaka.");

         }*/

        /* public void TestMethod6() //sprawdzenie czasu wykonywania si� zadania dla du�ej ilo�ci przedmiot�w
         {

             Problem problem = new Problem(100, 5); 
             int randomCapacity = new Random().Next(1, 500);

             var stopwatch = new System.Diagnostics.Stopwatch();
             stopwatch.Start();

             lab1.Result result = problem.Solve(randomCapacity);

             stopwatch.Stop();

             Console.WriteLine(problem);
             Console.WriteLine(result.ToString());
             Console.WriteLine($"Czas wykonania: {stopwatch.ElapsedMilliseconds} ms");

             Assert.IsTrue(stopwatch.ElapsedMilliseconds < 1000, "Czas wykonania jest zbyt d�ugi.");
         }*/

        /* public void TestMethod7() //Sprawdzenie, czy kolejno�� przedmiot�w ma wp�ywa na znalezione rozwi�zanie
        {
            Problem problemDecreasing = new Problem(10, 1);
            Problem problemIncreasing = new Problem(10, 1);

            int capacity = new Random().Next(1, 100);

            problemDecreasing.Solve(capacity);   

            problemIncreasing.list.Reverse(); 
            

            Console.WriteLine(problemIncreasing.ToString());
            Console.WriteLine(problemDecreasing.ToString());
           
            Assert.IsTrue(problemDecreasing.Solve(capacity).ToString() == problemIncreasing.Solve(capacity).ToString());
        
           

        }*/

        /*public void TestMethod8() //czy dzia�a dobrze jak lista przyk�ad�w jest pusta
        {
            Problem problem = new Problem(0,1);

            lab1.Result result = problem.Solve(10);

            
            Assert.AreEqual(0, result.TotalValue, "Oczekiwano, �e TotalValue b�dzie r�wne zero.");
            Assert.AreEqual(0, result.TotalWeight, "Oczekiwano, �e TotalWeight b�dzie r�wne zero.");
            Assert.IsFalse(result.index.Any(), "Oczekiwano, �e lista indeks�w b�dzie pusta.");
        }*/

        public void TestMethod9() //du�a pojemno�� plecaka, czy dzia�a
        {
            var stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();


            Problem problem = new Problem(1000, 2);
            lab1.Result result = problem.Solve(10000);

            stopwatch.Stop();

            Console.WriteLine($"Czas wykonania: {stopwatch.ElapsedMilliseconds} ms");

            Assert.IsTrue(stopwatch.ElapsedMilliseconds < 1000, "Czas wykonania jest zbyt d�ugi.");
            Console.WriteLine(result.ToString());
            Assert.IsTrue(result.TotalWeight <= 10000, "Oczekiwano, �e TotalWeight b�dzie mniejsze lub r�wne pojemno�ci plecaka.");
        }

    }

}