using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileNameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\\EnlivantProjects\\VS2015\\Scorecard2020\\src\\Scorecard.Web\\tempFolderForUploadedFiles\\Scorecard-Addison Place-2018-Q2.xlsx=636826207978303499";
            String FilePath = System.IO.Path.GetFullPath(path);
            String FileName = System.IO.Path.GetFileName(path);
            string FileName2 = FileName.Substring(0, FileName.IndexOf("="));

            string myFileName = @"";

        }
    }
}
