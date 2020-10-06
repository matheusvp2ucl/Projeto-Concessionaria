using System;

class Veiculo{

  private string marca;
  private int ano;
  private double valor;
  private int km;

  public void Relatorio(){
    Console.WriteLine("Marca : {0}", marca);
    Console.WriteLine("Ano : {0}", ano);
    Console.WriteLine("Valor : {0}", valor);
    Console.WriteLine("Kms : {0}", km);
  }

  public void  AtualizaValor( int novoAno ){
    valor = valor - ( novoAno - ano ) * 2.05;
  }


}