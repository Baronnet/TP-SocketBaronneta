using System;
using System.Windows.Forms;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace TP_Socket
{
    public partial class Form1 : Form
    {
        private Socket socket;
        private string texteEnv = "";
        private string texteRec = "";
        private string texteMessage = "";
        private TextBox textBoxReception;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (socket != null)
                {
                    MessageBox.Show("Le socket est déjà initialisé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPEndPoint iped = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 80);

                if (!socket.ConnectAsync(new SocketAsyncEventArgs { RemoteEndPoint = iped }))
                {
                    MessageBox.Show($"Erreur lors de la connexion au serveur : {socket.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Error)}", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    socket.Close();
                    socket = null;
                }
            }
            catch (SocketException se)
            {
                MessageBox.Show($"Erreur lors de la connexion au serveur : {se.Message}", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (socket != null && socket.Connected)
                {
                    socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 5000);

                    var messageEnvoi = Encoding.ASCII.GetBytes("GET /\r\n\r\n");
                    socket.Send(messageEnvoi);

                    textBox3.Text = Encoding.ASCII.GetString(messageEnvoi);
                }
                else
                {
                    MessageBox.Show("Le socket n'est pas initialisé ou n'est pas connecté.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SocketException se)
            {
                MessageBox.Show($"Erreur lors de l'envoi de données : {se.Message}", "Erreur d'envoi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRecevoir_Click(object sender, EventArgs e)
        {
            try
            {
                if (socket != null && socket.Connected)
                {
                    socket.ReceiveTimeout = 10000;

                    var messageRecu = new byte[1024];
                    int nbcarrecu = socket.Receive(messageRecu);
                    string texteRecu = Encoding.ASCII.GetString(messageRecu, 0, nbcarrecu);

                    this.textBoxReception.Text = $"Nombre de caractères reçus : {nbcarrecu}\n{texteRecu}";
                }
                else
                {
                    MessageBox.Show("Le socket n'est pas initialisé ou n'est pas connecté.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SocketException se)
            {
                if (se.SocketErrorCode == SocketError.TimedOut)
                {
                    MessageBox.Show("La réception a expiré. Aucune donnée reçue dans le délai imparti.", "Délai d'attente dépassé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Erreur lors de la réception de données : {se.Message}", "Erreur de réception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (socket != null)
                {
                    socket.Close();
                }
                else
                {
                    MessageBox.Show("Le socket n'est pas initialisé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SocketException se)
            {
                MessageBox.Show($"Erreur lors de la fermeture du socket : {se.Message}", "Erreur de fermeture", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            texteEnv = textBox1.Text;

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            texteRec = textBox2.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
         {

         }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            texteMessage = textBox3.Text;
        }

        
    }
}
