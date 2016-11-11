namespace GUI_Hanoi
{
    partial class GUI_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.medioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.difícilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dificilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normasDelJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Torres = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_Botones = new System.Windows.Forms.Panel();
            this.btn_Deterner = new System.Windows.Forms.Button();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.panel_Movimientos = new System.Windows.Forms.Panel();
            this.lbl_Movimientos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel_Torres.SuspendLayout();
            this.panel_Botones.SuspendLayout();
            this.panel_Movimientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.solucionesToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Checked = true;
            this.opcionesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demoToolStripMenuItem,
            this.facilToolStripMenuItem1,
            this.medioToolStripMenuItem1,
            this.difícilToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.opcionesToolStripMenuItem.Text = "Nivel de Juego";
            // 
            // demoToolStripMenuItem
            // 
            this.demoToolStripMenuItem.Name = "demoToolStripMenuItem";
            this.demoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.demoToolStripMenuItem.Text = "Demo";
            // 
            // facilToolStripMenuItem1
            // 
            this.facilToolStripMenuItem1.Name = "facilToolStripMenuItem1";
            this.facilToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.facilToolStripMenuItem1.Text = "Facil";
            this.facilToolStripMenuItem1.Click += new System.EventHandler(this.facilToolStripMenuItem1_Click);
            // 
            // medioToolStripMenuItem1
            // 
            this.medioToolStripMenuItem1.Name = "medioToolStripMenuItem1";
            this.medioToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.medioToolStripMenuItem1.Text = "Medio";
            this.medioToolStripMenuItem1.Click += new System.EventHandler(this.medioToolStripMenuItem1_Click);
            // 
            // difícilToolStripMenuItem
            // 
            this.difícilToolStripMenuItem.Name = "difícilToolStripMenuItem";
            this.difícilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.difícilToolStripMenuItem.Text = "Difícil";
            this.difícilToolStripMenuItem.Click += new System.EventHandler(this.difícilToolStripMenuItem_Click);
            // 
            // solucionesToolStripMenuItem
            // 
            this.solucionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facilToolStripMenuItem,
            this.medioToolStripMenuItem,
            this.dificilToolStripMenuItem});
            this.solucionesToolStripMenuItem.Name = "solucionesToolStripMenuItem";
            this.solucionesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.solucionesToolStripMenuItem.Text = "Soluciones";
            // 
            // facilToolStripMenuItem
            // 
            this.facilToolStripMenuItem.Name = "facilToolStripMenuItem";
            this.facilToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.facilToolStripMenuItem.Text = "Facil";
            // 
            // medioToolStripMenuItem
            // 
            this.medioToolStripMenuItem.Name = "medioToolStripMenuItem";
            this.medioToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.medioToolStripMenuItem.Text = "Medio";
            // 
            // dificilToolStripMenuItem
            // 
            this.dificilToolStripMenuItem.Name = "dificilToolStripMenuItem";
            this.dificilToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.dificilToolStripMenuItem.Text = "Difícill";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.normasDelJuegoToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // normasDelJuegoToolStripMenuItem
            // 
            this.normasDelJuegoToolStripMenuItem.Name = "normasDelJuegoToolStripMenuItem";
            this.normasDelJuegoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.normasDelJuegoToolStripMenuItem.Text = "Normas del Juego";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // panel_Torres
            // 
            this.panel_Torres.BackColor = System.Drawing.SystemColors.Info;
            this.panel_Torres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Torres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Torres.Controls.Add(this.label5);
            this.panel_Torres.Controls.Add(this.label3);
            this.panel_Torres.Controls.Add(this.label4);
            this.panel_Torres.Location = new System.Drawing.Point(150, 38);
            this.panel_Torres.Name = "panel_Torres";
            this.panel_Torres.Size = new System.Drawing.Size(607, 362);
            this.panel_Torres.TabIndex = 1;
            this.panel_Torres.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Torres_Paint);
            this.panel_Torres.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Torres_MouseDown);
            this.panel_Torres.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Torres_MouseMove);
            this.panel_Torres.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Torres_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(457, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "III";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "I";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "II";
            // 
            // panel_Botones
            // 
            this.panel_Botones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Botones.Controls.Add(this.btn_Deterner);
            this.panel_Botones.Controls.Add(this.btn_Iniciar);
            this.panel_Botones.Location = new System.Drawing.Point(12, 38);
            this.panel_Botones.Name = "panel_Botones";
            this.panel_Botones.Size = new System.Drawing.Size(132, 190);
            this.panel_Botones.TabIndex = 2;
            // 
            // btn_Deterner
            // 
            this.btn_Deterner.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Deterner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deterner.Location = new System.Drawing.Point(27, 105);
            this.btn_Deterner.Name = "btn_Deterner";
            this.btn_Deterner.Size = new System.Drawing.Size(76, 23);
            this.btn_Deterner.TabIndex = 1;
            this.btn_Deterner.Text = "Detener";
            this.btn_Deterner.UseVisualStyleBackColor = false;
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Iniciar.Location = new System.Drawing.Point(27, 46);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(76, 23);
            this.btn_Iniciar.TabIndex = 0;
            this.btn_Iniciar.Text = "Iniciar";
            this.btn_Iniciar.UseVisualStyleBackColor = false;
            this.btn_Iniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_Movimientos
            // 
            this.panel_Movimientos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Movimientos.Controls.Add(this.lbl_Movimientos);
            this.panel_Movimientos.Controls.Add(this.label6);
            this.panel_Movimientos.Controls.Add(this.label2);
            this.panel_Movimientos.Location = new System.Drawing.Point(12, 234);
            this.panel_Movimientos.Name = "panel_Movimientos";
            this.panel_Movimientos.Size = new System.Drawing.Size(132, 166);
            this.panel_Movimientos.TabIndex = 3;
            // 
            // lbl_Movimientos
            // 
            this.lbl_Movimientos.AutoSize = true;
            this.lbl_Movimientos.Location = new System.Drawing.Point(89, 90);
            this.lbl_Movimientos.Name = "lbl_Movimientos";
            this.lbl_Movimientos.Size = new System.Drawing.Size(28, 13);
            this.lbl_Movimientos.TabIndex = 3;
            this.lbl_Movimientos.Text = "###";
            this.lbl_Movimientos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Movimientos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultado:";
            // 
            // GUI_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(765, 407);
            this.Controls.Add(this.panel_Movimientos);
            this.Controls.Add(this.panel_Botones);
            this.Controls.Add(this.panel_Torres);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Torres de Hanoi";
            this.Load += new System.EventHandler(this.GUI_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_Torres.ResumeLayout(false);
            this.panel_Torres.PerformLayout();
            this.panel_Botones.ResumeLayout(false);
            this.panel_Movimientos.ResumeLayout(false);
            this.panel_Movimientos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facilToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem medioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem difícilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solucionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dificilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Torres;
        private System.Windows.Forms.ToolStripMenuItem demoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normasDelJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Botones;
        private System.Windows.Forms.Button btn_Deterner;
        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.Panel panel_Movimientos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Movimientos;
        private System.Windows.Forms.Label label6;
    }
}

