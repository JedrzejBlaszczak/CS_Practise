using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace CHasz3
{
    public partial class Form1 : Form
    {
        private string slnPath;
        FolderBrowserDialog Fdb;
        public Form1()
        {
            slnPath = "";
            Fdb = new FolderBrowserDialog();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string findSln(string path)
        {
            string[] files = Directory.GetFiles(path, "*.sln");

            logBox.Refresh();
            if (files.Length== 0)
            {
                logBox.Text += "SLN NOT FOUND\n\n";
                return "";
            }
            logBox.Text += "SLN FOUND\n";
            logBox.Text += files[0] + "\n";
            return files[0];
        }

        private string findProj(string path)
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(path);

            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("Project"))
                {
                    break;
                }
            }
            int start = line.IndexOf(",") + 3;
            int end = line.IndexOf(".csproj") + 7;
            line = line.Substring(start, end-start);
            return line;
        }

        private List<string> findProjFiles(string path)
        {
            List<string> files = new List<string>();
            XmlDocument projDoc = new XmlDocument();
            projDoc.PreserveWhitespace = true;
            projDoc.Load(path);

            List<XmlNodeList> nodes = new List<XmlNodeList>();
            nodes.Add(projDoc.GetElementsByTagName("Compile"));
            nodes.Add(projDoc.GetElementsByTagName("EmbeddedResource"));
            nodes.Add(projDoc.GetElementsByTagName("None"));

            logBox.Text += "Project files: \n";
            foreach (XmlNodeList node in nodes)
            {
                foreach (XmlNode item in node)
                {
                    logBox.Text +=slnPath + "\\" + item.Attributes["Include"].Value + "\n";
                    files.Add(slnPath + "\\" + item.Attributes["Include"].Value);
                }
            }
            return files;
        }
      
        private void KowalskiAnalysis()
        {
            string csprojFile = "";
            string slnFile = findSln(slnPath);
            if (slnFile != "") {
               csprojFile = findProj(slnFile);
            };
            csprojFile = String.Concat(slnPath, "\\", csprojFile);
            logBox.Text += csprojFile + "\n\n";
            slnPath = slnFile.Substring(0, slnFile.Length - 4);
            List<string> Files = findProjFiles(csprojFile);
            copyProjFiles(Files);
        }

        static string ConvertStringArrayToString(string[] array)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
                builder.Append('\\');
            }

            return builder.ToString().Substring(0, builder.ToString().Length-1);
        }

        private void copyProjFiles(List<string> files)
        {
            string[] parentPaths;
            string parentPath;
            string temp;
            string copyDir = slnPath + "\\" + "Copy";
            Directory.CreateDirectory(copyDir);
            foreach (string file in files)
            {
                parentPaths = file.Split(Path.DirectorySeparatorChar);
                temp = ConvertStringArrayToString(parentPaths);
                parentPath =temp.Substring(0, temp.Length - parentPaths[parentPaths.Length-1].Length -1);
                if (!Directory.Exists(parentPath.Replace(slnPath, copyDir)))
                {
                    Directory.CreateDirectory(parentPath.Replace(slnPath, copyDir));
                }
                File.Copy(file, file.Replace(slnPath, copyDir));
            }
            logBox.Text += "\n\n COPY DIR: " + copyDir + "\n SUCCESS";

        }

        private void chooseFolder_Click(object sender, EventArgs e)
        {
            Fdb.ShowDialog();
            slnPath = Fdb.SelectedPath;
            logBox.Text += "Selected path: ";
            logBox.Text += slnPath;
            logBox.Text += "\n\n";
            KowalskiAnalysis();
        }

        private void logBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
