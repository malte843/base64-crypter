using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            var input = txtEncryptIn.Text;
            try { 
                var encrypted = Crypter.Base64Encode(input);
                txtEncryptOut.Text = encrypted;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Crypter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            var input = txtDecryptIn.Text;

            try
            {
                var decrypted = Crypter.Base64Decode(input);
                txtDecryptOut.Text = decrypted;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Crypter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnCopyE_Click(object sender, EventArgs e)
        {
            var input = txtEncryptOut.Text;
            try
            {
                Clipboard.SetText(input);
            }
            catch (ArgumentException ex)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Crypter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopyD_Click(object sender, EventArgs e)
        {
            var input = txtDecryptOut.Text;
            try
            {
                Clipboard.SetText(input);
            }
            catch (ArgumentException ex)
            {
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Crypter", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
