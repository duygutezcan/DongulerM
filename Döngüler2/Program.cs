// See https://aka.ms/new-console-template for more information 

int[] sayilar = { 10, 17, 5, 21, 40, 7 };
int sayac = 0;
int toplam = 0;

Basla();

void Basla()         // bu fonksiyonun içindekiler derlenir
{
    DoDongusu();
    ForDongusu();
    WhileDongusu();
    ForEachDongusu();
}
void ForDongusu()
{
   
    BaslıkYaz("For Döngüsü");
    for (int i = 0; i < sayilar.Length; i++)
    {
        Console.WriteLine(sayilar[i]);
        toplam += sayilar[i];                                  // toplam = toplam + sayilar[i]; 
    }

    ToplamAl();
}

void DoDongusu()
{
    BaslıkYaz("Do Döngüsü");
    do
    {

        Console.WriteLine(sayilar[sayac]);
        toplam += sayilar[sayac];
        sayac++;     // sayac = sayac + 1; yazılışının kısaltılması
    } while (sayac < sayilar.Length);
    ToplamAl();
}

void WhileDongusu()
{
    BaslıkYaz("While Döngüsü");
    while (sayac < sayilar.Length)
    {

        Console.WriteLine(sayilar[sayac]);
        toplam += sayilar[sayac];
        sayac++;
    }
    ToplamAl();
}

void ForEachDongusu()
{
    BaslıkYaz("For each Döngüsü");
    foreach (var item in sayilar)        
    {
        Console.WriteLine(item);
        toplam += item;
    }

    ToplamAl();
}
void BaslıkYaz(string metin)      // bir önceki klasörde yapılan son örnekte her döngüde tekrar eden Console.Write için metod oluşturma
{
    toplam = 0;
    sayac = 0;
    Console.WriteLine("**************");
    Console.WriteLine(metin);
    Console.WriteLine("**************");
}

void ToplamAl()                  // bir önceki klasörde yapılan son örnekte her döngüde tekrar eden Console.Write için metod oluşturma
{
    Console.WriteLine("------------------------------");
    Console.WriteLine("Toplam  : " + toplam);
    Console.WriteLine("------------------------------");
}


