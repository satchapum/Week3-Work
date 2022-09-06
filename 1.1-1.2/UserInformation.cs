public class UserInformation {

    private string StoreName = "";
    private string NumberID = "";
    private string NameOfOwner = ""; 
    private int RegisterValue;

    public UserInformation(string StoreName, string NumberID, string NameOfOwner, int RegisterValue) {
        this.StoreName = StoreName;
        this.NumberID = NumberID;
        this.NameOfOwner = NameOfOwner;
        this.RegisterValue = RegisterValue;
    }

    public void PrintUserInformation() {
        Console.WriteLine("------------------ Shop Information --------------------");
        Console.WriteLine("Name : {0}",StoreName);
        Console.WriteLine("Number : {0}",NumberID);
        Console.WriteLine("Owner Name : {0}",NameOfOwner);
        Console.WriteLine("Registered Value : {0}",RegisterValue);
        Console.WriteLine("========================================================");
    }
}