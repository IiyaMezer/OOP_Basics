using System.Text;
using Cipher;


string sampletext = "привет мир!";

ACoder sample = new ACoder(sampletext);
StringBuilder encoded = new StringBuilder();

encoded = sample.Encode();

Console.WriteLine(encoded.ToString());





Console.ReadLine();




