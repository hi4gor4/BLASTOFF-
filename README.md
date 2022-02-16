# Teste de logica Toodoo

### Dadas as idades I, J, K, X, Y. Faça um algoritmo para calcular a média das idades
```
static float average(int i, int j, int k, int x, int y)
{
    return (float)(i + j + k + x + y )/ 5;
}
static void Main(string[] args)
{
    int i = 2;
    int j = 2;
    int k = 2;
    int x = 2;
    int y = 10;
    Console.WriteLine(average(i, j, k, x, y));
}

```
Saída:`3.6`


### Dada a distância A e o combustível gasto B, faça um algoritmo para calcular o consumo médio.
```

static float averageConsumption(float distance, float spentFuel)
{
    return distance/spentFuel;

}

static void Main(string[] args)
{
    float distance = 10F;
    float spentFuel = 8F;
    Console.WriteLine(averageConsumption(distance, spentFuel));
}


```
Saída:`1.25`


### Dados três números (a, b, c), faça um algoritmo para mostrar o menor número.

```
 static int whoIsTheSmallest(int[] input )
        {
            int smaller = input[0];
            foreach ( var item in input )
            {
                if ( item < smaller)
                {
                    smaller = item;
                 }
            } 
            return smaller;
        }
        static void Main(string[] args)
        {
            int a = 20;
            int b = 2;
            int c = 1;
            Console.WriteLine(whoIsTheSmallest(new int[] { b, a, c}));
        }

```
Saída:`1`

### Faça um algoritmo que converta a temperatura de C para F. Utilize a fórmula 5(F - 32)/9
```
static float celciusToFarenheit(float tempC )
{
    return (1.8F * tempC) + 32;
}
static void Main(string[] args)
{
    float tempC = 50F;
    Console.WriteLine(celciusToFarenheit(tempC));
}
```

Saída:`122`

### Faça um algoritmo para apresentar se dois números são múltiplos.

```
static bool isAMultiple(int a, int b )
{
    if (a % b == 0){
        return true;
    }
    return false;
}
static void Main(string[] args)
{
    int a = 1;
    int b = 2;
    Console.WriteLine(isAMultiple(a,b));
}
```

Saída:`False`

### - Uma partida de futebol iniciou na hora A e terminou na hora B. Faça um algoritmo que calcule o tempo que durou a partida.
Observação, como o problema só leva em consideração as horas, não estou levando em consideração, a situação na qual o jogo começa antes das 00:00 e termina após. 

```
static string matchDuration(string a, string b )
{
    TimeSpan start = TimeSpan.Parse( a );
    TimeSpan end = TimeSpan.Parse( b );
    return end.Subtract( start ).ToString();
}
static void Main(string[] args)
{
    string a = "8:12:14";
    string b = "9:18:14";
    Console.WriteLine(matchDuration(a,b));
}
}

```
Saída:`01:06:00`

### Dada uma lista de números A[1,2,3,...], faça um algoritmo que retorne uma lista somente com os números pares.

```
static int[] evenNumbers(int[] input )
{
    List<int> even = new List<int>();
    foreach (int item in input)
    {
        if (item % 2 == 0)
        {
            even.Add(item);
        }
    }
    
    return even.ToArray();
}
static void Main(string[] args)
{
    int[] a = new int[5] { 1, 2, 3, 4, 5 };
    int[] result = evenNumbers(a);
    foreach (int item in result)
    {
        Console.WriteLine(item);
    }
}
```
Saída:
```
2
4
```
### Faça um algoritmo que receba um número e retorne se o número é primo ou não
```
static bool isPrimeNumber(int number)
{
    if (number >= 2)
    {
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return true;
            }
        }
    }

    return false;
}
static void Main(string[] args)
{
    int a = 20;
    for (int i = 1; i < a; i++)
    {
        if (isPrimeNumber(i))
        {
            Console.WriteLine("{0}  is not a Prime number ", i);
        }
        else
        {
            Console.WriteLine("{0}  is  a Prime number ", i);
        }
```

Saída:
```
1  is a Prime number
2  is a Prime number
3  is a Prime number
4  is not a Prime number
5  is a Prime number
6  is not a Prime number
7  is a Prime number
8  is not a Prime number
9  is not a Prime number
10  is not a Prime number
11  is a Prime number
12  is not a Prime number
13  is a Prime number
14  is not a Prime number
15  is not a Prime number
16  is not a Prime number
17  is a Prime number
18  is not a Prime number
19  is a Prime number
```

### Faça um algoritmo que receba um número e retorne a tabuada desse número.

```
static string[] mutiplicationTable(int number )
{
    string[] table = new string[10];
    for (int i = 1; i <= 9; i++) 
    {
        table[i] =String.Format("{0} x {1} = {2}",number, i, i*number); 

    }
    
    return table;   
}
static void Main(string[] args)
{
    string[] table = mutiplicationTable(8);
    for (int i = 1; i <= 9; i++)
    {
        Console.WriteLine(table[i]);
    }
}

```
Saída:
```
8 x 1 = 8
8 x 2 = 16
8 x 3 = 24
8 x 4 = 32
8 x 5 = 40
8 x 6 = 48
8 x 7 = 56
8 x 8 = 64
8 x 9 = 72
```

### Faça um algoritmo que receba um número e retorne o Fatorial desse número.

```
static int factorial(int number )
{
    int result = 1;
    for (int i = number; i>1 ; i--) 
    {
        result= result*i; 

    }
    
    return result;   
}
static void Main(string[] args)
{
    Console.WriteLine("5! = {0}",factorial(5));
}
```
Saída:`5! = 120`

### Dada duas lista de números A[1,2,3,4] e B[1,2,5,8], faça um algoritmo que retorne a intersecção das listas
```
static int[] myItersect(int[] inputA, int[] inputB)
{
    List<int> contains = new List<int>();
    foreach (int itemA in inputA)
    {
        foreach (int itemB in inputB)
        {
            if(itemA == itemB)
            {
                contains.Add(itemA);
            }
        }
    }

    return contains.ToArray();
}
static void Main(string[] args)
{
    int[] a = new int[4] { 1, 2, 3, 4 };
    int[] b = new int[4] { 1, 2, 5, 8 };
    int[] result = myItersect(a, b);
    foreach (int item in result)
    {
        Console.WriteLine(item);
    }
}
```
Saída:
```
1
2
```

### Dada duas lista de números A[1,2,3,4] e B[1,2,5,8], faça um algoritmo que retorne a concatenação das listas.
```
static int[] myConcat(int[] inputA, int[] inputB)
{
    List<int> contains = new List<int>();
    foreach (int item in inputA)
    {
        contains.Add(item);
    }
    foreach (int item in inputB)
    {
        contains.Add(item);
    }
    return contains.ToArray();
}
static void Main(string[] args)
{
    int[] a = new int[4] { 1, 2, 3, 4 };
    int[] b = new int[4] { 1, 2, 5, 8 };
    int[] result = myConcat(a, b);
    foreach (int item in result)
    {
        Console.Write(" {0}",item);
    }
}

```

Saída:
```
 1 2 3 4 1 2 5 8
```

### Faça um algoritmo que receba uma matriz[i,z] como parâmetro e imprima todos os valores dessa matriz.
```
static void printMatrix(int[,] input)
{
    int rowLength = input.GetLength(0);
    int colLength = input.GetLength(1);
    for (int i = 0; i < rowLength; i++)
    {
        for (int z = 0; z < colLength; z++)
        {
            Console.Write(string.Format("{0} ", input[i, z]));
        }
        Console.WriteLine("");
    }
    Console.ReadLine();
}
static void Main(string[] args)
{
    int[,] arr = new int[5, 4] { { 1, 2, 3, 4 }, { 1, 1, 1, 1 }, { 2, 2, 2, 2 }, { 3, 3, 3, 3 }, { 4, 4, 4, 4 } };
    printMatrix(arr);
}
```

Saída:
```
1 2 3 4
1 1 1 1
2 2 2 2
3 3 3 3
4 4 4 4

```

### Faça um algoritmo que recebe uma palavra e retorne se a palavra é palíndromo. (Palavra que se pode ler, indiferentemente, da esquerda para direita ou vice-versa. Ex: osso,  Ana e etc).

```
static bool palindrome(string palavra)
{
    string first = palavra.Substring(0, palavra.Length / 2);
    char[] rever = palavra.ToCharArray();

    Array.Reverse(rever);

    string temp = new string(rever);
    string second = temp.Substring(0, temp.Length / 2);

    return first.Equals(second);
}
static void Main(string[] args)
{
    Console.WriteLine(palindrome("osso"));
    Console.WriteLine(palindrome("Urso"));
}
```

Saída:
```
True
False

```

