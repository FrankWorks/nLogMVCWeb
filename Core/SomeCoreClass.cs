using System.Diagnostics;
using System.Reflection;

namespace Core
{
    public class SomeCoreClass
    {
        public static string GetAssemblyInfo()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();       

            return string.Format("Full Name = \"{0}\"; Informational Version = \"{1}\"",
                assembly.FullName, FileVersionInfo.GetVersionInfo(assembly.Location).ProductVersion);
        }
    }
}
