public class CoinChange {

    public static void Calculate(ref int[] MoneyChange, double Input) {
        double[] Money = {1000,500,100,50,20,10,5,2,1,0.5,0.25};
        
        for(int i = 0; i < Money.Length; i++) {
            MoneyChange[i] = 0;
            while(Input >= Money[i]) {
                Input -= Money[i];
                MoneyChange[i]++; 
            }
        }
    }

    public static void PrintInformation(int[] MoneyChange) {
        Console.WriteLine("1000 : {0}",MoneyChange[0]);
        Console.WriteLine("500  : {0}",MoneyChange[1]);
        Console.WriteLine("100  : {0}",MoneyChange[2]);
        Console.WriteLine("50   : {0}",MoneyChange[3]);
        Console.WriteLine("20   : {0}",MoneyChange[4]);
        Console.WriteLine("10   : {0}",MoneyChange[5]);
        Console.WriteLine("5    : {0}",MoneyChange[6]);
        Console.WriteLine("2    : {0}",MoneyChange[7]);
        Console.WriteLine("1    : {0}",MoneyChange[8]);
        Console.WriteLine("0.5  : {0}",MoneyChange[9]);
        Console.WriteLine("0.25 : {0}",MoneyChange[10]);
    }
}