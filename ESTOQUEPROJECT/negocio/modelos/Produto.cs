using System;
using System.Text;
public class Produto
{
    //criar propriedades personalizadas]
    private string nome;

    public string Nome { get{ return nome; }
        set
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Digite um nome para o produto.");
            }
            nome =  value;
        } 
    }

    //na verdade, descrição será opcional
    //nesse caso, o sabor mas poderia ser um produto simples sem descricao ex melancia
    private string descricao;
    public string Descricao { get{ return descricao; } 
        set
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Digite alguma descrição para o produto");
            }
        }
    }
    private double Preco { get; set; }

    private int quantidade;
    public int Quantidade {get { return quantidade; }
        set
        {
        if(quantidade < 0)
        {
            throw new ArgumentException("Há algum erro com a quantidade. Verifique se o estoque está atualizado.");
        }
        quantidade = value;
        }
        }

    
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