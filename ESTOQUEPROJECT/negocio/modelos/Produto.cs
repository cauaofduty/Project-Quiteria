using System.Text;
public class Produto
{
    private string Nome { get; set; }
    private string Descricao { get; set; }//nesse caso, o sabor, ou seria melhor fazer diretamente?
    private double Preco { get; set; }
    private int Quantidade { get; set; }

    
    //to string substituido de object
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        
        //"Picolé Açaí"
        sb.Append($"{Nome} ");
        sb.Append($"{Descricao}\n");
        
        return sb.ToString();
    }

}