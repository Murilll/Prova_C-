using System.Collections.Generic;

App.Run();

public class Controller
{   
    public int count { get; set; } = 0;
    // for (int i = 0; i < length; i++)
    // {
        

    public float[] valor = new float[20];

    public float Control(float x)
    { 
        if (this.count >= 20)
            this.count = 0;
        this.valor[this.count] = x;
        this.count ++;
        float soma = 0;
        int qtd = 0;

        foreach (var valor in this.valor)
            soma += valor;
            qtd++;
        float media = soma /qtd;
        float s = (float)(1.57 * media - 285);
        return s;
    }
}