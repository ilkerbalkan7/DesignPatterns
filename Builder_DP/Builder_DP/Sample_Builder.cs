using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Builder_DP.Message.MessageBuilder;

namespace Builder_DP
{
    class Sample_Builder
    {
        static void Main(string[] args)
        {
            MessageCreator builder = new MessageCreator();
            builder.Create(new CelebrateBirthdayBuilder());
            builder.Show();
            Console.ReadLine();
        }
    }
}
