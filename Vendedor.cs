class Vendedor{

  private double salario;
  private double comissao;
  private string nome;
  
  public Vendedor( string _nome, double _salario, double _comissao ){
    nome = _nome;
    salario = _salario;
    comissao = _comissao;
  }

  public double ReceberSalario( int totalVenda ){
    return salario + comissao * totalVenda;
  }

}