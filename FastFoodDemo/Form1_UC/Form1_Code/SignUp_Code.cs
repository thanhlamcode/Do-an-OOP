using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FastFoodDemo.Form1_UC.Form1_Code
{
    internal class SignUp_Code : ISignUp
    {
        public void SignUp_ToWriteFile(string id, string username, string password)
        {
            string filename = "LoginData.txt";

            try
            {
                if (!File.Exists(filename))
                {
                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        sw.WriteLine($"{id},{username},{password},2");
                    }
                }
                else
                {
                    using (StreamWriter streamWriter = File.AppendText(filename))
                    {
                        streamWriter.WriteLine($"{id},{username},{password},2");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public bool Validate_SignUp(string id, string password)
        {
            string filename = "LoginData.txt";

            try
            {
                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] fields = line.Split(',');
                    if (id == fields[0])
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return true;
        }
    }
}
