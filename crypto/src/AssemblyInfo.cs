using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
//using System.Security.Permissions;

//
// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle("BouncyCastle.Crypto")]
[assembly: AssemblyDescription("Bouncy Castle Cryptography API")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("The Legion of the Bouncy Castle Inc.")]
[assembly: AssemblyProduct("Bouncy Castle for .NET")]
[assembly: AssemblyCopyright("Copyright (C) 2000-2015")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers
// by using the '*' as shown below:

[assembly: AssemblyVersion("1.8.*")]

//
// In order to sign your assembly you must specify a key to use. Refer to the
// Microsoft .NET Framework documentation for more information on assembly signing.
//
// Use the attributes below to control which key is used for signing.
//
// Notes:
//   (*) If no key is specified, the assembly is not signed.
//   (*) KeyName refers to a key that has been installed in the Crypto Service
//       Provider (CSP) on your machine. KeyFile refers to a file which contains
//       a key.
//   (*) If the KeyFile and the KeyName values are both specified, the
//       following processing occurs:
//       (1) If the KeyName can be found in the CSP, that key is used.
//       (2) If the KeyName does not exist and the KeyFile does exist, the key
//           in the KeyFile is installed into the CSP and used.
//   (*) In order to create a KeyFile, you can use the sn.exe (Strong Name) utility.
//       When specifying the KeyFile, the location of the KeyFile should be
//       relative to the project output directory which is
//       %Project Directory%\obj\<configuration>. For example, if your KeyFile is
//       located in the project directory, you would specify the AssemblyKeyFile
//       attribute as [assembly: AssemblyKeyFile("..\\..\\mykey.snk")]
//   (*) Delay Signing is an advanced option - see the Microsoft .NET Framework
//       documentation for more information on this.
//

[assembly: CLSCompliant(true)]
#if !PCL
[assembly: ComVisible(false)]
#endif
// Start with no permissions
//[assembly: PermissionSet(SecurityAction.RequestOptional, Unrestricted=false)]
//...and explicitly add those we need

// see Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding.StrictLengthEnabledProperty
//[assembly: EnvironmentPermission(SecurityAction.RequestOptional, Read="Org.BouncyCastle.Pkcs1.Strict")]

internal class AssemblyInfo
{
    private static string version;
    public static string Version
    {
        get
        {
            if (version == null)
            {
#if NEW_REFLECTION
                var ver = (AssemblyVersionAttribute)typeof(AssemblyInfo).GetTypeInfo().Assembly.GetCustomAttributes(typeof(AssemblyVersionAttribute)).FirstOrDefault();
#else
                var ver = (AssemblyVersionAttribute)typeof(AssemblyInfo).Assembly.GetCustomAttributes(typeof(AssemblyVersionAttribute), false).FirstOrDefault();
#endif
                if (ver != null)
                {
                    version = ver.Version;
                }

                // if we're still here, then don't try again
                if (version == null)
                    version = string.Empty;
            }

            return version;
        }
        
    }
}
