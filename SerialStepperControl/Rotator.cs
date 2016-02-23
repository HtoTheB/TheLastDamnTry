using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialStepperControl
{
    public partial class Rotator : Form, ValidSender
    {
        double posX, posY, posZ, rotX, rotY, rotZ, rotS;

        double kugelRadius = 5;
        double inkreisRadius = 1.24;

        ComKartoffel myKartoffel;

        public Rotator()
        {
            InitializeComponent();
            posX = 0f;
            posY = 0f;
            posZ = 0f;
            
            myKartoffel = new ComKartoffel();

            label_Debug.Text += "Port opened: " + myKartoffel.init(this);
        }

        private void label_Return_Click(object sender, EventArgs e)
        {

        }

        private void SendMove_Click(object sender, EventArgs e)
        {
            rotX = Convert.ToDouble(textBox_X.Text);
            rotY = Convert.ToDouble(textBox_Y.Text);
            rotZ = Convert.ToDouble(textBox_Z.Text);
            rotS = Convert.ToDouble(textBox_S.Text);

            SendCom(rotX, rotY, rotZ, rotS);

            posX += rotX;
            posY += rotY;
            posZ += rotZ;

            label_CurPos.Text = posX.ToString() + " ; " + posY.ToString() + " ; " + posZ.ToString();
        }

        private void Button_Debug_Click(object sender, EventArgs e)
        {
            myKartoffel.sendCom(textBox_Debug.Text);
        }

        private void SendCom(double toMoveX, double toMoveY, double toMoveZ, double moveSpeed)
        {
            label_Debug.Text += myKartoffel.sendCom(
                Convert.ToInt32((toMoveX * (degCos(toMoveY) * Math.Sqrt((kugelRadius * kugelRadius) - (Math.Pow((inkreisRadius * degSin(toMoveY)), 2)))))),
                Convert.ToInt32((toMoveX * (degCos(toMoveY - 120) * Math.Sqrt((kugelRadius * kugelRadius) - (Math.Pow((inkreisRadius * degSin(toMoveY - 120)), 2)))))),
                Convert.ToInt32((toMoveX * (degCos(toMoveY + 120) * Math.Sqrt((kugelRadius * kugelRadius) - (Math.Pow((inkreisRadius * degSin(toMoveY + 120)), 2)))))),
                Convert.ToInt32(toMoveZ),
                Convert.ToInt32(moveSpeed));
        }

        public void PortDataReceived (string debugString)
        {
            //label_Return.Text += ("\n" + debugString);
        }

        #region myMath
        private double degSin(double a) { return Math.Sin(a * Math.PI / 180); }
        private double degCos(double a) { return Math.Cos(a * Math.PI / 180); }
        #endregion
    }
}