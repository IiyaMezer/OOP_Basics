using System.Text;
using Cipher;


string sampletext = "привет мир!";

ACoder samplecode = new ACoder(sampletext);

StringBuilder encoded = new StringBuilder();
StringBuilder decoded = new StringBuilder();





encoded = samplecode.Encode();

string sampledecode1 = encoded.ToString();
ACoder sampledecode = new ACoder(sampledecode1);


Console.WriteLine(encoded.ToString());

decoded = sampledecode.Decode();
Console.WriteLine(decoded.ToString());







Console.ReadLine();




