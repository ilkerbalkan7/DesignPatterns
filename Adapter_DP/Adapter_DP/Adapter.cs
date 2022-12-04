using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_DP;
public class Adapter
{
    static void Main(string[] args)
            {
                ICardReaderAdapter reader = new XbankReaderAdapter();
                var result = reader.ReadCardData();
                Console.WriteLine(result);
                Console.ReadLine();
            }
}

public interface ICardReaderAdapter
{
    public string ReadCardData();
}

public class XbankReaderAdapter: ICardReaderAdapter
{
    public string ReadCardData()
    {
        XBankPOSReader posReader = new XBankPOSReader();
        return posReader.ReadFromCard();
    }
}

public class XBankPOSReader
{
    public string ReadFromCard()
    {
        return "X bank Pos machine is working";
    }
}



