using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Dog[] arrDog;
        Label[] arrName;
        PictureBox[] arrDogImage;
        Label[] arrLevel;
        Button[] arrFeeding;

        int i = 0;          //btnAdd_Click에서 사용

        public Form1()      //생성자 constructor
        {
            InitializeComponent();      //ui 설정 메소드

            int MAX = 3;

            this.arrDog = new Dog[MAX];
            this.arrName = new Label[MAX];
            this.arrDogImage = new PictureBox[MAX];
            this.arrLevel = new Label[MAX];
            this.arrFeeding = new Button[MAX];

            this.arrName[0] = lblName1;
            this.arrName[1] = lblName2;
            this.arrName[2] = lblName3;

            this.arrDogImage[0] = pbxDog1;
            this.arrDogImage[1] = pbxDog2;
            this.arrDogImage[2] = pbxDog3;

            this.arrLevel[0] = lblLevel1;
            this.arrLevel[1] = lblLevel2;
            this.arrLevel[2] = lblLevel3;

            this.arrFeeding[0] = btnFeed1;
            this.arrFeeding[1] = btnFeed2;
            this.arrFeeding[2] = btnFeed3;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(i < arrDog.Length)
            {
                arrDog[i] = new Dog(tbxName.Text);
                arrName[i].Visible = true;
                arrName[i].Text = arrDog[i].Name;
                arrDogImage[i].Visible = true;
                arrFeeding[i].Visible = true;
                arrLevel[i].Visible = true;
                arrLevel[i].Text = "Level " + arrDog[i].Level.ToString();
                i++;
            }
            else
            {
                lblMsg.Text = "안돼 저리 꺼정";
            }
        }

        private void btnFeed1_Click(object sender, EventArgs e)
        {
            if (arrDog[0] == null)
                return;

            arrDog[0].AddLevel();
            lblLevel1.Text = "Level " + arrDog[0].Level.ToString();

            if (arrDog[0].Level < 4)
            {
                arrDogImage[0].Image = Properties.Resources.dog1;
            }
            else if(arrDog[0].Level < 8)
            {
                arrDogImage[0].Image = Properties.Resources.dog2;
            }
            else
            {
                arrDogImage[0].Image = Properties.Resources.dog3;
            }
        }


        private  void btnFeed2_Click_1(object sender, EventArgs e)
        {
            if (arrDog[1] == null)
                return;

            arrDog[1].AddLevel();
            lblLevel2.Text = "Level " + arrDog[1].Level.ToString();

            if (arrDog[1].Level < 4)
            {
                arrDogImage[1].Image = Properties.Resources.dog1;
            }
            else if (arrDog[1].Level < 8)
            {
                arrDogImage[1].Image = Properties.Resources.dog2;
            }
            else
            {
                arrDogImage[1].Image = Properties.Resources.dog3;
            }
        }

        private void btnFeed3_Click(object sender, EventArgs e)
        {
            if (arrDog[2] == null)
                return;

            arrDog[2].AddLevel();
            lblLevel3.Text = "Level " + arrDog[2].Level.ToString();

            if (arrDog[2].Level < 4)
            {
                arrDogImage[2].Image = Properties.Resources.dog1;
            }
            else if (arrDog[2].Level < 8)
            {
                arrDogImage[2].Image = Properties.Resources.dog2;
            }
            else
            {
                arrDogImage[2].Image = Properties.Resources.dog3;
            }
        }

        private void lblLevel3_Click(object sender, EventArgs e)
        {

        }

        private void lblName2_Click(object sender, EventArgs e)
        {

        }

        private void lblName3_Click(object sender, EventArgs e)
        {

        }

        private void pbxDog2_Click(object sender, EventArgs e)
        {

        }

        private void pbxDog3_Click(object sender, EventArgs e)
        {

        }

        private void lblLevel2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pbxDog1_Click(object sender, EventArgs e)
        {

        }
    }
}
