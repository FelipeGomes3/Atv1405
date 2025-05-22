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
        _anuidade = anuidade;
    }
    public double getLimiteEMP()
    {
        return _limiteEmprestimo;
    }
    public void setLimiteEMP(double limiteEmprestimo)
    {
        _limiteEmprestimo = limiteEmprestimo;
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
            _totalEmprestimo += saldo;
        }
        else
        {
            throw new Exception("Valor de emprestimo não pode ser concedido!");
        }
    }
    public override void Sacar(double saldo)
    {
        if (saldo > 5000 && saldo <= _saldo-5)
        {
            _saldo -= saldo;
            _saldo = -5;
        
        }
        else if (saldo < 5000)
        {
            base.Sacar(saldo);
        }
        else
        {
            throw new Exception("Saldo insuficiente");
        }
    }
}