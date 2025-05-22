public class Conta
{
    private int _nConta;
    private string _agencia;
    private string _nome;
    protected double _saldo;

    public int getN_Conta() // Sempre terá o retorno
    {
        return _nConta;
    }
    public void setN_Conta(int nConta) // Sempre será o Parâmetro
    {
        _nConta = nConta;
    }

    public string getAgencia()
    {
        return _agencia;
    }
    public void setAgencia(string Agencia)
    {
        _agencia = Agencia;
    }
    public string getNome()
    {
        return _nome;
    }
    public void setNome(string Nome)
    {
        _nome = Nome;
    }

    public double getSaldo()
    {
        return _saldo;
    }
    


    public virtual void Sacar(double saldo)
    {
        if (saldo <= _saldo && saldo > 0)
        {
            _saldo -= saldo;
        }

        else
        {
            throw new Exception("Saque indisponível");
        }
    }

    public virtual void Depositar(double deposito)
    {
        if (deposito <= 0)
        {
            throw new Exception("Valor Inválido");
        }
        _saldo += deposito;

    }

}