namespace birthday;

class Program
{
    static void Main(string[] args)
    {
       
       Console.Write("Doğduğunuz Günü Giriniz ( 1-31 Arasında ): ");
       int gun = int.Parse(Console.ReadLine());

       if(gun<=32){

        Console.Write("Doğduğunuz Ayı Giriniz (1-12 Arasında ): ");
       int ay = int.Parse(Console.ReadLine());

       string burc;

       if(ay ==1)
       {
        if(gun<=20) burc= "Oğlak";
       
        else burc= "Kova";
       }
       
       else if (ay==2)
       {    
        
        if(gun<=18) burc= "Kova";
       
        else burc= "Balık";

       }

        else if (ay==3)
       {    
        
        if(gun<=19) burc= "Balık";
       
        else burc= "Koç";

       }

        else if (ay==4)
       {    
        
        if(gun<=20) burc= "Koç";
       
        else burc= "Boğa";

       }

        else if (ay==5)
       {    
        
        if(gun<=21) burc= "Boğa";
       
        else burc= "ikizler";

       }

        else if (ay==6)
       {    
        
        if(gun<=22) burc= "ikizler";
       
        else burc= "Yengeç";

       }

        else if (ay==7)
       {    
        
        if(gun<=22) burc= "Yengeç";
       
        else burc= "Aslan";

       }

        else if (ay==8)
       {    
        
        if(gun<=22) burc= "Aslan";
       
        else burc= "Başak";

       }

        else if (ay==9)
       {    
        
        if(gun<=22) burc= "Başak";
       
        else burc= "Terazi";

       }

        else if (ay==10)
       {    
        
        if(gun<=22) burc= "Terazi";
       
        else burc= "Akrep";

       }

        else if (ay==11)
       {    
        
        if(gun<=21) burc= "Akrep";
       
        else burc= "Yay";

       }

        else if (ay==12)
       {    
        
        if(gun<=21) burc= "Yay";
       
        else burc= "Oğlak";

       }

        else
        {
            burc = "Ayı Yanlış Girdiniz. Lütfen Programı tekrar çalıştırın ve 1 ile 12 arasında rakam giriniz.";
        }
System.Console.WriteLine($"Sizin Burcunuz : {burc}");

} else System.Console.WriteLine("Hatalı Gün Girdiniz. Programı Tekrar Çalıştırın ve 1 ile 31 arasında bir rakam giriniz.");

        } 
    }

    

