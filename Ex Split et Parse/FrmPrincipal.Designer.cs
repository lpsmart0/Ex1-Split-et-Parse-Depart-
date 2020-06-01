namespace Exemple_simple_Split_et_Parse
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreEntier = new System.Windows.Forms.TextBox();
            this.btnConvertirEnInt = new System.Windows.Forms.Button();
            this.vsiNombre1 = new VisualArrays.VisualCells.VisualInt();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConvertirEnDecimal = new System.Windows.Forms.Button();
            this.numNombre = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAjouter100AuTextBox = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.vsiNombre2 = new VisualArrays.VisualCells.VisualInt();
            this.btnAjouter100 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.vcaTabCar = new VisualArrays.VisualCharArray();
            this.viaMatrice = new VisualArrays.VisualIntArray();
            this.btnChargerListeB = new System.Windows.Forms.Button();
            this.txtListeB = new System.Windows.Forms.TextBox();
            this.viaTabNombre = new VisualArrays.VisualIntArray();
            this.btnChargerListeA = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtListeA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numNombre)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre entier\r\ndans un textbox:";
            // 
            // txtNombreEntier
            // 
            this.txtNombreEntier.Location = new System.Drawing.Point(26, 65);
            this.txtNombreEntier.Name = "txtNombreEntier";
            this.txtNombreEntier.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEntier.TabIndex = 1;
            this.txtNombreEntier.Text = "1234";
            // 
            // btnConvertirEnInt
            // 
            this.btnConvertirEnInt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvertirEnInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirEnInt.Location = new System.Drawing.Point(144, 36);
            this.btnConvertirEnInt.Name = "btnConvertirEnInt";
            this.btnConvertirEnInt.Size = new System.Drawing.Size(167, 23);
            this.btnConvertirEnInt.TabIndex = 2;
            this.btnConvertirEnInt.Text = "1: Convertir en int";
            this.btnConvertirEnInt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertirEnInt.UseVisualStyleBackColor = true;
            this.btnConvertirEnInt.Click += new System.EventHandler(this.btnConvertirEnInt_Click);
            // 
            // vsiNombre1
            // 
            this.vsiNombre1.FocusColor = System.Drawing.Color.Gray;
            this.vsiNombre1.Location = new System.Drawing.Point(333, 36);
            this.vsiNombre1.Maximum = 999999;
            this.vsiNombre1.Minimum = -999999;
            this.vsiNombre1.Name = "vsiNombre1";
            this.vsiNombre1.Size = new System.Drawing.Size(75, 23);
            this.vsiNombre1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "VisualInt";
            // 
            // btnConvertirEnDecimal
            // 
            this.btnConvertirEnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvertirEnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirEnDecimal.Location = new System.Drawing.Point(144, 65);
            this.btnConvertirEnDecimal.Name = "btnConvertirEnDecimal";
            this.btnConvertirEnDecimal.Size = new System.Drawing.Size(167, 23);
            this.btnConvertirEnDecimal.TabIndex = 5;
            this.btnConvertirEnDecimal.Text = "2: Convertir en Decimal";
            this.btnConvertirEnDecimal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertirEnDecimal.UseVisualStyleBackColor = true;
            this.btnConvertirEnDecimal.Click += new System.EventHandler(this.btnConvertirEnDecimal_Click);
            // 
            // numNombre
            // 
            this.numNombre.Location = new System.Drawing.Point(333, 67);
            this.numNombre.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numNombre.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numNombre.Name = "numNombre";
            this.numNombre.Size = new System.Drawing.Size(75, 20);
            this.numNombre.TabIndex = 6;
            this.numNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "NumericUpDown";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAjouter100AuTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.vsiNombre2);
            this.groupBox1.Controls.Add(this.btnAjouter100);
            this.groupBox1.Controls.Add(this.numNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombreEntier);
            this.groupBox1.Controls.Add(this.btnConvertirEnDecimal);
            this.groupBox1.Controls.Add(this.btnConvertirEnInt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.vsiNombre1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 167);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exercice Parse";
            // 
            // btnAjouter100AuTextBox
            // 
            this.btnAjouter100AuTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouter100AuTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter100AuTextBox.Location = new System.Drawing.Point(144, 123);
            this.btnAjouter100AuTextBox.Name = "btnAjouter100AuTextBox";
            this.btnAjouter100AuTextBox.Size = new System.Drawing.Size(167, 23);
            this.btnAjouter100AuTextBox.TabIndex = 11;
            this.btnAjouter100AuTextBox.Text = "4: Ajouter 100 à la zone de texte";
            this.btnAjouter100AuTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter100AuTextBox.UseVisualStyleBackColor = true;
            this.btnAjouter100AuTextBox.Click += new System.EventHandler(this.btnAjouter100AuTextBox_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "VisualInt";
            // 
            // vsiNombre2
            // 
            this.vsiNombre2.FocusColor = System.Drawing.Color.Gray;
            this.vsiNombre2.Location = new System.Drawing.Point(333, 94);
            this.vsiNombre2.Maximum = 999999;
            this.vsiNombre2.Minimum = -999999;
            this.vsiNombre2.Name = "vsiNombre2";
            this.vsiNombre2.Size = new System.Drawing.Size(75, 23);
            this.vsiNombre2.TabIndex = 9;
            // 
            // btnAjouter100
            // 
            this.btnAjouter100.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouter100.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter100.Location = new System.Drawing.Point(144, 94);
            this.btnAjouter100.Name = "btnAjouter100";
            this.btnAjouter100.Size = new System.Drawing.Size(167, 23);
            this.btnAjouter100.TabIndex = 8;
            this.btnAjouter100.Text = "3: Ajouter 100 au nombre";
            this.btnAjouter100.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter100.UseVisualStyleBackColor = true;
            this.btnAjouter100.Click += new System.EventHandler(this.btnAjouter100_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.vcaTabCar);
            this.groupBox2.Controls.Add(this.viaMatrice);
            this.groupBox2.Controls.Add(this.btnChargerListeB);
            this.groupBox2.Controls.Add(this.txtListeB);
            this.groupBox2.Controls.Add(this.viaTabNombre);
            this.groupBox2.Controls.Add(this.btnChargerListeA);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtListeA);
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 268);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exercice Split";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(411, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "ListeB: Max de 3 groupes séparée par un |\r\nUn groupe est formé d\'un caractère et " +
    "d\'un max de 4 nombres séparés par une virgule";
            // 
            // vcaTabCar
            // 
            this.vcaTabCar.BackColor = System.Drawing.Color.Black;
            this.vcaTabCar.CellSize = new System.Drawing.Size(50, 15);
            this.vcaTabCar.ColumnCount = 1;
            this.vcaTabCar.DefaultValue = ' ';
            this.vcaTabCar.Location = new System.Drawing.Point(187, 182);
            this.vcaTabCar.Name = "vcaTabCar";
            this.vcaTabCar.RowHeader.ForeColor = System.Drawing.Color.White;
            this.vcaTabCar.Size = new System.Drawing.Size(68, 73);
            this.vcaTabCar.SpecialValue = ' ';
            this.vcaTabCar.TabIndex = 7;
            this.vcaTabCar.Text = "visualCharArray1";
            // 
            // viaMatrice
            // 
            this.viaMatrice.BackColor = System.Drawing.Color.Black;
            this.viaMatrice.CellSize = new System.Drawing.Size(38, 15);
            this.viaMatrice.ColumnCount = 4;
            this.viaMatrice.Location = new System.Drawing.Point(261, 182);
            this.viaMatrice.Minimum = -100;
            this.viaMatrice.Name = "viaMatrice";
            this.viaMatrice.ReadOnly = true;
            this.viaMatrice.RowHeader.ForeColor = System.Drawing.Color.White;
            this.viaMatrice.Size = new System.Drawing.Size(185, 73);
            this.viaMatrice.SpecialValue = 0;
            this.viaMatrice.TabIndex = 6;
            this.viaMatrice.Text = "visualIntArray1";
            // 
            // btnChargerListeB
            // 
            this.btnChargerListeB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChargerListeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChargerListeB.Location = new System.Drawing.Point(26, 204);
            this.btnChargerListeB.Name = "btnChargerListeB";
            this.btnChargerListeB.Size = new System.Drawing.Size(146, 51);
            this.btnChargerListeB.TabIndex = 5;
            this.btnChargerListeB.Text = "6: Charger listeB";
            this.btnChargerListeB.UseVisualStyleBackColor = true;
            this.btnChargerListeB.Click += new System.EventHandler(this.btnChargerListeB_Click);
            // 
            // txtListeB
            // 
            this.txtListeB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListeB.Location = new System.Drawing.Point(26, 150);
            this.txtListeB.Name = "txtListeB";
            this.txtListeB.Size = new System.Drawing.Size(285, 23);
            this.txtListeB.TabIndex = 4;
            this.txtListeB.Text = "B,1,2,3|C,2,4,5,6|X,12,3";
            // 
            // viaTabNombre
            // 
            this.viaTabNombre.BackColor = System.Drawing.Color.Black;
            this.viaTabNombre.CellSize = new System.Drawing.Size(38, 20);
            this.viaTabNombre.ColumnCount = 10;
            this.viaTabNombre.Location = new System.Drawing.Point(178, 63);
            this.viaTabNombre.Minimum = -100;
            this.viaTabNombre.Name = "viaTabNombre";
            this.viaTabNombre.ReadOnly = true;
            this.viaTabNombre.RowCount = 1;
            this.viaTabNombre.RowHeader.ForeColor = System.Drawing.Color.White;
            this.viaTabNombre.Size = new System.Drawing.Size(443, 38);
            this.viaTabNombre.TabIndex = 2;
            this.viaTabNombre.Text = "visualIntArray1";
            // 
            // btnChargerListeA
            // 
            this.btnChargerListeA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChargerListeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChargerListeA.Location = new System.Drawing.Point(26, 63);
            this.btnChargerListeA.Name = "btnChargerListeA";
            this.btnChargerListeA.Size = new System.Drawing.Size(146, 38);
            this.btnChargerListeA.TabIndex = 3;
            this.btnChargerListeA.Text = "5: Charger listeA";
            this.btnChargerListeA.UseVisualStyleBackColor = true;
            this.btnChargerListeA.Click += new System.EventHandler(this.btnChargerListeA_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "viaTabNombre : Tableau de int";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "ListeA: nombres entiers (-100..100) séparés par une virgule";
            // 
            // txtListeA
            // 
            this.txtListeA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListeA.Location = new System.Drawing.Point(26, 37);
            this.txtListeA.Name = "txtListeA";
            this.txtListeA.Size = new System.Drawing.Size(285, 23);
            this.txtListeA.TabIndex = 0;
            this.txtListeA.Text = "1,22,33,41,56,66,71,81,-99,100";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 465);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercice Parse et Split -  ";
            ((System.ComponentModel.ISupportInitialize)(this.numNombre)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreEntier;
        private System.Windows.Forms.Button btnConvertirEnInt;
        private VisualArrays.VisualCells.VisualInt vsiNombre1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConvertirEnDecimal;
        private System.Windows.Forms.NumericUpDown numNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAjouter100;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChargerListeA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtListeA;
        private VisualArrays.VisualIntArray viaTabNombre;
        private System.Windows.Forms.Label label6;
        private VisualArrays.VisualCells.VisualInt vsiNombre2;
        private System.Windows.Forms.Button btnAjouter100AuTextBox;
        private System.Windows.Forms.TextBox txtListeB;
        private System.Windows.Forms.Label label7;
        private VisualArrays.VisualCharArray vcaTabCar;
        private VisualArrays.VisualIntArray viaMatrice;
        private System.Windows.Forms.Button btnChargerListeB;
    }
}

