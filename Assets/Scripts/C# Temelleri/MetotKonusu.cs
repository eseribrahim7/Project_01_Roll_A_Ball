using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetotKonusu : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
        //print(isim("Bilal"));

    }

    int topla(int x, int y)
    {
        return x+y;
    }

    string isim(string isim)
    {
        return isim;
    }

    void ekranaBastir(string isim)
    {
        print(isim);
    }

    void cikar(int sayi)
    {
        print(sayi-5);
    }

    void isimSoyisim(string isim, string soyisim)
    {
        print(isim+soyisim);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
