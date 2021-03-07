using Ejercicio.BLL;
using Ejercicio.EE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            RefrescarXML();
        }

        private void RefrescarXML()
        {
            grillaPersona.DataSource = null;
            grillaPersona.DataSource = new PersonaBLL("Persona.xml").GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_serializar_Click(object sender, EventArgs e)
        {
            new PersonaBLL("Persona.xml").Save(new Persona { Id = Guid.NewGuid().ToString() , Nombre = txt_nombre_persona.Text.Trim()});
            RefrescarXML();
        }
    }
}
