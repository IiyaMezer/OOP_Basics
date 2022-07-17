﻿using System.Text;

namespace Cipher;
public class BCoder: ICoder
{
    private string _Text;

    /// <summary>
    /// Алфавит нижнего регистра
    /// </summary>

    private readonly char[] _A = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
    /// <summary>
    /// алфавит верхнего регистра
    /// </summary>
    private readonly char[] _AUP = { 'A', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };

    public string Text
    {
        get => _Text;
        set => _Text = value;
    }

    public BCoder(string text)
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
            //буква или нет
            if (!Char.IsLetter(toencode[i]))
                result.Append(toencode[i]);
            else
            {
                //заглавная или нет
                if (!Char.IsLower(toencode[i]))
                {
                    for (int j = 0; j < _AUP.Length; j++)//для верхнего регистра
                    {
                        if (toencode[i] == _AUP[j])
                        {
                            index = j;
                            break;
                        }
                    }
                    d = _A.Length - index;
                    
                    toencode[i] = _AUP[d];
                }

                else
                {
                    for (int j = 0; j < _A.Length; j++)//для нижнего регистра
                    {
                        if (toencode[i] == _A[j])
                        {
                            index = j;
                            break;
                        }
                    }
                    d = _A.Length - index;

                    toencode[i] = _A[d];
                }

                result.Append(toencode[i]);
            }
        }
        return result;
    }



    public StringBuilder Decode()
    {
        int d;
        int index = 0;
        var result = new StringBuilder();
        char[] toencode = _Text.ToCharArray();

        for (int i = 0; i < toencode.Length; i++)
        {
            //буква или нет
            if (!Char.IsLetter(toencode[i]))
                result.Append(toencode[i]);
            else
            {
                //заглавная или нет
                if (!Char.IsLower(toencode[i]))
                {
                    for (int j = 0; j < _AUP.Length; j++)
                    {
                        if (toencode[i] == _AUP[j])
                        {
                            index = j;
                            break;
                        }
                    }
                    d = _A.Length - index;

                    
                    toencode[i] = _AUP[d];
                }

                else
                {
                    for (int j = 0; j < _A.Length; j++)
                    {
                        if (toencode[i] == _A[j])
                        {
                            index = j;
                            break;
                        }
                    }
                    d = _A.Length - index;
                    
                    toencode[i] = _A[d];
                }

                result.Append(toencode[i]);
            }
        }
        return result;
    }

}