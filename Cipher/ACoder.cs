
using System.Text;

namespace Cipher;

public class ACoder : ICoder
{
    private string _Text;

    /// <summary>
    /// Алфавит 
    /// </summary>
    private static readonly char[] _A = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

    public string Text
    {
        get => _Text;
        set => _Text = value;
    }

    public ACoder (string text)
    {
        _Text = text;
    }
    
    public StringBuilder Encode()
    {
        int d;
        int index = 0;
        var result = new StringBuilder();
        char[] toencode = _Text.ToCharArray();

        for (int i = 0; i < toencode.Length; i++)
        {

            
            // Ищем индекс буквы
            for (int j = 0; j < _A.Length; j++)
            {
                if (toencode[i] == _A[j])
                {
                    index = j;
                    break;
                }
                    
            }
            d = index + 1; // Делаем смещение

            // Проверяем, чтобы не вышли за пределы алфавита
            if (d > 32)
            {
                d -= 33;
            }

            toencode[i] = _A[d]; // Меняем букву

 

            // Проверяем, чтобы не вышли за пределы алфавита
         
        

            result.Append(toencode[i]);
        }

        return result ;
    }

    public StringBuilder Decode(string text)
    {
        var result = new StringBuilder();

        return result;
    }




}



