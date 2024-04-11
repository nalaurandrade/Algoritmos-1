using System;

class Program {
  public static void Main (string[] args) {
    bool cpfValido = true; 

    Console.WriteLine("Informe o CPF completo, sem pontos ou tracos:");
    string cpf = Console.ReadLine();
    string valida = cpf;
    
    int[] mUm = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
    int[] mDois = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
    
    string tCpf = cpf.Substring(0,9);
    int soma = 0;
    int soma2 = 0;
    int primeiroDigito = 0;
    int segundoDigito = 0;

    for (int j = 0; j < 9; j++){
      soma += int.Parse(tCpf[j].ToString()) * mUm[j];
    }
    
    primeiroDigito = soma % 11;
    if (primeiroDigito < 2){
      primeiroDigito = 0;
    } else{
      primeiroDigito = 11 - primeiroDigito;
    }
    tCpf = tCpf + primeiroDigito;
    for (int j = 0; j < 10; j++){
      soma2 += int.Parse(tCpf[j].ToString()) * mDois[j];
    }
    
    segundoDigito = soma2 % 11;
    if (segundoDigito < 2){
      segundoDigito = 0;
    } else{
      segundoDigito = 11 - segundoDigito;
    }
    tCpf = tCpf + segundoDigito;
    if(tCpf.Length == 11 || cpf.Length == 11){
      if (tCpf == cpf){
        cpfValido = true;
      } else {
        cpfValido = false;
      }
    }
    
    if( cpfValido == true ){
      Console.WriteLine("CPF Válido!");
    }else{
      Console.WriteLine("CPF Inválido!");      
    }
  }
}