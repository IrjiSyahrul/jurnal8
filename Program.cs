internal class Program
{
    private static void Main(string[] args)
    {
       
        Console.WriteLine("Input : ");
        string lang = Console.ReadLine();

        if (lang == "en")
        {
            Console.WriteLine("Please insert the amount of money to transfer :");
            string nilaiTransfer = Console.ReadLine();

        }
        else (lang == "id") 
            {
            Console.WriteLine("Masukan jumlah uang yang akan di-transfer");
            string nilaiTransfer = Console.ReadLine();
            }


        if (nilaiTransfer <= threshold){
            int totalTranfer = nilaiTransfer + low_fee
        }else
        {
            Console.WriteLine("Total bayar anda" totalTransfer + high_fee)
        }
    }


}