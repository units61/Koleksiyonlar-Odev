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

