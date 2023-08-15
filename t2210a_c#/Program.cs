using t2210a_c_.demo3;
using T2210A_C_.Demo2;
using T2210A_C_.Demo3;

public class Program
{
    public static void Main(string[] args)
    {
        Teacher t = new Teacher();
        t.Tels.Add("029309229");
        t.Tels.Add("029384223");
        Console.WriteLine(t.Tels[0]);

        t[0] = "0222311233"; // t.Tels[0] = "0222311233"
        Console.WriteLine(t[0]);
    }
    public static void Main3(string[] args)
    {
        Student s = new Student();
        s.name = "Nguyen Van An";
        s.Eat("aaa");
        s.Eat();

        List<Student> listStudents = new List<Student>();
        listStudents.Add(s);
    }
    public static void Main2(string[] args)
    {
        // See  https://aka.ms/new-console-template for more information
        //Console.WriteLine("Hello, World!");
        int x = 10;
        float y = 3.14159f;
        double z = 3.14159;

        Console.WriteLine("Result:" + (x + y + z));

        var k = 19;
        //k = "hello world";
        k = 22;

        //var pi = 3.14159;
        var input = Console.ReadLine();
        int inputInt = Convert.ToInt32(input);
        if (k > 10)
        {

        }
        else
        {

        }

        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            // arr[i]
        }
        foreach (int ar in arr)
        {
            // ar <=> arr[i]
        }
    }
}