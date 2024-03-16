using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSharpTemelleri : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        //Integer; 2,10,101,1002...
        //print(123465789);
        //int x = 56;
        //print(x);
        //Float; 3.14,5.23,102.6...
        //print(3.14);
        //float y = 3.14f;
        //print(y);
        
        //String; "Bilal bugün eve gitti.", "Devkod"...
        //string isim = "Bilal Kayi";
        //print(isim);
        
        //Var;
        
        //var a = 15;
        //var b = 3.14f;
        //var c = "Devkod Akademi";
        

        //print(a);
        //print(b);
        //print(c);
        //print(10000000/23);

        //bool x = true;
        //bool y = false;

        //var x = 1;
        //var y = 2;

        //var a = "Bilal ";
        //var b = "Kayi";

        //var j = "123 ";
        //var k = "245";

        //var a = "Devkod Akademi";
        //var b = 12;
        //var c = 3.14f;


        //print(a + " " + b + " " + c);

        //a = "Bilal Kayi";
        //b = 25;
        //c = 4.15f;


        //print(a + " " + b + " " + c);


        //> - Büyüktür
        //print(5>6);

        //< - Küçüktür
        //print(5<6);
        
        //== - Eşittir
        //print(5==5);

        //>= - Büyük ya da eşittir
        //print(5>=6);
        
        //<= - Küçük ya da eşittir
        //print(6<=5);


        //Koşullu Durumlar - if-else-else if
        
        //var a = 5;
        //var b = 6;
        //var c = 5;

        //if(a==b)
        //{
        //    print("a, b'ye eşittir.");



        //}else if(a==c)
        //{
        //    print("a, c'ye eşittir.");

        //}else
        //{
        //    print("a, b'ye eşit değildir.");
        //}


        //while Döngüsü

        //var x = 0;

        //while(x<5)
        //{
        //    x = x+1;
        //    print(x);
        //}

        //do-while Döngüsü

        //var x = 0;

        //do
        //{
             
        //    x += 4;

        //    print(x);

        //}while(x<5);
        
        //switch-case Yapısı

        //var x = 2;

        //switch(x)
        //{
        //    case 1: print("x'in değeri 1'dir.");
        //        break;
        //    case 2: print("x'in değeri 2'dir.");
        //        break;
        //}

        //for Döngüsü
        //int x;
        //Tanımlama-Şart-Yapılacak
        //for(x = 0; x < 5; x += 1)
        //{
        //    print(x);
        //}//x += 1

        //Listeler
        /*List<string> gunler = new List<string>();

        gunler.Add("Pazartesi");
        gunler.Add("Salı");
        gunler.Add("Çarşamba");*/

        //Iterable Obje

        //foreach Döngüsü
        //foreach (var item in gunler)
        //{
        //    print(item);
        //}

        //var x = 5;
        //var y = "Bilal";

        //int x = 5;
        //string isim = "Bilal";

        //print(isim);




        //Array
            //string isim = "Bilal";

            string[] gunlerArray = {"Pazartesi", "Salı", "Çarşamba"};

            /*foreach (var item in gunler)
            {
                print(item);
            }*/

            //print(gunlerArray[2]);
            //print(gunler[1]);

        



        //ArrayList

            ArrayList karisik = new ArrayList();

            karisik.Add(2);
            karisik.Add("Bilal");
            karisik.Add(3.14f);

            /*foreach (var item in karisik)
            {   
                print(item);
                
            }*/

            //print(karisik[1]);



        
        

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
