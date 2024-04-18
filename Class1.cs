using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace jurnal8
{
    public class BankTransferConfig
    {
       public string lang { get; set; }
        public int threshold { get; set; }
        public  int low_fee { get; set; }
        public int high_fee { get; set; } 
        public string methods { get; set; }
        public string en {  get; set; }
        public string id { get; set; }

        public BankTransferConfig() { }

        public BankTransferConfig(string lang, int threshold, int low_fee, int high_fee, string methods, string en, string id)
        {
            this.lang = lang;
            this.threshold = threshold;
            this.low_fee = low_fee;
            this.high_fee = high_fee;
            this.methods = methods;
            this.en = en;
            this.id = id;
        }
    }

    public class UIConfig
    {
        public const string filePath = "D:\\Kuyliah\\Semester 4\\JsonKPL\\bank_transfer_config.json";
     
        public void setDefault() { 
            configuration = new BankTransferConfig("en", 25000000, 6500, 15000, ["RTO","SKN","RTGS","BI FAST"],"yes","ya");
        }

        public BankTransferConfig WriteConfigfile ()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };
            String jsonString = JsonSerializer.Serialize(configuration,options);
            File.WriteAllText(filePath, jsonString);
        }
    }

}
