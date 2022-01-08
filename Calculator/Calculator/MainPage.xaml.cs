using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnCommon_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (LabelView.Text == "0")
            {
                LabelView.Text = button.Text;
            }
            else
            {
                LabelView.Text += button.Text;
            }
        }

        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            LabelView.Text = "0";
        }

        private void BtnArtiBoluEksi_Clicked(object sender, EventArgs e)
        {
            /*Isaret Degistirme Islemi*/
        }

        private void BtnYuzde_Clicked(object sender, EventArgs e)
        {
            /*Yuzde Alma Islemi*/
        }

        private void BtnBolu_Clicked(object sender, EventArgs e)
        {
            /*Bolme Islemi*/
        }

        private void Btn7_Clicked(object sender, EventArgs e)
        {
            LabelView.Text = "7";
        }

        private void Btn8_Clicked(object sender, EventArgs e)
        {
            LabelView.Text = "8";
        }

        private void Btn9_Clicked(object sender, EventArgs e)
        {
            LabelView.Text = "9";
        }

        private void BtnX_Clicked(object sender, EventArgs e)
        {
            /*Carpma Islemi*/
        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {
            LabelView.Text = "4";
        }

        private void Btn5_Clicked(object sender, EventArgs e)
        {
            LabelView.Text = "5";
        }

        private void Btn6_Clicked(object sender, EventArgs e)
        {
            LabelView.Text = "6";
        }

        private void BtnEksi_Clicked(object sender, EventArgs e)
        {
            /*Cikarma Islemi*/
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            LabelView.Text = "1";
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            LabelView.Text = "2";
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            LabelView.Text = "3";
        }

        private void BtnArti_Clicked(object sender, EventArgs e)
        {
            /*Toplama Islemi*/
        }

        private void Btn0_Clicked(object sender, EventArgs e)
        {
            LabelView.Text = "0";
        }

        private void BtnVirgul_Clicked(object sender, EventArgs e)
        {
            /*Float Yapma Islemi*/
        }

        private void BtnEsittir_Clicked(object sender, EventArgs e)
        {
            /*Sonuc Islemi*/
        }
    }
}