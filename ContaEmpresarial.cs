public class ContaEmpresarial : Conta
{
    private double _anuidade;
    private double _limiteEmprestimo;
    private double _totalEmprestimo;

    public double getAnuidade()
    {   
        return _anuidade;
    }
    public void setAnuidade(double anuidade) 
    {
        this._anuidade = anuidade;
    }
    public double getLimiteEMP()
    {
        return _limiteEmprestimo;
    }
    public void setLimiteEMP(double limiteEmprestimo)
    {
        this._limiteEmprestimo = limiteEmprestimo;
    }
    public double getTotalEMP()
    { 
        return _totalEmprestimo;
    }
 

    public void Emprestimo(double saldo)
    {
        if (saldo <= _limiteEmprestimo - _totalEmprestimo)
        {
            _saldo += saldo;
            _totalEmprestimo += _saldo;
        }
    }
    public override void Sacar(double saldo)
    {
        if (saldo > 5000)
        {
            saldo += 5.00;
            saldo -= _saldo;
        }
        else
        {
            base.Sacar(saldo);
        }
    }
}