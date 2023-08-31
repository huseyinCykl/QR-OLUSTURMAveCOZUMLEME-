using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace QR_Sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCodeEncoder enc = new QRCodeEncoder();
            pictureBox1.Image = enc.Encode(TxtMetin.Text);            
        }

        private void BtnCozumle_Click(object sender, EventArgs e)
        {
            QRCodeDecoder dnc = new QRCodeDecoder();
            TxtMetin.Text=dnc.Decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap));
        }
    }
}
