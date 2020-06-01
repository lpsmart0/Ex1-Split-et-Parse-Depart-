using System;
using System.Windows.Forms;

namespace Exemple_simple_Split_et_Parse
{
    /// <summary>
    /// Exemple démontrant l'utilisation des méthodes Parse() et Split()
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "Martin Louis-Philippe";
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO; 
        }

        #region Utilisation de la méthode Parse 
        //-----------------------------------------------------------------------------------                           
        private void btnConvertirEnInt_Click(object sender, EventArgs e)
        {
            //TODO 1: Copier le nombre écrit dans txtNombreEntier dans le contrôle vsiNombre1
            vsiNombre1.Value = int.Parse(txtNombreEntier.Text);

        }

        //-----------------------------------------------------------------------------------
        private void btnConvertirEnDecimal_Click(object sender, EventArgs e)
        {
            //TODO 2: Copier le nombre écrit dans txtNombreEntier dans le contrôle numNombre
            numNombre.Value = decimal.Parse(txtNombreEntier.Text);

        }

        //-----------------------------------------------------------------------------------
        private void btnAjouter100_Click(object sender, EventArgs e)
        {
            //TODO 3: Prendre le nombre écrit dans txtNombreEntier, lui ajouter 100 et le mémoriser dans le contrôle vsiNombre2
            vsiNombre2.Value = int.Parse(txtNombreEntier.Text) + 100;

        }

        //----------------------------------------------------------------------------------
        private void btnAjouter100AuTextBox_Click(object sender, EventArgs e)
        {
            //TODO 4 : Ajouter 100 au nombre écrit dans txtNombreEntier
            int nombre100 = int.Parse(txtNombreEntier.Text) + 100;
            txtNombreEntier.Text = nombre100.ToString();

        }
        #endregion

        #region Exemple d'utilisation de la méthode Split
        //---------------------------------------------------------------------------------
        private void btnChargerListeA_Click(object sender, EventArgs e)
        {
            //TODO 5: Charger les éléments de la listeA dans viaTabNombre
            //        Ajuster la longueur de viaTabNombre au nombre d'élèments de la ListeA
            //        ListeA: nombres entiers (-100..100) séparés par une virgule 
            string[] tabChiffre = txtListeA.Text.Split(',');
            viaTabNombre.ColumnCount = tabChiffre.Length;
            for (int i = 0; i < tabChiffre.Length; i++)
            {
                int nombre = int.Parse(tabChiffre[i]);

                if (nombre > viaTabNombre.Maximum)
                    nombre = viaTabNombre.Maximum;

                if (nombre < viaTabNombre.Minimum)
                    nombre = viaTabNombre.Minimum;

                viaTabNombre[i] = nombre;
            }


        }


        private void btnChargerListeB_Click(object sender, EventArgs e)
        {
            //TODO 6: Charger les éléments de la listeB dans vcaTabCar et la viaMatrice
            //        ListeB: composée de groupes séparés par un |
            //        Un groupe est formé d'un caractère et de nombres séparés par une virgule
            //       
            vcaTabCar.Clear();
            viaMatrice.Clear();

            string[] tabGroupe = txtListeB.Text.Split('|');
            for(int row = 0; row < tabGroupe.Length; row++)
            {
                string[] tabContenuGroupe = tabGroupe[row].Split(',');

                vcaTabCar[row] = tabContenuGroupe[0][0];

                for (int i = 1; i < tabContenuGroupe.Length; i++)
                    viaMatrice[row, i - 1] = int.Parse(tabContenuGroupe[i]);
            }
        }
        #endregion
    }
}
