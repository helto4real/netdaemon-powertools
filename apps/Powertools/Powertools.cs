using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;

// Use unique namespaces for your apps if you going to share with others to avoid
// conflicting names
namespace Helto4real.Powertools
{
    public static class Powertools
    {
        /// <summary>
        ///     Takes a snapshot of given entity id of camera and sends to private discord server
        /// </summary>
        /// <param name="app">NetDaemonApp to extend</param>
        /// <param name="camera">Unique id of the camera</param>
        /// <returns>The path to the snapshot</returns>
        public async static Task<string> CameraSnapshot(this NetDaemonApp app, string camera)
        {
            var resultingFilename = $"/config/www/motion/{camera}_latest.jpg";
            await app.CallService("camera", "snapshot", new
            {
                entity_id = camera,
                filename = resultingFilename
            });

            return resultingFilename;
        }

        /// <summary>
        ///     Takes a snapshot of given entity id of camera and sends to private discord server
        /// </summary>
        /// <param name="app">NetDaemonApp to extend</param>
        /// <param name="camera">Unique id of the camera</param>
        public async static Task CameraSnapshot(this NetDaemonApp app, string camera, string snapshotPath)
        {
            await app.CallService("camera", "snapshot", new
            {
                entity_id = camera,
                filename = snapshotPath
            });
        }

        /// <summary>
        ///     Prints the contents from a IDictionary to a string
        /// </summary>
        /// <param name="app">NetDaemonApp to extend</param>
        /// <param name="dict">The dict to print from, typically from dynamic result</param>
        /// <returns></returns>
        public static string PrettyPrintDictData(this NetDaemonApp app, IDictionary<string, object>? dict)
        {

            if (dict == null)
                return string.Empty;

            var builder = new StringBuilder(100);
            foreach (var key in dict.Keys)
            {
                builder.AppendLine($"{key}:{dict[key]}");
            }
            return builder.ToString();
        }
    }
}

