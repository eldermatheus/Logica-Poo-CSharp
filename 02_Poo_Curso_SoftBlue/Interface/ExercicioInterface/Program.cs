using ExercicioInterface;

Porta porta1 = new Porta(2.10, 0.80);

Porta porta2 = (Porta)porta1.Clone();


Console.WriteLine(porta1);
Console.WriteLine(porta2);