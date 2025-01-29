using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.IO;


namespace WebApp_27_1_2025
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }




        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    //string name = TextBox1.Text;

        //    //Label2.Text = "Hello, " + name + "!";

        //    // Write to a file

        //    string filePath = Server.MapPath("hani.txt"); // Search for this file that match this format. MapPath= match the file name

        //    File.WriteAllText(filePath , TextBox1.Text); //search for this file and write on it the data  //+ Environment.NewLine
        //    // File.write(file path , value)
        //}


        //protected void Button2_Click(object sender, EventArgs e)
        //{

        //    // Read from the file
        //    string fileContent = File.ReadAllText(@"C:\\Users\\Orange\\Desktop\\C--tasks-insite-works\\WebApp-27-1-2025\\hani.txt");
        //    Label2.Text = " (the data are : " + fileContent + ")";
        //}

        /////////////////////////////////////////////////////////////////////

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    string str = @"C:\Users\Orange\Desktop\Jas.txt";

        //    FileStream f1 = null;
        //    if (File.Exists(str))
        //    {
        //        using (f1 = File.Create(str))
        //        {

        //        }
        //    }
        //}

        ////////////////////////////////////////////////////

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    string str = @"C:\Users\Orange\Desktop\Jas1.txt";

        //    //FileStream f1 = null;

        //        // Create the file (this will overwrite it if it exists)


        //        using (File.Create(str))
        //        {

        //        }


        //}



        ///////////////////////////////////////
        //protected void Button21_Click(object sender, EventArgs e)
        //{
        //    string filePath = Server.MapPath("~/App_Data/data.txt");

        //    // Write to the file
        //    File.WriteAllText(filePath, TextBox1.Text);

        //    // Read from the file and display in a label
        //    Label1.Text = "File Content: " + File.ReadAllText(filePath);
        //}

        ///////////////////////////////////////////////


        //protected void ButtonLogin_Click(object sender, EventArgs e)
        //{
        //    string email = TextBoxEmail.Text;
        //    string name = TextBoxName.Text;
        //    string password = TextBoxPassword.Text;

        //    string filePath = Server.MapPath("hani.txt");

        //    // Check if the user exists in the file
        //    if (File.Exists(filePath))
        //    {
        //        string[] lines = File.ReadAllLines(filePath);
        //        foreach (string line in lines)
        //        {
        //            string[] userData = line.Split('/');
        //            if (userData[0] == email && userData[1] == name && userData[2] == password)
        //            {
        //                LabelMessage.Text = "Login successful!";
        //                LabelMessage.Visible = true
        //                    ;
        //                return;
        //            }
        //        }
        //    }

        //    // If user does not exist
        //    LabelMessage.Text = "Invalid email, name, or password!";
        //}

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

        }
    }
}
