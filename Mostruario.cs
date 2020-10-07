using System.Collections.Generic;

class Mostruario {

  private Vendedor representante;
  public List<Veiculo> carros;

  public Mostruario( Vendedor _vendedor ){
    representante = _vendedor;
    carros = new List<Veiculo>();
  }

  public void SetRepresentante( Vendedor _vendedor ){
    representante = _vendedor;
  }

  public double CalculaValor (){
    double soma = 0;
    for( int i = 0 ; i < carros.Count ; i++ ){
      soma += carros[i].Valor;
    }
    return soma;
  }

}