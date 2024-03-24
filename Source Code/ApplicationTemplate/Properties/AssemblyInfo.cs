using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Labman Application Template")]
[assembly: AssemblyDescription("The base application template for Labman software applications")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Labman Automation Ltd")]
[assembly: AssemblyProduct("Labman Application Template")]
[assembly: AssemblyCopyright("Copyright ©Labman Automation Ltd 2019")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

//In order to begin building localizable applications, set 
//<UICulture>CultureYouAreCodingWith</UICulture> in your .csproj file
//inside a <PropertyGroup>.  For example, if you are using US english
//in your source files, set the <UICulture> to en-US.  Then uncomment
//the NeutralResourceLanguage attribute below.  Update the "en-US" in
//the line below to match the UICulture setting in the project file.

//[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]

[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
                                   ////(used if a resource is not found in the page, 
                                   //// or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly)] //where the generic resource dictionary is located
                                              ////(used if a resource is not found in the page, 
                                              //// app, or any theme specific resource dictionaries)

// ------------------------------------------------------------------------------------------------------
// Labman application versioning
//
//    Version 0.1 – Initial version under development
//    Version 0.2 – Pre-FAT
//    Version 0.3 – FAT
//    Version 0.4 – SAT
//    Version 1.0 – All SAT observations complete.
//
// Following the SAT the application version MUST be increment follow any changes.
// This is to be done similar to BaseApp e.g. 1.1 = minor change, 2.0 = major change
//
// The new version number must be included in the SVN comment when committing.
[assembly: AssemblyVersion("0.1.0.0")]
[assembly: AssemblyFileVersion("0.1.0.0")]
