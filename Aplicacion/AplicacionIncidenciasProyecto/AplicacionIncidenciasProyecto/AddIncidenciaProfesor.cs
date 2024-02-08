using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionIncidenciasProyecto
{
    public partial class AddIncidenciaProfesor : Form
    {
        
        public AddIncidenciaProfesor()
        {
            InitializeComponent();
            
        }

        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Si el nodo no tiene nodos secundarios, no hagas nada
            if (e.Node.Nodes.Count == 0)
                return;

            // Si el nodo está expandido, contraelo; si no, expándelo
            if (e.Node.IsExpanded)
                e.Node.Collapse();
            else
                e.Node.Expand();
        }
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
       
            this.Close();
          
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void grpIncidencia_Enter(object sender, EventArgs e)
        {

        }

        private void AddIncidenciaProfesor_Load(object sender, EventArgs e)
        {

        }
    }
}
