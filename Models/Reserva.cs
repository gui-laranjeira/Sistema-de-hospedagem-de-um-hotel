using System.Linq.Expressions;

namespace Sistema_de_hospedagem_de_um_hotel.Models;

public class Reserva
{

    public List<Pessoa> _hospedes { get; set; }

    public Suite _suite { get; set; }

    public int DiasReservados { get; set; }

    public Reserva(int diasReservados)
    {
        this.DiasReservados = diasReservados;
    }


    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (hospedes.Count <= _suite.Capacidade)
        {
            this._hospedes = hospedes;
        }
        else
        {   //importante ser uma excessão pro programa parar de rodar
            throw new ArgumentException("A suite não comporta o número de hospedes!");
        }
    }

    public void CadastrarSuite(Suite suite)
    {
        this._suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        int quantidadeHospedes = 0;
        quantidadeHospedes += _hospedes.Count;
        return quantidadeHospedes;
    }

    public decimal CalcularValorDiaria()
    {
        decimal valorDiaria = 0;
        valorDiaria = _suite.ValorDiaria * DiasReservados;
        if (DiasReservados >= 10)
        {
            valorDiaria -= valorDiaria * 0.10M;
        }
        
        return valorDiaria;
    }
}