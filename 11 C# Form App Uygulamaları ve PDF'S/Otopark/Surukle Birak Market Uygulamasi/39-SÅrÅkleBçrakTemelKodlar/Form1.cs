using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _39_SürükleBırakTemelKodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool sürüklemeDurumu = false;
        Point ilkKonum,tıklananBtnPoint;
        int btnIlkLeft;

        Button tıklananBtn;
        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            tıklananBtn = (Button)sender;
            sürüklemeDurumu = true;
            ilkKonum = e.Location;
            tıklananBtnPoint = tıklananBtn.Location;
            btnIlkLeft = tıklananBtn.Left;
            tıklananBtn.Cursor = Cursors.NoMove2D;
        }

        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            tıklananBtn = (Button)sender;
            this.Text = e.Location.X + "-" + e.Location.Y;
            if (sürüklemeDurumu == true)
            {
                tıklananBtn.Left = e.X + (tıklananBtn.Left - ilkKonum.X);
                tıklananBtn.Top = e.Y + (tıklananBtn.Top - ilkKonum.Y);
            }
        }
        Point ürünbaslangıçkonum = new Point(410,60);
        int butonno = 0;
        void btnUret()
        {
            Button btn = new Button();
            btn.Name = "b"+butonno.ToString();
            btn.Text = "5";
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.BackgroundImage = tıklananBtn.BackgroundImage;
            butonno++;
            btn.Location = ürünbaslangıçkonum;
            ürünbaslangıçkonum = new Point(ürünbaslangıçkonum.X + 70, ürünbaslangıçkonum.Y );
            if (butonno%5==0)
            {
                ürünbaslangıçkonum.Y += 60;
                ürünbaslangıçkonum.X = 410;
            }
            btn.Size=new Size(70,60);
            btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            this.Controls.Add(btn);


            

        }
        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            tıklananBtn = (Button)sender;
            sürüklemeDurumu = false;
            tıklananBtn.Cursor = Cursors.Default;
            if (btnIlkLeft < btnDuvar.Left&&tıklananBtn.Left > btnDuvar.Left)
            {
                textBox1.Text = (int.Parse(textBox1.Text) + 5).ToString();
                btnUret();
                tıklananBtn.Location = tıklananBtnPoint;

            }
            else if (btnIlkLeft > btnDuvar.Left && tıklananBtn.Left < btnDuvar.Left)
            {
                textBox1.Text = (int.Parse(textBox1.Text) - 5).ToString();
                this.Controls.RemoveByKey(tıklananBtn.Name);
               
               
            }
            else
            {
                tıklananBtn.Location = tıklananBtnPoint;
            }
           
            
           
        }

       

        
    }
}
