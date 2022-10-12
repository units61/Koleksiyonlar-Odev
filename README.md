# KOLEKSİYON SORU 1

```
// Koleksiyonlar-Soru-1
//Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

//Negatif ve numeric olmayan girişleri engelleyin.
//Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
//Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.



using System.Collections;

namespace KoleksiyonlarSoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            ArrayList PrimeNumberList = new ArrayList();
            ArrayList nonPrimeNumberList = new ArrayList();
            string input = "";
            int number;
            int i = 0;
            
            while(i != 20)
            {
                input = Console.ReadLine();
                if (!Int32.TryParse(input, out number)) {
                    Console.WriteLine("Sayi Giriniz: ");
                    continue;
                }
                else if (number <= 0) {
                    Console.WriteLine("Pozitif sayi girin:");
                    continue;
                }
                else if(!primeNumber(number)) {
                    nonPrimeNumberList.Add(number);
                    i++;
                }
                else {
                    PrimeNumberList.Add(number);
                    i++;
                }   
            }
            Sort(PrimeNumberList);
            Sort(nonPrimeNumberList);
            
            ScreenPrint(PrimeNumberList, "Asal Sayilar : ");
            ScreenPrint(nonPrimeNumberList, "Asal Olmayan Sayilar : ");
            Avarege(PrimeNumberList, "Asal Sayilarin Sayisi: ", " Ortalamasi: ");
            Avarege(nonPrimeNumberList, "Asal Sayilarin Sayisi: ", " Ortalamasi: ");     
            
        }
            static bool primeNumber(int x)
            {
                if (x < 2 ) 
                    return false;
                if (x == 2) 
                    return true;
                if(x % 2 == 0)
                    return false;
                int boundary = (int)Math.Floor(Math.Sqrt(x));
                        
                for (int i = 3; i <= boundary; i += 2) {
                    if (x % i == 0) {
                        return false;
                    }
                }     
                return true;
            }
            static void ScreenPrint(ArrayList list, string str)
            {
                Console.WriteLine(str);
                foreach (var item in list) {
                    Console.Write(item + " - ");
                }
                Console.WriteLine();
            }
            static ArrayList Sort(ArrayList list)
            {
                list.Sort();
                return list;
            }
            static void Avarege(ArrayList list, string str1, string str2)
            {
                int sum = 0;
                int avarege = 0;
                for (int j = 0; j < list.Count; j++) {
                    sum += Convert.ToInt32(list[j]);
                }
                avarege = sum/list.Count;
                Console.WriteLine(str1 + list.Count + str2 + avarege);
            } 
        

        static int Avarege(Array arr)
        {
            int sum = 0;
            float avarege = 0;
            foreach (var item in arr)
            {
                sum += Convert.ToInt32(item);
            }
            avarege = sum / arr.Length;
            return  (Int32)Math.Floor(avarege);
        }
        }
}

```

# KOLEKSİYON SORU 2

```
// Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
// her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını 
// console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

      Int32[] Numbers = new Int32[20];
            Int32[] minNumbers = new Int32[3];
            Int32[] maxNumbers = new Int32[3];
            string input;
            int number;
            
            for (int i = 0; i < 20; i++)
            {
                input = Console.ReadLine();
                if (!Int32.TryParse(input, out number)) {
                    Console.WriteLine("Sayi Giriniz: ");
                    continue;
                }
                Numbers[i] = number; 
            }
            Array.Sort(Numbers);
            for (int i = 0; i < 3; i++) {
                minNumbers[i] = Numbers[i];
            }
        
            Array.Reverse(Numbers);
            
            for (int i = 0; i < 3; i++) {
                maxNumbers[i] = Numbers[i];
            }
            int sum = Avarege(minNumbers) + Avarege(maxNumbers);
            Console.WriteLine("En küçüklerin Ortalamasi : " + Avarege(minNumbers));
            Console.WriteLine("En Büyüklerin Ortalamasi : " + Avarege(maxNumbers));
            Console.WriteLine("Ortalamalari Toplami : " + sum);

            static int Avarege(Array arr)
        {
            int sum = 0;
            float avarege = 0;
            foreach (var item in arr)
            {
                sum += Convert.ToInt32(item);
            }
            avarege = sum / arr.Length;
            return  (Int32)Math.Floor(avarege);
        }

```

# KOLEKSİYON SORU 3
```
// Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

using System.Collections;

Console.Write("Cümle Giriniz: ");
string cumle = Console.ReadLine().ToLower();

List<char> sesliler = new List<char>(){'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'};


int toplam = 0;
foreach(char karakter in cumle)   
foreach(char sesli in sesliler)
if(karakter == sesli)
toplam++;

Console.WriteLine("Cümlede {0} Tane Sesli Harf Vardır", toplam);

```