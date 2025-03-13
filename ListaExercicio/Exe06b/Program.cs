namespace Exe06b;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[100];
        Random r = new Random();
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = r.Next(1000);
        }

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }

        Array.Sort(vetor);

        Console.WriteLine("\n");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }
    }
}
