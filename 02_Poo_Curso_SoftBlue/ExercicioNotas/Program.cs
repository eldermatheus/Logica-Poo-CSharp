// Criando turma
Turma turma = new Turma();

// Criando alunos
Aluno aluno1 = new Aluno();
Aluno aluno2 = new Aluno();
Aluno aluno3 = new Aluno();

turma.aluno1 = aluno1;
turma.aluno2 = aluno2;
turma.aluno3 = aluno3;


// Primeiro Aluno
// // Prova 1
Prova aluno1prova1 = new Prova();
aluno1prova1.notaParte1 = 4.0;
aluno1prova1.notaParte2 = 2.5;
aluno1.prova1 = aluno1prova1;

// // Prova 2
Prova aluno1prova2 = new Prova();
aluno1prova2.notaParte1 = 1.0;
aluno1prova2.notaParte2 = 7.0;
aluno1.prova2 = aluno1prova2;

// Segundo Aluno
// // Prova 1
Prova aluno2prova1 = new Prova();
aluno2prova1.notaParte1 = 6.5;
aluno2prova1.notaParte2 = 3.5;
aluno2.prova1 = aluno2prova1;
// // Prova 2
Prova aluno2prova2 = new Prova();
aluno2prova2.notaParte1 = 0.0;
aluno2prova2.notaParte2 = 3.0;
aluno2.prova2 = aluno2prova2;

// Terceiro Aluno
// // Prova 1
Prova aluno3prova1 = new Prova();
aluno3prova1.notaParte1 = 5.0;
aluno3prova1.notaParte2 = 4.0;
aluno3.prova1 = aluno3prova1;
// // Prova 2
Prova aluno3prova2 = new Prova();
aluno3prova2.notaParte1 = 6.0;
aluno3prova2.notaParte2 = 1.5;
aluno3.prova2 = aluno3prova2;


Console.WriteLine("A média do aluno1 foi: " + turma.aluno1.CalcularMedia());
Console.WriteLine("A média do aluno2 foi: " + turma.aluno2.CalcularMedia());
Console.WriteLine("A média do aluno3 foi: " + turma.aluno3.CalcularMedia());
Console.WriteLine("A média da turma foi: " + turma.calcularMedia());

public class Prova
{
    public double notaParte1;
    public double notaParte2;
    public double CalcularNotaTotal()
    {
        return notaParte1 + notaParte2;
    }
}
public class Aluno
{
    public Prova prova1;
    public Prova prova2;

    public double CalcularMedia()
    {
        double somaNotas = prova1.CalcularNotaTotal() + prova2.CalcularNotaTotal();
        return somaNotas / 2;
    }
}
public class Turma
{
    public Aluno aluno1;
    public Aluno aluno2;
    public Aluno aluno3;
    public double calcularMedia()
    {
        double notasTurma = aluno1.CalcularMedia() + aluno2.CalcularMedia() + aluno3.CalcularMedia();
        return notasTurma / 3;
    }
}