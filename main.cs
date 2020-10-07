using System;

class MainClass {
  public static void Main (string[] args) {
    Vendedor carlos = new Vendedor("Matheus", 1800.00, 5.0);
    Veiculo ferrari = new Veiculo("Ferrari", 2020, 150000, 0);

    Mostruario session_A = new Mostruario( carlos );

    session_A.carros.Add( ferrari );
    session_A.carros.Add( ferrari );
    session_A.carros.Add( ferrari );
    session_A.carros.Add( ferrari );

    double total = session_A.GetCalculaValor();

    Console.WriteLine( "Valor total da sessao: {0}", total );
    
  }
}