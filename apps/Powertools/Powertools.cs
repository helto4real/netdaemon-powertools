using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;

// Use unique namespaces for your apps if you going to share with others to avoid
// conflicting names
namespace Helto4real.Powertools
{
    public class PowertoolsApp : NetDaemonApp
    {
        public async override Task InitializeAsync()
        {
            Log("Hello World!");

        }
    }
}

