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


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataSet Resultado = new DataSet())
                {
                    Resultado.ReadXml(DadosXML(caminho) + @"Dados\Clientes.xml");
                    Service1 sv = new Service1();

                    nome = TextNome.Text;
                    email = TextEmail.Text;
                    dataNascimento = mTxtNascimento.Text;
                    cpf = mTxtCpf.Text;
                    senha = TextSenha.Text;

                    string isOk = testaCamposView();
                    if (Resultado.Tables.Count == 0)
                    {

                        if (isOk == "Campos Válidos")
                        {
                            //Instaciamento da Classe
                            Cliente cliente = new Cliente()
                            {
                                Nome = nome,
                                Email = email,
                                DataNascimento = dataNascimento,
                                Cpf = cpf,
                                Senha = senha
                            };
                            //Atribuindo valores as propriedades
                            XmlTextWriter writer = new XmlTextWriter(DadosXML(caminho) + @"Dados\Clientes.xml", System.Text.Encoding.UTF8);
                            writer.WriteStartDocument(true);
                            writer.Formatting = Formatting.Indented;
                            writer.Indentation = 2;
                            writer.WriteStartElement("Clientes");

                            writer.WriteStartElement("Cliente");

                            writer.WriteStartElement("Nome");
                            writer.WriteString(nome.ToString());
                            writer.WriteEndElement();

                            writer.WriteStartElement("Email");
                            writer.WriteString(email.ToString());
                            writer.WriteEndElement();

                            writer.WriteStartElement("Nascimento");
                            writer.WriteString(dataNascimento.ToString());
                            writer.WriteEndElement();

                            writer.WriteStartElement("Cpf");
                            writer.WriteString(cpf.ToString());
                            writer.WriteEndElement();

                            writer.WriteEndElement();
                            writer.WriteEndDocument();
                            writer.Close();
                            string result = sv.InsertClient(cliente);
                            MessageBox.Show(result);

                            Conta clienteConta = new Conta();
                            clienteConta.EmailCliente = email;
                            sv.InsertConta(clienteConta);
                            LimparTextBox(this);
                        }
                        else{
                            MessageBox.Show(isOk);
                        }

                    }else
                    {
                        //incluindo dados no DataSet
                        Resultado.Tables[0].Rows.Add(Resultado.Tables[0].NewRow());
                        Resultado.Tables[0].Rows[Resultado.Tables[0].Rows.Count - 1]["Nome"] = TextNome.Text;
                        Resultado.Tables[0].Rows[Resultado.Tables[0].Rows.Count - 1]["Email"] = TextEmail.Text;
                        Resultado.Tables[0].Rows[Resultado.Tables[0].Rows.Count - 1]["Nascimento"] = mTxtNascimento.Text;
                        Resultado.Tables[0].Rows[Resultado.Tables[0].Rows.Count - 1]["Cpf"] = mTxtCpf.Text;
                        Resultado.AcceptChanges();
                        //Escreve para o arquivo XML final usando o método Write
                        Resultado.WriteXml(DadosXML(caminho) + @"Dados\Clientes.xml", XmlWriteMode.IgnoreSchema);
                    }
              }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {

                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Botão Limpar todos os dados
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTextBox(this);
        }

        private string testaCamposView()
        {
            if (nome == null || nome.Trim().Equals(""))
            {
                return "Digite o campo nome";
            }
            if (nome.Length > 20)
            {
                return "Nome não pode possuir mais do que 50 caracteres";
            }
            if (email == null || email.Trim().Equals(""))
            { 
                return "Digite o campo email";
            }
            if (email.Length > 50)
            {
                return "Email não pode possuir mais do que 50 caracteres";
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

            Regex ver = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (!(ver.IsMatch(email)))
            {
                return "Email Inválido!";
            }

            Regex exCpf = new Regex(@"^(\d{3}.\d{3}/.\d{3}-\d/{2})");
            if (!(exCpf.IsMatch(mTxtCpf.Text)))
            {
               return "Cpf inválido";     
      
            }

            Regex exNascimento = new Regex(@"^(\d{2}/\d{2}/\d{4})");

            if (!(exNascimento.IsMatch(mTxtNascimento.Text)))
            {
                return "Data Nascimento inválido";
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
