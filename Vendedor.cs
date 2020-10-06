class Vendedor{

  private double salario;
  private double comissao;
  
  public Vendedor( double _salario, double _comissao ){
    salario = _salario;
    comissao = _comissao;
  }

  public double ReceberSalario( int totalVenda ){
    return salario + comissao * totalVenda
  }

}