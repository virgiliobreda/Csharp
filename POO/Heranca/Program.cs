ClasseDerivada c = new ClasseDerivada();
c.VerificaAcesso();
public class ClasseDerivada : ClasseBase
{
    public void VerificaAcesso()
    {
        Public_Membro();
        Protected_Membro();
        Protected_Internal_Membro();
        Internal_Membro();
        //Private_Membro();
        Console.WriteLine("Acesso ao Campo private usando propriedade");
        int s = public_var + protected_var + Private_var + internal_var;
        Console.WriteLine(s);
    }
}


public class ClasseBase
{
    //Campos
    public int public_var = 1;
    protected int protected_var = 2;
    private int private_var = 3;
    internal int internal_var = 4;

    //propriedade
    public int Private_var
    {
        get { return private_var; }
        set { private_var = value; }
    }
    public void Public_Membro()
    {
        Console.WriteLine("Classe Base - Método Public");
    }
    protected void Protected_Membro()
    {
        Console.WriteLine("Classe Base - Método Protected");
    }
    internal void Internal_Membro()
    {
        Console.WriteLine("Classe Base - Método Internal");
    }
    protected internal void Protected_Internal_Membro()
    {
        Console.WriteLine("Classe Base - Método protected internal");
    }
    private void Private_Membro()
    {
        Console.WriteLine("Classe Base - Método private");
    }
}