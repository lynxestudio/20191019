using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace HashApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void mnquit_Click(object sender, EventArgs e)
    {
	    Application.Exit();
    }

    private void btnApply_Click(object sender, EventArgs e)
    {
	    lbStatus.Text = string.Empty;
	    if(string.IsNullOrEmpty(txtText.Text))
	    {
		    lbStatus.Text = "Text to hash is empty !";
	    }
	    else
	    {
		    try
		    {
			string algorithm = null;
                    if(rbMd5.Checked)
                        algorithm = "MD5";
                    else
                        if(rbSha1.Checked)
                            algorithm = "SHA1";
                        else if (rbSha256.Checked)
                            algorithm = "SHA256";
                        else if (rbsha384.Checked)
                            algorithm = "SHA384";
                        else if(rbSha512.Checked)
                            algorithm = "SHA512";
                    txtOutput.Text = GetHashCode(txtText.Text,algorithm);

				
		    }catch(Exception ex)
			{
				lbStatus.Text = "There is a error! " + ex.Message;
			}
	    }

    }
    
    string GetHashCode(string text, string hashAlgorithm)
        {
            //create a byte array for string
            byte[] bytes = Encoding.Default.GetBytes(text);
            //create an instance of the hashing algorithm
            HashAlgorithm hash = HashAlgorithm.Create(hashAlgorithm);
            //obtain the hash code from HashAlgorithm by
            //using the compute hash method
            byte[] hashcode = hash.ComputeHash(bytes);
            var buffer = new StringBuilder();
            foreach (var element in hashcode)
            {
                buffer.AppendFormat("{0:X2}", element);
            }
            return buffer.ToString();
        }

}
