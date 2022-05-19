﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'opticaDataSet.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.opticaDataSet.Usuario);
            load_combo_roles();
        }

        private void load_combo_roles()
        {
            comboBox1.DisplayMember = "Rol_Descripcion";
            comboBox1.ValueMember = "Rol_Codigo";
            comboBox1.DataSource = TrabajarUsuario.list_roles();
        }

       

       

      
    }
}
