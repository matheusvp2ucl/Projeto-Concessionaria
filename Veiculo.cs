using System;

class Veiculo{

  private string marca;
  private int ano;
  private double valor;
  private int km;

  public string Marca{
    get { return marca; }
    set { marca = value; }
  }

  public int Ano{
    get { return ano; }
    set { ano = value; }
  }

  public double Valor{
    get { return valor; }
    set { valor = value; }
  }

  public int Km{
    get { return km; }
    set { km = value; }
  }

  public Veiculo( string _marca, int _ano, double _valor, int _km ){
    marca = _marca;
    ano = _ano;
    valor = _valor;
    km = _km;
  }

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