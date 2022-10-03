namespace Sistema_de_hospedagem_de_um_hotel.Models;

public class Suite
{
    public string TipoSuite { get; set; }
    public int Capacidade { get; set; }
    public decimal ValorDiaria { get; set; }

    public Suite(string tipo, int capacidade, decimal valor)
    {
        this.TipoSuite = tipo;
        this.Capacidade = capacidade;
        this.ValorDiaria = valor;
    }
}