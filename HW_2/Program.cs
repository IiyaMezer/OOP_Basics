using System.Text;
using Cipher;


StringBuilder encoded = new StringBuilder();
StringBuilder decoded = new StringBuilder();

string sampletext = "Привет Мир!";

BCoder samplecode = new BCoder(sampletext);

encoded = samplecode.Encode();

string sampledecode1 = encoded.ToString();


BCoder sampledecode = new BCoder(sampledecode1);


Console.WriteLine(encoded.ToString());

decoded = sampledecode.Decode();
Console.WriteLine(decoded.ToString());







Console.ReadLine();




