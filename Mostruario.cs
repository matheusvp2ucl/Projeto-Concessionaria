using System.Collections.Generic;

class Mostruario {

  private Vendedor representante;
  public List<Veiculo> carros;

  public SetMostruario(){
    carros = new List<Veiculo>();
  }

  public void SetRepresentante(Vendedor _vendedor){
    representante = _vendedor;
  }


}