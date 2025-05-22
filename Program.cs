//// Conteudo Prova
//Classe, Atributos, Parâmetros, Exceções, Metódos, Get e Set, Herança, Polimorfismo, Construtor, Sobrecarga de Métodos, Classe Estáticas


try
{
    Conta c = new Conta();
    double v = 10;
    c.Depositar(v);
    Console.WriteLine("Valor depositado com sucesso!");
    
    ContaEmpresarial c1 = new ContaEmpresarial();
    c1.Depositar(10);
    c1.Sacar(0);
    Console.WriteLine($"Valor {c1.Depositar} foi depositado");
    ContaEstudante c2 = new ContaEstudante();
    c2.Depositar(-10);
    c2.Sacar(100);
    Console.WriteLine($"Valor {c2.Depositar} foi depositado");


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}