using System.Text;
using Cipher;


StringBuilder encoded = new StringBuilder();
StringBuilder decoded = new StringBuilder();

string sampletext =
    "Имеется спорная точка зрения, гласящая примерно следующее: сделанные на базе интернет-аналитики выводы призывают нас к новым свершениям, которые, в свою очередь, должны быть в равной степени предоставлены сами себе.";
ACoder samplecode = new ACoder(sampletext);

encoded = samplecode.Encode();

string sampledecode1 = encoded.ToString();


ACoder sampledecode = new ACoder(sampledecode1);


Console.WriteLine(encoded.ToString());

decoded = sampledecode.Decode();
Console.WriteLine(decoded.ToString());

Console.ReadLine();




