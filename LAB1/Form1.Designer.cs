
namespace LAB1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lview = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LSEIntOrd = new System.Windows.Forms.Button();
            this.LDEInt = new System.Windows.Forms.Button();
            this.LSECInt = new System.Windows.Forms.Button();
            this.LDECInt = new System.Windows.Forms.Button();
            this.LDECabezaInt = new System.Windows.Forms.Button();
            this.LSECEli = new System.Windows.Forms.Button();
            this.LDECEli = new System.Windows.Forms.Button();
            this.LDECabezaEli = new System.Windows.Forms.Button();
            this.txtInLSE = new System.Windows.Forms.TextBox();
            this.txtlnlde = new System.Windows.Forms.TextBox();
            this.txtlnlsec = new System.Windows.Forms.TextBox();
            this.txtlnldec = new System.Windows.Forms.TextBox();
            this.txtlnldecCabeza = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxm7 = new System.Windows.Forms.ListView();
            this.txtboxele = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lview
            // 
            this.lview.HideSelection = false;
            this.lview.Location = new System.Drawing.Point(48, 315);
            this.lview.Name = "lview";
            this.lview.Size = new System.Drawing.Size(862, 296);
            this.lview.TabIndex = 1;
            this.lview.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista Simplemente Enlazada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista Doblemente Enlazada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lista Doblemente Enlazada Circular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lista Doblemente Enlazada Con Cabeza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lista Simplemente Enlazada Circular";
            // 
            // LSEIntOrd
            // 
            this.LSEIntOrd.Location = new System.Drawing.Point(546, 45);
            this.LSEIntOrd.Name = "LSEIntOrd";
            this.LSEIntOrd.Size = new System.Drawing.Size(75, 23);
            this.LSEIntOrd.TabIndex = 7;
            this.LSEIntOrd.Text = "Insertar";
            this.LSEIntOrd.UseVisualStyleBackColor = true;
            this.LSEIntOrd.Click += new System.EventHandler(this.LSEIntOrd_Click);
            // 
            // LDEInt
            // 
            this.LDEInt.Location = new System.Drawing.Point(546, 92);
            this.LDEInt.Name = "LDEInt";
            this.LDEInt.Size = new System.Drawing.Size(75, 23);
            this.LDEInt.TabIndex = 8;
            this.LDEInt.Text = "Insertar";
            this.LDEInt.UseVisualStyleBackColor = true;
            this.LDEInt.Click += new System.EventHandler(this.LDEInt_Click);
            // 
            // LSECInt
            // 
            this.LSECInt.Location = new System.Drawing.Point(546, 138);
            this.LSECInt.Name = "LSECInt";
            this.LSECInt.Size = new System.Drawing.Size(75, 23);
            this.LSECInt.TabIndex = 9;
            this.LSECInt.Text = "Insertar";
            this.LSECInt.UseVisualStyleBackColor = true;
            this.LSECInt.Click += new System.EventHandler(this.LSECInt_Click);
            // 
            // LDECInt
            // 
            this.LDECInt.Location = new System.Drawing.Point(546, 189);
            this.LDECInt.Name = "LDECInt";
            this.LDECInt.Size = new System.Drawing.Size(75, 23);
            this.LDECInt.TabIndex = 10;
            this.LDECInt.Text = "Insertar";
            this.LDECInt.UseVisualStyleBackColor = true;
            this.LDECInt.Click += new System.EventHandler(this.LDECInt_Click);
            // 
            // LDECabezaInt
            // 
            this.LDECabezaInt.Location = new System.Drawing.Point(546, 241);
            this.LDECabezaInt.Name = "LDECabezaInt";
            this.LDECabezaInt.Size = new System.Drawing.Size(75, 23);
            this.LDECabezaInt.TabIndex = 11;
            this.LDECabezaInt.Text = "Insertar";
            this.LDECabezaInt.UseVisualStyleBackColor = true;
            this.LDECabezaInt.Click += new System.EventHandler(this.LDECabezaInt_Click);
            // 
            // LSECEli
            // 
            this.LSECEli.Location = new System.Drawing.Point(655, 139);
            this.LSECEli.Name = "LSECEli";
            this.LSECEli.Size = new System.Drawing.Size(75, 23);
            this.LSECEli.TabIndex = 12;
            this.LSECEli.Text = "Eliminar";
            this.LSECEli.UseVisualStyleBackColor = true;
            this.LSECEli.Click += new System.EventHandler(this.LSECEli_Click);
            // 
            // LDECEli
            // 
            this.LDECEli.Location = new System.Drawing.Point(655, 190);
            this.LDECEli.Name = "LDECEli";
            this.LDECEli.Size = new System.Drawing.Size(75, 23);
            this.LDECEli.TabIndex = 13;
            this.LDECEli.Text = "Eliminar";
            this.LDECEli.UseVisualStyleBackColor = true;
            this.LDECEli.Click += new System.EventHandler(this.LDECEli_Click);
            // 
            // LDECabezaEli
            // 
            this.LDECabezaEli.Location = new System.Drawing.Point(655, 242);
            this.LDECabezaEli.Name = "LDECabezaEli";
            this.LDECabezaEli.Size = new System.Drawing.Size(75, 23);
            this.LDECabezaEli.TabIndex = 14;
            this.LDECabezaEli.Text = "Eliminar";
            this.LDECabezaEli.UseVisualStyleBackColor = true;
            this.LDECabezaEli.Click += new System.EventHandler(this.LDECabezaEli_Click);
            // 
            // txtInLSE
            // 
            this.txtInLSE.Location = new System.Drawing.Point(337, 45);
            this.txtInLSE.Name = "txtInLSE";
            this.txtInLSE.Size = new System.Drawing.Size(161, 20);
            this.txtInLSE.TabIndex = 15;
            // 
            // txtlnlde
            // 
            this.txtlnlde.Location = new System.Drawing.Point(337, 93);
            this.txtlnlde.Name = "txtlnlde";
            this.txtlnlde.Size = new System.Drawing.Size(161, 20);
            this.txtlnlde.TabIndex = 16;
            // 
            // txtlnlsec
            // 
            this.txtlnlsec.Location = new System.Drawing.Point(337, 139);
            this.txtlnlsec.Name = "txtlnlsec";
            this.txtlnlsec.Size = new System.Drawing.Size(161, 20);
            this.txtlnlsec.TabIndex = 17;
            // 
            // txtlnldec
            // 
            this.txtlnldec.Location = new System.Drawing.Point(337, 189);
            this.txtlnldec.Name = "txtlnldec";
            this.txtlnldec.Size = new System.Drawing.Size(161, 20);
            this.txtlnldec.TabIndex = 18;
            // 
            // txtlnldecCabeza
            // 
            this.txtlnldecCabeza.Location = new System.Drawing.Point(337, 242);
            this.txtlnldecCabeza.Name = "txtlnldecCabeza";
            this.txtlnldecCabeza.Size = new System.Drawing.Size(161, 20);
            this.txtlnldecCabeza.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(733, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mutiplos 7:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(748, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Elem:";
            // 
            // txtBoxm7
            // 
            this.txtBoxm7.HideSelection = false;
            this.txtBoxm7.Location = new System.Drawing.Point(810, 95);
            this.txtBoxm7.Name = "txtBoxm7";
            this.txtBoxm7.Size = new System.Drawing.Size(120, 20);
            this.txtBoxm7.TabIndex = 24;
            this.txtBoxm7.UseCompatibleStateImageBehavior = false;
            // 
            // txtboxele
            // 
            this.txtboxele.HideSelection = false;
            this.txtboxele.Location = new System.Drawing.Point(810, 246);
            this.txtboxele.Name = "txtboxele";
            this.txtboxele.Size = new System.Drawing.Size(121, 19);
            this.txtboxele.TabIndex = 25;
            this.txtboxele.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(942, 648);
            this.Controls.Add(this.txtboxele);
            this.Controls.Add(this.txtBoxm7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtlnldecCabeza);
            this.Controls.Add(this.txtlnldec);
            this.Controls.Add(this.txtlnlsec);
            this.Controls.Add(this.txtlnlde);
            this.Controls.Add(this.txtInLSE);
            this.Controls.Add(this.LDECabezaEli);
            this.Controls.Add(this.LDECEli);
            this.Controls.Add(this.LSECEli);
            this.Controls.Add(this.LDECabezaInt);
            this.Controls.Add(this.LDECInt);
            this.Controls.Add(this.LSECInt);
            this.Controls.Add(this.LDEInt);
            this.Controls.Add(this.LSEIntOrd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lview);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnInsentar;
        private System.Windows.Forms.Button btnInsertarOrdenado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListView listListaElementos;
        private System.Windows.Forms.ListView lview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button LSEIntOrd;
        private System.Windows.Forms.Button LDEInt;
        private System.Windows.Forms.Button LSECInt;
        private System.Windows.Forms.Button LDECInt;
        private System.Windows.Forms.Button LDECabezaInt;
        private System.Windows.Forms.Button LSECEli;
        private System.Windows.Forms.Button LDECEli;
        private System.Windows.Forms.Button LDECabezaEli;
        private System.Windows.Forms.TextBox txtInLSE;
        private System.Windows.Forms.TextBox txtlnlde;
        private System.Windows.Forms.TextBox txtlnlsec;
        private System.Windows.Forms.TextBox txtlnldec;
        private System.Windows.Forms.TextBox txtlnldecCabeza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView txtBoxm7;
        private System.Windows.Forms.ListView txtboxele;
    }
}

