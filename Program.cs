// Projeto Revisao


//criar 
int[] notas = [4, 5, 7, 8, 3];

int somanotas = 0;

int quantidadesnotas = 5;

int media;
//exibir as notas
for (int i = 0; i < notas.Length; i++)
{
    
   
        Console.WriteLine("informe uma nota:");
        notas [i] = int.Parse(Console.ReadLine());
        somanotas = notas[i] + somanotas;
}
// calcular a media 

    media = somanotas / quantidadesnotas;
// aprovado e reprovado
if (media >= 7)
{
    Console.WriteLine("aluno aprovado");
}
else
{
    Console.WriteLine("Aluno reprovado");
}
       

    

   


