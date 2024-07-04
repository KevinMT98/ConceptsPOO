using ConceptsPOO;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //Date? date1 = new Date(2024,07,03);  //fomra de instanciar una clase, dentro del parentesis se ingresas los parametros de la clase


        try
        {
            Console.WriteLine(new Date(2024, 2, 29));
            Console.WriteLine(new Date(2024, 11, 03));
            Console.WriteLine(new Date(2024, 07, 31));   // ctrl + k + s genera un try cahtc
            Console.WriteLine(new Date(2024, 11, 31));
        }
        catch (Exception error)
        {

            Console.WriteLine(error.Message);
        }
    }

}