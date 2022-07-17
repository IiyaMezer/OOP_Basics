using System.Text;
using Cipher;


StringBuilder encoded = new StringBuilder();
StringBuilder decoded = new StringBuilder();

string sampletext = "А я Привет Мир я Мир !";

ACoder samplecode = new ACoder(sampletext);

encoded = samplecode.Encode();

string sampledecode1 = encoded.ToString();


ACoder sampledecode = new ACoder(sampledecode1);


Console.WriteLine(encoded.ToString());

decoded = sampledecode.Decode();
Console.WriteLine(decoded.ToString());







Console.ReadLine();




