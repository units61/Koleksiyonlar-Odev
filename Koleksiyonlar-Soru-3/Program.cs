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
