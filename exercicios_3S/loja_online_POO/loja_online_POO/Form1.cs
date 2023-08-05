using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loja_online_POO
{
    public partial class Form1 : Form
    {
        //declaração da classe para identificação do usuario
        Cliente identificacaoUser = new Cliente();
        //declaração de uma classe para nova tela
        Form2 tela2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            identificacaoUser.usuarioLogin = textBox1.Text;
        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            identificacaoUser.senhaLogin = textBox2.Text;
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            identificacaoUser.DadosUsuarios(textBox1.Text, textBox2.Text);
            if (string.IsNullOrEmpty(identificacaoUser.usuarioLogin) || string.IsNullOrEmpty(identificacaoUser.senhaLogin))
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            if (identificacaoUser.clienteAtivo == true)
            {
                MessageBox.Show("Login efetuado com sucesso vamos as compras!");
                // Abrir a nova janela do aplicativo
                tela2.Show();
                return;
            }
        }

        
    }
}
