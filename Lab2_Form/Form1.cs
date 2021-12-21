using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Form
{
    public partial class Form1 : Form
    {
        IContract Transposition = null;
        public Form1(Library.IContract transposition)
        {
            InitializeComponent();
            Transposition = transposition;
        }
        private int[] key = null;
        int operations = 0;
        public int[] SetKey(string k)
        {
            string[] _key = k.Split(' ');
            key = new int[_key.Length];

            for (int i = 0; i < _key.Length; i++)
                key[i] = Convert.ToInt32(_key[i]);
            return key;
        }
        bool btn = false;
        private void executeButton_Click(object sender, EventArgs e)
        {
            //SetKey(keyBox.Text);
            //string input = inputBox.Text;

            if (btn)
            {
                if (!encryptButton.Checked && !decryptButton.Checked && !wordCountButton.Checked && !upperButton.Checked)
                    MessageBox.Show("Выберите функцию!");
                try
                {
                    if (encryptButton.Checked)
                    {
                        outputBox.Text = Transposition.Encrypt(inputBox.Text, SetKey(keyBox.Text));
                        operations += 1;
                    }
                }
                catch (FaultException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    if (decryptButton.Checked)
                    {
                        outputBox.Text = Transposition.Decrypt(inputBox.Text, SetKey(keyBox.Text));
                        operations += 1;
                    }
                }
                catch (FaultException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (wordCountButton.Checked)
                {
                    outputBox.Text = Transposition.wordCount(inputBox.Text).ToString();
                    operations += 1;
                }
                if (upperButton.Checked)
                {
                    
                    outputBox.Text = Transposition.Upper(inputBox.Text);
                    operations += 1;}
                }
            else
                MessageBox.Show("Сначала заполните и сохраните информацию о данных!");
        }

        private void saveNameButton_Click(object sender, EventArgs e)
        {

            ChannelFactory<IContract> factory1 = new ChannelFactory<IContract>("transpositionHTTP");
            Library.IContract transposition1 = factory1.CreateChannel();
            btn = true;
            try
            {
                transposition1.SaveData(nameBox.Text, String.Join("", SetKey(keyBox.Text)), SetKey(keyBox.Text));
                var reply = new Reply();
                reply.Name = nameBox.Text;
                reply.Key = String.Join("", SetKey(keyBox.Text));
                reply.Time = DateTime.Now;
                string s = Transposition.GetReply(reply);
                MessageBox.Show(s);
                (sender as Control).Enabled = false;
            }
            catch (FaultException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void operationsButton_Click(object sender, EventArgs e)
        {
            //int s=0;
            //Transposition.SaveOperations(operations);
            //s = Transposition.GetOperations(nameBox.Text);
            //MessageBox.Show("s");
        }
    }
}
