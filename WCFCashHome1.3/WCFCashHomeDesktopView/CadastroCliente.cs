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
using System.Xml.Linq;
using System.Xml;
using WCFCashHomeDesktopView.Dados;

namespace WCFCashHomeDesktopView
{
    public partial class CadastroCliente : Form
    {
        string nome, email, cpf, dataNascimento, senha;

        public CadastroCliente()
        {
            InitializeComponent();
        }

        //Criação da variável para aplicação de Domínio diretório 
        String caminho = AppDomain.CurrentDomain.BaseDirectory;

        //Método Estático para caminho DadosXML
        public static string DadosXML(string caminho)
        {

            if (caminho.IndexOf("\\bin\\Debug") != 0)
            {
                caminho = caminho.Replace("\\bin\\Debug", "");
            }
            return caminho;
        }


        //Método para limpar todos os campos
        void LimparTextBox(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else if ((c is MaskedTextBox))
                    ((MaskedTextBox)c).Clear();
                else
                    LimparTextBox(c);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataSet Resultado = new DataSet())
                {
                    Resultado.ReadXml(DadosXML(caminho) + @"Dados\Clientes.xml");
                    if (Resultado.Tables.Count == 0)
                    {
                        Resultado.ReadXml(DadosXML(caminho) + @"Dados\Clientes.xml");
                    }
                    else
                    {
                        Resultado.WriteXml(DadosXML(caminho) + @"Dados\Clientes.xml", XmlWriteMode.IgnoreSchema);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Service1 sv = new Service1();
 
            nome = TextNome.Text;
            email = TextEmail.Text;
            dataNascimento = mTxtNascimento.Text;
            cpf = mTxtCpf.Text;
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
                LimparTextBox(this);

                Conta clienteConta = new Conta();
                clienteConta.EmailCliente = email;
                sv.InsertConta(clienteConta); 

            }
            else
            {
                MessageBox.Show(isOk);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Service1 sv = new Service1();

            nome = TextNome.Text;
            email = TextEmail.Text;
            dataNascimento = mTxtNascimento.Text;
            cpf = mTxtCpf.Text;
            senha = TextSenha.Text;

            Cliente cliente = new Cliente()
            {
                Nome = nome,
                Email = email,
                DataNascimento = dataNascimento,
                Cpf = cpf,
                Senha = senha
            };

           sv.ListarClientes(cliente);
            
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome, email, cpf, dataNascimento, senha;

            Service1 sv = new Service1();
            Cliente cliente = new Cliente();

            nome = TextNome.Text;
            email = TextEmail.Text;
            dataNascimento = mTxtNascimento.Text;
            cpf = mTxtCpf.Text;
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
            if (nome == null || nome.Trim().Equals(""))
            {
                return "Digite o campo nome";
            }
            if (nome.Length > 20)
            {
                return "Nome não pode possuir mais do que 20 caracteres";
            }
            if (email == null || email.Trim().Equals(""))
            { 
                return "Digite o campo email";
            }
            if (email.Length > 50)
            {
                return "Email não pode possuir mais do que 20 caracteres";
            }
            if (senha == null || senha.Trim().Equals(""))
            {
                return "Digite o campo senha";
            }
            if (cpf == null || cpf.Trim().Equals(""))
            {
                return "Digite o campo CPF";
            }
            if (dataNascimento == null || dataNascimento.Trim().Equals(""))
            {
                return "Digite o campo Data de Nascimento";
            }

            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (!(rg.IsMatch(email)))
            {
                return "Email Inválido!";
            }

            Regex exCpf = new Regex(@"^(\d{3}.\d{3}/.\d{3}-\d/{2})");
            if (!(exCpf.IsMatch(cpf)))
            {
                return "Cpf Inválido!";
            }

            Regex exNascimento = new Regex(@"^(\d{2}//\d{2}//\d{4})");
            if (!(exNascimento.IsMatch(dataNascimento)))
            {
                return "Data Nascimento Inválido!";
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
