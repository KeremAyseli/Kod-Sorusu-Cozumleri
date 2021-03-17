<h2>Listedeki en küçük iki sayının toplamını veren program</h2>
using System;
public static class Kata
{
 public static int sumTwoSmallestNumbers(int[] numbers)
        {
            int[] lowestNumber = ranking(numbers);
            return lowestNumber[0] + lowestNumber[1];
        }
        public static int[] ranking(int[] numbers)
        {
            int tmp;
            for (int i = 0; i < numbers.Length; i++)
            {
              for(int j = 1+i; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        tmp = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = tmp;
                    }
                }
            } 
            return numbers;
        }
        public static int[] tekrarEdenSayılar(int[] arr)
        {
            int tekrarSayısı=0;
            int[] tekrarKonumları=new int[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        tekrarSayısı++;
                        tekrarKonumları[i] = j;  
                    }
                
                }
            }
            tekrarKonumları = listClear(tekrarKonumları);
               int[] newList =  new int[arr.Length-tekrarSayısı];
            
            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < tekrarKonumları.Length; j++)
                {
                    if (i != tekrarKonumları[j])
                    {
                        newList[i] = arr[i];
                    }
                }
            }
            return newList;
        }
       public static int[] listClear(int[] list)
        {
            int sıfırAdet = 0;
            for(int i = 0; i < list.Length; i++)
            {
                if (list[i] == 0)
                {
                    sıfırAdet++;
                }
            }
            int[] listeSayıları = new int[list.Length - sıfırAdet];
            for(int i = 0; i < listeSayıları.Length; i++)
            {
                for(int j = 0; j < list.Length; j++)
                {
                    if(list[j]!=0)
                    {
                        listeSayıları[i] = list[j];
                        
                    }
                }
            }  
            return listeSayıları;
        }
}
