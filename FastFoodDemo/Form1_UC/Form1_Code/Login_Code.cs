using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FastFoodDemo.Form1_UC.Form1_Code
{
    internal class Login_Code : ILogin
    {
        public bool Validate_Login(string id, string password)
        {
            string filename = "LoginData.txt";

            try
            {
                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] fields = line.Split(',');
                    if (id == fields[0] && password == fields[2])
                    {
                        Form2.token = line;
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return false;
        }

        public void Write_ToLoginHistory(string id)
        {
            string filename = "LoginHistory.txt";
            string loginfile = "LoginData.txt";
            string username = String.Empty;

            try
            {
                using (StreamReader sr = new StreamReader(loginfile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] words = line.Split(',');
                        if (words[0] == id)
                        {
                            username = words[1];
                            break;
                        }
                    }
                }
                using (StreamWriter streamWriter = File.AppendText(filename))
                {
                    streamWriter.WriteLine($"{id},{username},{DateTime.Now}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
