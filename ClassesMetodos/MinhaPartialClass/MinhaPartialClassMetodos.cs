using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22MinhaPartialClass;

public partial class MinhaPartialClass
{
    public TimeSpan Idade(DateTime dataNascimento)
    {
        return DateTime.Now - dataNascimento;
    }
    public TimeSpan DiferencaEntreDatas(DateTime data1, DateTime data2)
    {
        var diferenca = data1.Subtract(data2);
        return diferenca;
    }
}

