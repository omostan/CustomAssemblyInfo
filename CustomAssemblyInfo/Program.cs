using System;

namespace CustomAssemblyInfo
{
    using System.Reflection;

    using CustomAssemblyInfo.Properties;

    public class Program
    {
        private static void Main()
        {
            // Call this method here
            GetAssemblyInfo();
        }

        /// <summary>
        /// Get the specified attributes from the AssemblyInfo
        /// </summary>
        public static void GetAssemblyInfo()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(title + Environment.NewLine);
            Console.WriteLine("==================" + Environment.NewLine);
            Console.WriteLine($"Name: {author}" + Environment.NewLine);
            Console.WriteLine($"Company: {company}" + Environment.NewLine);
            Console.WriteLine($"Dept: {department}" + Environment.NewLine);
            Console.WriteLine($"App Description: {description}" + Environment.NewLine);
            Console.WriteLine($"Copyright: {copyright}" + Environment.NewLine);
            Console.WriteLine($"Version: {version}" + Environment.NewLine + Environment.NewLine);
            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }

        // Create a new instance of the CoreAssemblyInfo
        private static readonly CoreAssemblyInfo entryAssembly = new CoreAssemblyInfo(Assembly.GetEntryAssembly());

        // Retrieve the AssemblyInfo attributes
        private static readonly string author = entryAssembly.Author;
        private static readonly string title = entryAssembly.ProductTitle;
        private static readonly string company = entryAssembly.Company;
        private static readonly string department = entryAssembly.Department;
        private static readonly string copyright = entryAssembly.Copyright;
        private static readonly string version = entryAssembly.Version;
        private static readonly string description = entryAssembly.Description;
    }
}
