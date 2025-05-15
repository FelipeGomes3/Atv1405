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
        this._limiteChequeEspecial = limiteCE;
    }
    public string getCpf()
    {
        return _cpf;
    }
    public void setNomeInst(string Cpf)
    {
        this._cpf = Cpf;
    }
    public string getNomeIns()
    {
        return _nomeInst;
    }
    public void setNomeIns(string NomeInst)
    {
        this._nomeInst = NomeInst;
    }
    public override void Sacar(double saque) 
    {
       _saldo = saque;
    }

}
