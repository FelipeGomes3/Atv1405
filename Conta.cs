public class Conta
{
    private int _nConta;
    private string _agencia;
    private string _nome;
    protected double _saldo;

    public int getN_Conta()
    {
        return _nConta;
    }
    public void setN_Conta(int nConta)
    {
        this._nConta = nConta;
    }

    public string getAgencia()
    {
        return _agencia;
    }
    public void setAgencia(string Agencia)
    {
        this._agencia = Agencia;
    }
    public string getNome()
    {
        return _nome;
    }
    public void setNome(string Nome)
    {
        this._nome = Nome;
    }


    public virtual void Sacar(double saldo)
    {
        if (saldo > 0)
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
        if (deposito > 0)
        {
            
        }

        else
        {
            throw new Exception("Valor para depósito precisa ser maior que 0,00");
        }


    }

}