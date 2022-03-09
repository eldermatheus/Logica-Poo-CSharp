
Triangulo triangulo = new Triangulo();
triangulo.Base = 4;
triangulo.Altura = 2;
Console.WriteLine(triangulo.CalcularArea());


public class Triangulo {

    public double Base;
    public double Altura;

    public double CalcularArea()
    {
        return (Base * Altura) / 2;
    }
}

public class Quadrado
{
    public double lado;

    public double CalcularArea()
    {
        return lado * lado;
    }
}

public class Circunferencia
{
    public double raio;

    public double CalcularArea()
    {
        return Math.PI * (raio * raio);
    }
}

public class Trapezio
{
    public double baseMaior;
    public double baseMenor;
    public double altura;

    public double CalcularArea()
    {
        return ((baseMaior + baseMenor)/2) * altura;
    }
}