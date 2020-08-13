using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: Moca.Configuration.SectionProtection(Moca.Configuration.ProtectionProviderType.DPAPI, "connectionStrings")]
[assembly: Moca.Configuration.SectionProtection(Moca.Configuration.ProtectionProviderType.DPAPI, "appSettings")]
[assembly: Moca.Configuration.SectionProtection(Moca.Configuration.ProtectionProviderType.DPAPI, "ConsoleApp1.Properties.Settings")]

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Properties.Settings.Default.UserConf = "Hoge";
            Properties.Settings.Default.Save();

            Moca.Configuration.SectionProtector.Protect();
       }
    }
}
