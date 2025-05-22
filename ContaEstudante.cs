public class ContaEstudante : Conta
{
    private double _limiteChequeEspecial;
    private string _cpf;
    private string _nomeInst;


    public double getLimiteCE()
    { 
    return _limiteChequeEspecial; 
    }
    public void setLimiteCE(double limiteCE)
    {
        _limiteChequeEspecial = limiteCE;
    }
    public string getCpf()
    {
        return _cpf;
    }
    public void setNomeInst(string Cpf)
    {
        _cpf = Cpf;
    }
    public string getNomeIns()
    {
        return _nomeInst;
    }
    public void setNomeIns(string NomeInst)
    {
        _nomeInst = NomeInst;
    }
    public override void Sacar(double saque) 
    {
        if (saque > 0 && saque <= _saldo + _limiteChequeEspecial)
        {
            _saldo = saque;
        }
        else
        {
            throw new Exception("Saldo insuficiente");
        }
    }

}
