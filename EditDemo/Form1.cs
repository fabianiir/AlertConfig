using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace EditDemo
{
    public partial class EditDemo : Form
    {
        private string ruta = "";
        XDocument documento = new XDocument();
        XContainer appSettings;
        List<KeyValuePair<string, string>> listaSettings = new List<KeyValuePair<string, string>>();
        public EditDemo()
        {
            InitializeComponent();
         
            //Cargar de XML
            ruta = @"C:\Program Files (x86)\Infosyst\DemoAlertC4\DemoEnviaAlertaC4.exe.config";
            documento = XDocument.Load(ruta);
            appSettings = documento.Element("configuration").Element("appSettings");
            listaSettings = listadoSettings();
            obtenerValores();
            
        
          

        }

        private void obtenerValores()
        {
            cbEstablecimiento.Text = listaSettings[0].Value;
            tbTipoEvento.Text = listaSettings[1].Value;
            tbTextoImprimir.Text = listaSettings[2].Value;
            tbNombreImpresora.Text = listaSettings[3].Value;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cambiarDatos();
        }

        private List<KeyValuePair<string, string>> listadoSettings()
        {
            List<KeyValuePair<string, string>> listado = new List<KeyValuePair<string, string>>();
            //Obtener valores de XML
            foreach (XElement xe in appSettings.Elements("add"))
            {

                string key = xe.Attribute("key").Value;
                string val = xe.Attribute("value").Value;

                listado.Add(new KeyValuePair<string, string>(key, val));

            }
            return listado;
        }

        private void cambiarDatos()
        {
            foreach (XElement setting in appSettings.Elements("add"))
            {
                if (listaSettings.Where(s => s.Key == setting.Attribute("key").Value) != null)
                {
                    setting.Attribute("value").Value = tbTextoImprimir.Text;
                }

                
            }
            documento.Save(@"C: \Users\consultor\Desktop\DemoEnviaAlertaC4.exe.config");
        }
    }
}

