using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFCashHomeDesktopView.localhost;

namespace WCFCashHomeDesktopView
{
    public partial class CadastroCliente : Form
    {
        string nome, email, cpf, dataNascimento, senha;

        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Service1 sv = new Service1();
 
            nome = TextNome.Text;
            email = TextEmail.Text;
            dataNascimento = TextDT.Text;
            cpf = TextCpf.Text;
            senha = TextSenha.Text;

            string isOk = testaCamposView();

            if (isOk == "Campos Válidos")
            {
                Cliente cliente = new Cliente()
                {
                    Nome = nome,
                    Email = email,
                    DataNascimento = dataNascimento,
                    Cpf = cpf,
                    Senha = senha
                };

                string result = sv.InsertClient(cliente);
                MessageBox.Show(result);

                Conta clienteConta = new Conta();
                clienteConta.EmailCliente = email;
                sv.InsertConta(clienteConta); 
            }
            else
            {
                MessageBox.Show(isOk);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome, email, cpf, dataNascimento, senha;

            Service1 sv = new Service1();
            Cliente cliente = new Cliente();

            nome = TextNome.Text;
            email = TextEmail.Text;
            dataNascimento = TextDT.Text;
            cpf = TextCpf.Text;
            senha = TextSenha.Text;

            string isOk = testaCamposView();

            if (isOk == "Campos Válidos")
            {
                cliente.Nome = nome;
                cliente.Email = email;
                cliente.DataNascimento = dataNascimento;
                cliente.Cpf = cpf;
                cliente.Senha = senha;

                string result = sv.UpdateClient(cliente);
                MessageBox.Show(result); 
            }
            else
            {
                MessageBox.Show(isOk);
            }
        }

        private string testaCamposView()
        {
            if (nome == null || nome == "")
            {
                return "Digite o campo nome";
            }
            if (nome.Length > 20)
            {
                return "Nome não pode possuir mais do que 20 caracteres";
            }
            if (email == null || email == "")
            { 
                return "Digite o campo email";
            }
            if (email.Length > 50)
            {
                return "Email não pode possuir mais do que 20 caracteres";
            }
            if (senha == null || senha == "")
            {
                return "Digite o campo senha";
            }
            if (cpf == null || cpf == "")
            {
                return "Digite o campo CPF";
            }
            if (dataNascimento == null || dataNascimento == "")
            {
                return "Digite o campo Data de Nascimento";
            }

            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (!(rg.IsMatch(email)))
            {
                return "Email Inválido!";
            }
            return "Campos Válidos";
        }

        private void textBoxnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextEmail_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
