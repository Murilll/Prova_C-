using System;

double[] array = new double[]
{
    6.6, 7.2, 7.2, 8.4, 8.6, 8.4, 9.4, 9.8, 10.0
};


Console.WriteLine(mediaEspecial(array));

double mediaEspecial(double[] array)
{
    double[] saida = new double[3];
    int item = array.Count();
    saida[0] = array[(item/2)];
    saida[1] = array[(item/2)-1];
    saida[2] = array[(item/2)+1];

    double media = saida.Sum() / saida.Length;
    return media;
}