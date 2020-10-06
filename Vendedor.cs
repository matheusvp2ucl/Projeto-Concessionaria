class Vendedor{

  private double salario;
  private double comissao;
  
  public double ReceberSalario( int totalVenda ){
    return salario + comissao * totalVenda
  }

}