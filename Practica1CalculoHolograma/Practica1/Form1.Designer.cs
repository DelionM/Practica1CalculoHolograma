namespace Practica1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.txtNeg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMayPos = new System.Windows.Forms.TextBox();
            this.txtSumPos = new System.Windows.Forms.TextBox();
            this.txtSumNeg = new System.Windows.Forms.TextBox();
            this.txtMayNeg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de numeros:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(191, 53);
            this.txtCantidad.MaxLength = 4;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(84, 25);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum.Enabled = false;
            this.txtNum.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(606, 49);
            this.txtNum.MaxLength = 4;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(75, 25);
            this.txtNum.TabIndex = 2;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            this.txtNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero a verificar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Positivos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(561, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Negativos";
            // 
            // txtPos
            // 
            this.txtPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.txtPos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPos.Enabled = false;
            this.txtPos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPos.Location = new System.Drawing.Point(95, 231);
            this.txtPos.MaxLength = 15;
            this.txtPos.Multiline = true;
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(262, 114);
            this.txtPos.TabIndex = 9;
            // 
            // txtNeg
            // 
            this.txtNeg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.txtNeg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNeg.Enabled = false;
            this.txtNeg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNeg.Location = new System.Drawing.Point(464, 231);
            this.txtNeg.MaxLength = 15;
            this.txtNeg.Multiline = true;
            this.txtNeg.Name = "txtNeg";
            this.txtNeg.Size = new System.Drawing.Size(274, 126);
            this.txtNeg.TabIndex = 10;
            this.txtNeg.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mayor Positivo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(166, 571);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Suma Positiva";
            // 
            // txtMayPos
            // 
            this.txtMayPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.txtMayPos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMayPos.Enabled = false;
            this.txtMayPos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMayPos.Location = new System.Drawing.Point(191, 527);
            this.txtMayPos.MaxLength = 4;
            this.txtMayPos.Name = "txtMayPos";
            this.txtMayPos.Size = new System.Drawing.Size(71, 22);
            this.txtMayPos.TabIndex = 13;
            // 
            // txtSumPos
            // 
            this.txtSumPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.txtSumPos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSumPos.Enabled = false;
            this.txtSumPos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumPos.Location = new System.Drawing.Point(194, 595);
            this.txtSumPos.MaxLength = 6;
            this.txtSumPos.Name = "txtSumPos";
            this.txtSumPos.Size = new System.Drawing.Size(71, 22);
            this.txtSumPos.TabIndex = 14;
            // 
            // txtSumNeg
            // 
            this.txtSumNeg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.txtSumNeg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSumNeg.Enabled = false;
            this.txtSumNeg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumNeg.Location = new System.Drawing.Point(575, 580);
            this.txtSumNeg.MaxLength = 7;
            this.txtSumNeg.Name = "txtSumNeg";
            this.txtSumNeg.Size = new System.Drawing.Size(79, 22);
            this.txtSumNeg.TabIndex = 18;
            // 
            // txtMayNeg
            // 
            this.txtMayNeg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.txtMayNeg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMayNeg.Enabled = false;
            this.txtMayNeg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMayNeg.Location = new System.Drawing.Point(575, 517);
            this.txtMayNeg.MaxLength = 5;
            this.txtMayNeg.Name = "txtMayNeg";
            this.txtMayNeg.Size = new System.Drawing.Size(79, 22);
            this.txtMayNeg.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(554, 556);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Suma Negativa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(545, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mayor Negativo";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(538, 54);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(56, 21);
            this.lblNo.TabIndex = 19;
            this.lblNo.Text = "No. 1:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(156)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 30);
            this.panel1.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(156)))), ((int)(((byte)(181)))));
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(3, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(279, 26);
            this.label9.TabIndex = 21;
            this.label9.Text = "Suna y Acomodo de Números";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Practica1.Properties.Resources.linea;
            this.pictureBox2.Location = new System.Drawing.Point(175, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(197)))), ((int)(((byte)(153)))));
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Enabled = false;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestart.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Image = global::Practica1.Properties.Resources.systemreboot_94645;
            this.btnRestart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestart.Location = new System.Drawing.Point(542, 100);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(145, 50);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Reinicio";
            this.btnRestart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(197)))), ((int)(((byte)(153)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = global::Practica1.Properties.Resources.ilustracoes_04_08_icon_icons_com_75474;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.Location = new System.Drawing.Point(370, 100);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 50);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Limpiar";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(197)))), ((int)(((byte)(153)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::Practica1.Properties.Resources.ana;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(194, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 50);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practica1.Properties.Resources.comp;
            this.pictureBox1.Location = new System.Drawing.Point(79, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Practica1.Properties.Resources.linea;
            this.pictureBox3.Location = new System.Drawing.Point(596, 53);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(105, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Practica1.Properties.Resources.comp;
            this.pictureBox4.Location = new System.Drawing.Point(448, 156);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(308, 350);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Practica1.Properties.Resources.linea;
            this.pictureBox5.Location = new System.Drawing.Point(175, 527);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(105, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Practica1.Properties.Resources.linea;
            this.pictureBox6.Location = new System.Drawing.Point(177, 595);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(105, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Practica1.Properties.Resources.linea;
            this.pictureBox7.Location = new System.Drawing.Point(563, 518);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(105, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 27;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Practica1.Properties.Resources.linea;
            this.pictureBox8.Location = new System.Drawing.Point(563, 580);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(105, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 28;
            this.pictureBox8.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(804, 629);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.txtSumNeg);
            this.Controls.Add(this.txtMayNeg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSumPos);
            this.Controls.Add(this.txtMayPos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNeg);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guardado de numeros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.TextBox txtNeg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMayPos;
        private System.Windows.Forms.TextBox txtSumPos;
        private System.Windows.Forms.TextBox txtSumNeg;
        private System.Windows.Forms.TextBox txtMayNeg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}

