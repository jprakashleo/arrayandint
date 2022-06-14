// See https://aka.ms/new-console-template for more information
public class program
{
    public static void Main()
    {
        try
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int?[] arr1 = new int?[5];
            person p = new person();
            program prg = new program();

            Console.WriteLine($"first program {p.id}");

            float f = 120.1f;
            long l = 100L;
            Console.WriteLine(f + l);
            Console.WriteLine(p.v);
            Console.WriteLine((int)weekdays.tuesday);
            Console.WriteLine(arr1[0]);
            Console.WriteLine(Convert.ToInt32('a') );
            int j;

            prg.call1( out j);
            Console.WriteLine( j);

            prg.call2(ref j);
            Console.WriteLine(j);

            j = prg.call3(j);
            Console.WriteLine(j);

        }

        catch (NullReferenceException ex)
        {
            Console.WriteLine("null ref:" + ex.Message);
        }
        catch (IndexOutOfRangeException r)
        {
            Console.WriteLine("range");
        }
        finally
        {
            Console.WriteLine("finally done");
        }

        
        
    }

    public void call1(out int i)
    {
        i = 2;
    }

    public void call2(ref int i)
    {
        i = 3;
    }

    public int call3( int i)
    {
        i = 4;
        return i;
    }

    void test()
    {
        Console.WriteLine("inside test");
    }
}

public class person
{
    public int id;
    public readonly string v;
    
    public person()
    {
        v = "done";
    }
    public void setv()
    {
        //v = "done";
    }
}
enum weekdays
{
    monday=1,
    tuesday=1,
    wednesday
}