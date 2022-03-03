using static System.Console;

public class Program
{
  static void demo1()
  {
    int a = 2;
    Adicionar20(a);
    WriteLine($"O valor da variável a é {a}");
  }

  static void demo2()
  {
    Pessoa p1 = new Pessoa();
    p1.Nome = "Ricardinho";
    p1.Idade = 30;
    p1.Documento = "1234";

    TrocarNome(p1, "Seninha");

    WriteLine($"O novo nome é:{p1.Nome}");


  }

  static void demo3()
  {
    string nome = "Ricardo";
    
    TrocarNome(nome, "José");

    WriteLine($"O novo nome é {nome}");
  }

  static void demo4()
  {
    int[] pares = new int[]{0,2,4,6,8};
    MudarParaImpar(pares);
    WriteLine($"Os impares {string.Join(",", pares)}");
  }

  static void demo5()
  {
    int[] numeros = new int[] {0, 2, 4, 6, 8};
    WriteLine("Digite o número a ser procurado.");
    var numero = int.Parse(ReadLine());
    var idxEncontrado = EncontrarNumero(numeros, numero);
    if(idxEncontrado > 0)
    {
      WriteLine($"O número digitado{numero} está na posição: {idxEncontrado}");
    }
    else
    {
      WriteLine("O número não foi encontrado");
    }
  }

  static int Adicionar20(int x)
  {
     return x + 20;
  }

  static void TrocarNome(Pessoa p1, string nomeNovo)
  {
    p1.Nome = nomeNovo;
  }

  static string TrocarNome(string nome, string nomeNovo)
  {
    return nome = nomeNovo;
  }

  static void MudarParaImpar(int[] pares)
  {
    for(int i = 0; i < pares.Length; i++)
    {
      pares[i] = pares[i] + 1; 
    }
  }

  static int EncontrarNumero(int[] numeros, int numero)
  {
    for(int i = 0; i < numeros.Length; i++)
      if(numeros[i] == numero)
      {
          return 1;      
      }
      return -1;
  }

  static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa)
  {
    foreach (var item in pessoas)
    {
      if(item == pessoa)
      {
        return true;
      }
    }

    return false;

  }
  
  public static void Main()
  {
      List<Pessoa> pessoas = new List<Pessoa>()
      {
          new Pessoa(){Nome = "Ricardinho"},
          new Pessoa(){Nome = "Silvaninha"},
          new Pessoa(){Nome = "Davizinho"},
          new Pessoa(){Nome = "Kaletinha"},
          new Pessoa(){Nome = "Zezinho"},
          new Pessoa(){Nome = "Francisquinho"}
      };

      WriteLine($"Digite a pessoa que gostaria de localizar.");
      var nome = ReadLine();
      var pessoa = new Pessoa(){Nome = nome};
      var encontrado = EncontrarPessoa(pessoas, pessoa);
      if(encontrado)
      {
        WriteLine("Pessoa localizada!");
      }
      else
      {
        WriteLine("Pessoa não localizada.");
      }
  }
}