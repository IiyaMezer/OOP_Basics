using System.Text;

namespace Cipher;

public interface ICoder
{

    StringBuilder Encode(StringBuilder toencode);

    StringBuilder Decode(StringBuilder todecode);

}

