using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FK_FileSystem
{
	class Program
	{
		static void Main(string[] args)
		{
			// Console.WriteLine( "dir " + arg[0]  );
			var app = new Program();
			app.CreateDirectory();
			Console.Read();
		}
		public void CreateDirectory()
		{
			var dirName = "TestFolder";
			//check directory exist before creating it:
			if (Directory.Exists(dirName))
			{
				Console.WriteLine("Dir '" + dirName + " 'exists");
			}
			else
			{
				Directory.CreateDirectory(dirName);
				Console.WriteLine("Create dir '" + dirName + "'");
			}

		}
	}
}
