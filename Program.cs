internal class Program
{
    private static void Main(string[] args)
    {
        int num=1,suma=0;
       while(num!=0){
        Console.WriteLine("ingrese numero");
        num=int.Parse(Console.ReadLine());
        suma=suma+(1/num);
       }

       Console.WriteLine("la media aritmetica es : " +suma);
    }
}
