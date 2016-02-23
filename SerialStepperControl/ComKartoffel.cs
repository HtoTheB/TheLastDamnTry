using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace SerialStepperControl
{
    class ComKartoffel
    {
        int nSpeed = 800;
        public SerialPort port { get;  private set; }
        private string receivedString;
        Rotator senderRot;

        public bool init(Rotator getSender)
        {
            senderRot = getSender;
            try
            {
                port = new SerialPort("COM4");
                port.Handshake = Handshake.None;
                port.BaudRate = 9600;
                port.DtrEnable = true;
                if (port.IsOpen == false) //if not open, open the port
                    port.Open();
                port.DataReceived += port_DataReceived;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string sendCom(int mov1, int mov2, int mov3, int mov4)
        {
                return sendCom(mov1, mov2, mov3, mov4, nSpeed);
        }

        public string sendCom(int mov1, int mov2, int mov3, int mov4, int speed)
        {
            if (port.IsOpen)
            {
                port.Write(mov1.ToString() + " ; " + mov2.ToString() + " ; " + mov3.ToString() + " ; " + mov4.ToString() + " - " + speed.ToString());
                return ("\n" + (mov1.ToString() + " ; " + mov2.ToString() + " ; " + mov3.ToString() + " ; " + mov4.ToString() + " - " + speed.ToString()));
            }
            else return "\n SendCom failed";
        }

        public string sendCom(string toSend)
        {
            if (port.IsOpen)
            {
                port.Write(toSend);
                return toSend;
            }
            else return "\n SendCom failed";
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            receivedString = port.ReadExisting();
            senderRot.PortDataReceived(receivedString);
            //(ValidSender)sender.PortDataReceived(receivedString);
            //Hier Empfangslogik hinzufügen
        }
    }
}