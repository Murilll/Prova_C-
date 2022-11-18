using System.Collections.Generic;
using System;

App.Run();
public class BluerControl
{   
    public void ApplyBlur(byte[] data)
    {
        byte[] exit = new byte[data.Length];
        for (int i = 0; i < data.Length; i++)
        {
            if (((data.Length - 20) > i) && (i-20 > 0))
            {
                int aux = 0;
                for (int reverse = -20; reverse < 20 ; reverse++)
                {
                    aux += data[i-reverse];
                }
                exit[i] = (byte)(aux/42);
            }
        }
        for (int j = 0; j < exit.Length; j++)
        {
            data[j] = exit[j];
        }
    }
}

