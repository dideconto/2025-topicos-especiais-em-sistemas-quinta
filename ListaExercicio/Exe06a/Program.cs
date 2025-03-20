//PASSOS PARA RESOLVER O EXERCÍCIO
//1 - Criar um vetor de 1000 posições
//2 - Preencher o vetor com valores aleatórios
//3 - Imprimir o vetor na tela
//4 - Ordenar o vetor com o Bubble Sort

//Criar um vetor de valores inteiros
int[] vetor = new int[100];


Random r = new Random();

//Preencher o vetor com valores aleatórios
for (int i = 0; i < vetor.Length; i++)
{
    //Gerar um valor randômico
    vetor[i] = r.Next(1000);
}

//Imprimir o vetor com valores aletatórios
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}

//Ordenar o vetor com o Bubble Sort
bool troca = false;
do
{
    troca = false;
    for (int i = 0; i < vetor.Length - 1; i++)
    {
        int atual = i;
        int prox = atual + 1;
        //Trocar valores
        if (vetor[atual] > vetor[prox])
        {
            int aux = vetor[atual];
            vetor[atual] = vetor[prox];
            vetor[prox] = aux;
            troca = true;
        }
    }
}while(troca == true);

Console.WriteLine("\n");
//Imprimir o vetor com valores ordenados
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}