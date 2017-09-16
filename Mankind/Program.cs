
using System;

class Program
{
    static void Main(string[] args)
    {
        string[] studentInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] workerInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        try
        {
            Student student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);
            Worker worker = new Worker(workerInfo[0], workerInfo[1], decimal.Parse(workerInfo[2]), int.Parse(workerInfo[3]));

            Console.WriteLine(student);
            Console.WriteLine(worker);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}

