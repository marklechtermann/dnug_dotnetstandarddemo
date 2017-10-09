using MyBusinessLayer;
using System;
using System.Windows.Forms;

namespace FormsDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            var swapi = new SwapiAccess();

            this.starshipBindingSource.DataSource = swapi.GetRandomStarship();
            //this.starshipBindingSource.ResetBindings(true);
        }
    }
}