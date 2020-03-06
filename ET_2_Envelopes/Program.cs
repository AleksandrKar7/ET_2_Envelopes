using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_2_Envelopes
{
    class Program
    {
        const int MaxCountEnvelope = 2;
        static void Main(string[] args)
        {
            IEnvelope[] envelopes = new IEnvelope[MaxCountEnvelope];

            double? length;
            double? height;

            int i = 0;
            do
            {
                Console.WriteLine("Edit values for envelope number " + (i + 1) + ": ");
                length = ConsoleMenu.GetDoubleValue("Length: ");
                height = ConsoleMenu.GetDoubleValue("Height: ");
                if(length == null)
                {
                    Console.WriteLine("Length is not valid");
                    continue;
                }
                if (height == null)
                {
                    Console.WriteLine("Height is not valid");
                    continue;
                }
                envelopes[i] = new RectangularEnvelope((double)length, (double)height);
                i++;
                if(i < MaxCountEnvelope)
                {
                    continue;
                }
                else
                {
                    if (envelopes[0].DoesFits(envelopes[1]))
                    {
                        Console.WriteLine("The second envelope will fit into the first");
                    }
                    else
                    {
                        Console.WriteLine("The second envelope will not fit into the first");
                    }
                }

                i = 0;
                if (!ConsoleMenu.GetBoolValue("Do you want to continue?", new string[] { "Y", "YES" }))
                {
                    break;
                }
            } while (true);
        }

    }
}
 