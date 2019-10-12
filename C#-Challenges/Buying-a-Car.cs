//Buying a car challenge. Purchasing a new car. Include monthly savings, depreciation and sale value of old car. How many months will it take?


using System;
public class Challenge {

  public static int[] NbMonths(int startPriceOld, int startPriceNew, int savingperMonth, double percentLossByMonth) {
    int month = 0;
    double priceNew = startPriceNew;
    double priceOld = startPriceOld;
    double savings = priceOld;
    while(savings<priceNew){
      month++;
      if(month%2==0) percentLossByMonth+=0.5;
      priceOld -= priceOld*(percentLossByMonth/100);
      priceNew -= priceNew*(percentLossByMonth/100);
      savings = month*savingperMonth + priceOld;
    }
    return new int[]{ month, (int)(Math.Round(savings - priceNew))};
  }
}