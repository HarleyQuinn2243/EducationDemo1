using System;
using EducationHierarchy;

class Program
{
    static void Main()
    {
       
        Test[] tests = new Test[6];

       
        tests[0] = new Test();
        tests[0].RandomInit();

        tests[1] = new Exam();
        tests[1].RandomInit();

        tests[2] = new FinalExam();
        tests[2].RandomInit();

        tests[3] = new Trial();
        tests[3].RandomInit();

        tests[4] = new Exam("Ручной ввод", 90, 75, "Смирнов А.А.", true);
        tests[5] = new FinalExam("Физика", 180, 70, "Петрова М.И.", false, "Государственный аттестат", true);

     
        Console.WriteLine("=== Просмотр массива объектов ===");
        foreach (var test in tests)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Тип объекта: {test.GetType().Name}");
            test.Show(); 
            NonVirtualShow(test); 
        }
    }

 
    static void NonVirtualShow(Test test)
    {
        Console.WriteLine("\n[Невиртуальный метод]");
        Console.WriteLine($"Тест: {test.Name}");
        Console.WriteLine($"Длительность: {test.Duration} мин");
        Console.WriteLine($"Проходной балл: {test.PassingScore}%");
    }
}
