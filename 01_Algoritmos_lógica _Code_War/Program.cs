/* ================= Array =================
int[] n = { 5,3,4 };

Console.WriteLine(SquareSum(n));

static int SquareSum(int[] n)
{
    int result = 0;
 
    foreach (int numero in n) {
        result += (numero * numero);   
    }
    
    return result;

}
*/

/* ================= Procurar na string =================
Console.WriteLine(Solution("samurai", "ai"));

static bool Solution(string str, string ending)
{
    if (str.EndsWith(ending))
    {
        return true;

    } else return false;
}
ou
static bool Solution(string str, string ending)
{ return str.EndsWith(ending); }
*/

/* ================= Convert string to int =================
string str = "123";
int numero = Int32.Parse(str);
Console.WriteLine(numero);
*/

/* ================= Média valores array =================
double[] array = new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 };

Console.WriteLine(FindAverage(array));

static double FindAverage(double[] array)
{
    double soma = 0;

    if (array.Length == 0)
        return 0;
    else 
    {
        for (int i = 0; i < array.Length; i++)
        {
            soma += array[i];
        }        
        return soma / array.Length;
    }
}
*/

/* ================= Cálculo da progressão de anos =================
Console.WriteLine(NbYear(1500, 5, 100, 5000));
Console.WriteLine(NbYear(1500000, 2.5, 10000, 2000000));
Console.WriteLine(NbYear(1500000, 0.25, 1000, 2000000));

static int NbYear(int populacao, double percentCrescimento, int estrangeirosAnuaisFixo, int totalEsperado)
{    
    int year;

    for (year = 0; populacao < totalEsperado; year++)
    {
        populacao += (int)(populacao * percentCrescimento / 100) + estrangeirosAnuaisFixo;        
    }    
    return year;
}
*/

/*================= Verficao soma par ou ímpa da matriz =================
Console.WriteLine(OddOrEven(new int[] {}));

static string OddOrEven(int[] array) {

    if (array.Sum() == 0)
    {
        return "even";
    }
    else if (Math.Abs((array.Sum())) % 2 == 0) {
        return "odd";   
    }
    else return "odd";

    /*int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        result += array[i];
    }

    switch (result % 2)
    {
        case 0: return "even";
        case 1: return "odd";
        case -1: return "odd";
    }
    return "";
}*/

/*================= Verficao maior e menor da matriz =================
Console.WriteLine(HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));

static string HighAndLow(string numbers) {

    //int[] numeros = new int[] { };
    int numeros; 

    for (int i = 0; i < numbers.Length; i++) {
       numeros = Convert.ToInt32(numbers);
    }

 
    return "throw towel";

}*/

/*================= Cadeia de DNA =================
using System.Text;

Console.WriteLine(MakeComplement("AATTCCGG"));


static string MakeComplement(string dna) {

    StringBuilder newSeq = new StringBuilder(dna);

    for (int i = 0; i < newSeq.Length; i++) {
        if (newSeq[i] == 'A') {newSeq[i] = 'T'; }
        else if (newSeq[i] == 'T') {newSeq[i] = 'A';}
        else if (newSeq[i] == 'C') {newSeq[i] = 'G';}
        else if (newSeq[i] == 'G') {newSeq[i] = 'C';}
    }
    return newSeq.ToString();
}*/

