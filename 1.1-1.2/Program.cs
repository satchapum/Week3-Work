public class Program {

    public static double ConvertStringToDouble(string value) {
        if(double.TryParse(value, out double number)) {
        return number;
        }

        throw new Exception("Please input number");
    }

    public static string InputMoney() {
        Console.Write("please input money : ");

        return Console.ReadLine();
    }

    public static string InputStoreName() {
        Console.Write("Please input store Name : ");
        return Console.ReadLine();
    }

    public static string InputNumberID() {
        Console.Write("Please input Number : ");
        return Console.ReadLine();
    }

    public static string InputNameOfOwner() {
        Console.Write("Please input Owner Name : ");
        return Console.ReadLine();
    }

    public static int InputRegisterValueAndConvertToInt() {
        Console.Write("Please input Register Value : ");
        return int.Parse(Console.ReadLine());
    }
    
    public static void Main(string[] args) {
        
        string StoreNameText = InputStoreName();
        string NumberIDText = InputNumberID();
        string NameOfOwnerText = InputNameOfOwner();
        int RegisterValueNumber = InputRegisterValueAndConvertToInt();
        UserInformation UserInfo = new UserInformation(StoreNameText, NumberIDText, NameOfOwnerText, RegisterValueNumber);
        
        UserInfo.PrintUserInformation();
    
        int[] MoneyChange = new int[11];
        string MoneyText = InputMoney();
        double MoneyNumber = ConvertStringToDouble(MoneyText);
        CoinChange.Calculate(ref MoneyChange,MoneyNumber);
        
        CoinChange.PrintInformation(MoneyChange);
    }
}