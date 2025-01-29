//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using System.IO;
//using System.Text;
//namespace _27_1_2025
//{
//    public partial class AllBooks : System.Web.UI.Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {


//            string file = Server.MapPath("BooksData.txt");
//            string[] books = File.ReadAllLines(file);
//            StringBuilder row = new StringBuilder();

//            foreach (string book in books)
//            {

//                string[] Library = book.Split(' ');

//                row.Append("<tr>");
//                row.Append($"<td> {Library[0]} </td> ");
//                row.Append($"<td> {Library[1]} </td> ");
//                row.Append($"<td> {Library[2]} </td> ");
//                row.Append($"<td> {Library[3]} </td> ");
//                row.Append("</tr>");

//            }

//            TableBody.InnerHtml = row.ToString();




//        }
//    }
//}

using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _27_1_2025
{
    public partial class AllBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string file = Server.MapPath("BooksData.txt");
            if (File.Exists(file))
            {
                string[] books = File.ReadAllLines(file);
                StringBuilder row = new StringBuilder();

                foreach (string book in books)
                {
                    string[] Library = book.Split(' ');

                    row.Append("<tr>");
                    row.Append($"<td>{Library[0]}</td>");
                    row.Append($"<td>{Library[1]}</td>");
                    row.Append($"<td>{Library[2]}</td>");
                    row.Append($"<td>{Library[3]}</td>");
                    row.Append("</tr>");
                }

                TableBody.InnerHtml = row.ToString();
            }

        }




        protected void edit_Click(object sender, EventArgs e)
        {
            string bookIdInput = bookId.Text;
            string newBookName = bookName.Text;
            string newBookType = bookType.Text;
            string newBookLevel = bookLevel.Text;

            string filePath = Server.MapPath("BooksData.txt");

            if (File.Exists(filePath))
            {
                var fileContent = File.ReadAllLines(filePath);

                for (int i = 0; i < fileContent.Length; i++)
                {
                    string[] book = fileContent[i].Split(' ');
                    if (book[0] == bookIdInput)
                    {

                        //book[1] =bookId.Text; 
                        //book[2] =bookName.Text; 
                        //book[3] =bookLevel.Text; 

                        fileContent[i] = $"{book[0]} {newBookName} {newBookType} {newBookLevel}";
                        break;
                    }
                }
                File.WriteAllLines(filePath, fileContent);

               
            }
            else
            {
                res.Text = "Books file does not exist!";
                res.Visible = true;
            }
        }



        protected void search_Click(object sender, EventArgs e)
        {
            string bookIdInput = bookId.Text;
            string filePath = Server.MapPath("BooksData.txt");

            if (File.Exists(filePath))
            {
                string[] fileContent = File.ReadAllLines(filePath);

                foreach (string line in fileContent)
                {
                    string[] book = line.Split(' ');
                    if (book[0] == bookIdInput)
                    {
                        bookName.Text = book[1];
                        bookType.Text = book[2];
                        bookLevel.Text = book[3];
                        res.Text = "Book found!";
                        res.Visible = true;
                        return;
                    }
                }

                res.Text = "Book ID not found!";
                res.Visible = true;
            }
            else
            {
                res.Text = "Books file does not exist!";
                res.Visible = true;
            }
        }

      
    }
}



//string filePath = Server.MapPath("books.txt");
//if (File.Exists(filePath))
//{
//    var fileContent = File.ReadAllLines(filePath);

//    int count = 0;
//    foreach (var line in fileContent)
//    {

//        string[] book = line.Split(',');
//        string[] newBook = new string[book.Length];
//        if (book[0] == bookId.Text)
//        {
//            newBook[0] = book[0];
//            newBook[1] = bookName.Text;
//            newBook[2] = bookType.Text;
//            newBook[3] = bookLevel.Text;
//            fileContent[count] = $"{newBook[0]},{newBook[1]},{newBook[2]},{newBook[3]}";
//            break;
//        }
//        count++;

//    }
//    File.WriteAllLines(filePath, fileContent);