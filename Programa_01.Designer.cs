namespace Projeto01
{
    partial class Programa_01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programa_01));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.textNota1 = new System.Windows.Forms.TextBox();
            this.textNota2 = new System.Windows.Forms.TextBox();
            this.textNota4 = new System.Windows.Forms.TextBox();
            this.textNota3 = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.textAprovado = new System.Windows.Forms.TextBox();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa 01";
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.buttonMenu.FlatAppearance.BorderSize = 2;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.buttonMenu.Location = new System.Drawing.Point(12, 459);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(75, 40);
            this.buttonMenu.TabIndex = 2;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.Color.Transparent;
            this.buttonFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFechar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.buttonFechar.FlatAppearance.BorderSize = 2;
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.buttonFechar.Location = new System.Drawing.Point(638, 459);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 40);
            this.buttonFechar.TabIndex = 3;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // textNota1
            // 
            this.textNota1.BackColor = System.Drawing.Color.Azure;
            this.textNota1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textNota1.ForeColor = System.Drawing.Color.DimGray;
            this.textNota1.Location = new System.Drawing.Point(218, 101);
            this.textNota1.Name = "textNota1";
            this.textNota1.Size = new System.Drawing.Size(120, 24);
            this.textNota1.TabIndex = 4;
            this.textNota1.Text = "Nota 1";
            this.textNota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNota1.Enter += new System.EventHandler(this.textNota1_Enter);
            this.textNota1.Leave += new System.EventHandler(this.textNota1_Leave);
            // 
            // textNota2
            // 
            this.textNota2.BackColor = System.Drawing.Color.Azure;
            this.textNota2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textNota2.ForeColor = System.Drawing.Color.DimGray;
            this.textNota2.Location = new System.Drawing.Point(384, 101);
            this.textNota2.Name = "textNota2";
            this.textNota2.Size = new System.Drawing.Size(120, 24);
            this.textNota2.TabIndex = 5;
            this.textNota2.Text = "Nota 2";
            this.textNota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNota2.Enter += new System.EventHandler(this.textNota2_Enter);
            this.textNota2.Leave += new System.EventHandler(this.textNota2_Leave);
            // 
            // textNota4
            // 
            this.textNota4.BackColor = System.Drawing.Color.Azure;
            this.textNota4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNota4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textNota4.ForeColor = System.Drawing.Color.DimGray;
            this.textNota4.Location = new System.Drawing.Point(384, 159);
            this.textNota4.Name = "textNota4";
            this.textNota4.Size = new System.Drawing.Size(120, 24);
            this.textNota4.TabIndex = 6;
            this.textNota4.Text = "Nota 4";
            this.textNota4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNota4.Enter += new System.EventHandler(this.textNota4_Enter);
            this.textNota4.Leave += new System.EventHandler(this.textNota4_Leave);
            // 
            // textNota3
            // 
            this.textNota3.BackColor = System.Drawing.Color.Azure;
            this.textNota3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textNota3.ForeColor = System.Drawing.Color.DimGray;
            this.textNota3.Location = new System.Drawing.Point(218, 159);
            this.textNota3.Name = "textNota3";
            this.textNota3.Size = new System.Drawing.Size(120, 24);
            this.textNota3.TabIndex = 7;
            this.textNota3.Text = "Nota 3";
            this.textNota3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNota3.Enter += new System.EventHandler(this.textNota3_Enter);
            this.textNota3.Leave += new System.EventHandler(this.textNota3_Leave);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.Color.Transparent;
            this.buttonCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.buttonCalcular.FlatAppearance.BorderSize = 2;
            this.buttonCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.buttonCalcular.Location = new System.Drawing.Point(269, 235);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(171, 40);
            this.buttonCalcular.TabIndex = 8;
            this.buttonCalcular.Text = "Calcular Media";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // textAprovado
            // 
            this.textAprovado.BackColor = System.Drawing.Color.LightBlue;
            this.textAprovado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textAprovado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textAprovado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.textAprovado.Location = new System.Drawing.Point(298, 427);
            this.textAprovado.Name = "textAprovado";
            this.textAprovado.Size = new System.Drawing.Size(120, 24);
            this.textAprovado.TabIndex = 9;
            this.textAprovado.Text = "Estado";
            this.textAprovado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textResultado
            // 
            this.textResultado.BackColor = System.Drawing.Color.LightBlue;
            this.textResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.textResultado.Location = new System.Drawing.Point(298, 380);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(120, 24);
            this.textResultado.TabIndex = 10;
            this.textResultado.Text = "Nota Final";
            this.textResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.label2.Location = new System.Drawing.Point(273, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Resultados";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.buttonClear.FlatAppearance.BorderSize = 2;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.buttonClear.Location = new System.Drawing.Point(638, 401);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 40);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Limpar";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Programa_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(725, 511);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.textAprovado);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textNota3);
            this.Controls.Add(this.textNota4);
            this.Controls.Add(this.textNota2);
            this.Controls.Add(this.textNota1);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Programa_01";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "None";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Programa_01_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Programa_01_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Programa_01_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.TextBox textNota1;
        private System.Windows.Forms.TextBox textNota2;
        private System.Windows.Forms.TextBox textNota4;
        private System.Windows.Forms.TextBox textNota3;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.TextBox textAprovado;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonClear;
    }
}