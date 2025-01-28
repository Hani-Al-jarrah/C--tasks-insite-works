using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApp_27_1_2025
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { }
              protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            string email = TextBoxEmail.Text;
            string name = TextBoxName.Text;
            string password = TextBoxPassword.Text;

            string filePath = Server.MapPath("hani.txt");

            // Check if the user already exists
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] userData = line.Split(',');
                    if (userData[0] == email)
                    {
                        LabelMessage.Text = "User already exists!";
                        return;
                    }
                }
            }

            // If the user doesn't exist, add them to the file
            File.AppendAllText(filePath, $"{email}/{name}/{password}" + Environment.NewLine);
            LabelMessage.Text = "User registered successfully!";
        }
    }
}