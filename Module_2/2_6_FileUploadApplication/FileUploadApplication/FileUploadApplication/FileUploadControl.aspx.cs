using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileUploadApplication
{
    public partial class FileUploadControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnImage_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("~/image/") + FileUpload1.FileName);
                Label3.Text = "Image Uploaded Successfully!!!";
                Image1.ImageUrl = @"~\image\" + FileUpload1.FileName;
            }
            else
            {
                Label3.Text = "Select image First !!";
            }
        }

        protected void btndoc_Click(object sender, EventArgs e)
        {
            string filePath = Path.GetFileName(FileUpload2.PostedFile.FileName);

            string fextn = Path.GetExtension(filePath);

            int size = FileUpload2.PostedFile.ContentLength;
            if (FileUpload2.HasFile)
            {
                if (fextn.ToLower() != ".doc" && fextn.ToLower() != ".docx")
                {
                    Label4.Text = "only doc and docx file is allowed";
                }
                else if(size < 1024)
                {
                    Label4.Text = "file should be less than 1mb.";
                }
                else
                {
                    FileUpload2.SaveAs(Server.MapPath("~/image/" + filePath));
                    Label4.Text = "file uploaded";
                }
            }
            else
            {
                Label4.Text = "please select file before uploading.";
            }
        }
    }
}