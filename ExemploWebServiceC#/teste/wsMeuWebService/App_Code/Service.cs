using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{
    public Service()
    {
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

    [WebMethod]
    public decimal Calculadora(decimal ValorA, decimal ValorB, OperacoesBasicas TipoOperacao)
    {
        decimal ResultadoAB = 0;

        switch (TipoOperacao)
        {
            case OperacoesBasicas.Adicao:
                {
                    ResultadoAB = decimal.Add(ValorA, ValorB);
                    break;
                }
            case OperacoesBasicas.Divisao:
                {
                    ResultadoAB = decimal.Divide(ValorA, ValorB);
                    break;
                }

            case OperacoesBasicas.Multiplicacao:
                {
                    ResultadoAB = decimal.Multiply(ValorA, ValorB);
                    break;
                }
            case OperacoesBasicas.Subtracao:
                {
                    ResultadoAB = decimal.Subtract(ValorA, ValorB);
                    break;
                }
        }

        return ResultadoAB;
    }
}

public enum OperacoesBasicas
{
    Adicao = 0,
    Divisao = 1,
    Multiplicacao = 2,
    Subtracao = 3
}