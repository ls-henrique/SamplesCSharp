using SampleCSharp.Overview.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SampleCSharp.Overview
{
    public partial class Form1 : Form
    {
        private List<Usuario> Usuarios;
        private List<string> Generos;

        public Form1()
        {
            this.Usuarios = new List<Usuario> {
                new Usuario{ Id = 1, NomeCompleto = "Stephanye", Idade= 18, Genero = "Feminino" },
                new Usuario{ Id = 2, NomeCompleto = "Brenda Borba", Idade= 18, Genero = "Feminino" },
                new Usuario{ Id = 3, NomeCompleto = "Matheus Soares", Idade= 18, Genero = "Masculino" },
                new Usuario{ Id = 4, NomeCompleto = "Douglas Barboso", Idade= 18, Genero = "Masculino" },
                new Usuario{ Id = 5, NomeCompleto = "Henrique Vitorino", Idade= 18, Genero = "Masculino" }
            };

            this.Generos = new List<string> { "Masculino", "Feminino", "Outros" };

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = this.Usuarios;
            this.comboBoxGenero.DataSource = this.Generos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newUsuario = new Usuario
            {
                Id = Convert.ToInt32(this.textBoxId.Text),
                NomeCompleto = this.textBoxNome.Text,
                Genero = this.comboBoxGenero.Text,
                Idade = Convert.ToInt32(this.numericUpDownIdade.Value)
            };

            this.Usuarios.Add(newUsuario);

            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.Usuarios;
        }
    }
}
