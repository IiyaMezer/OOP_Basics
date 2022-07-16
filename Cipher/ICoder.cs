using System.Text;

namespace Cipher;

public interface ICoder
{

    StringBuilder Encode();

    StringBuilder Decode(string todecode);

}

