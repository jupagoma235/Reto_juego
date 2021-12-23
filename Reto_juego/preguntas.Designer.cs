using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reto_juego
{
    partial class Ingresar_preguntas
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btguardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Labelpreg = new System.Windows.Forms.Label();
            this.CheckBox4 = new System.Windows.Forms.CheckBox();
            this.CheckBox3 = new System.Windows.Forms.CheckBox();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Labnivel = new System.Windows.Forms.Label();
            this.Txpuntos = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bdpruebasofka1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdpruebasofka1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Btguardar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Labelpreg);
            this.groupBox1.Controls.Add(this.CheckBox4);
            this.groupBox1.Controls.Add(this.CheckBox3);
            this.groupBox1.Controls.Add(this.CheckBox2);
            this.groupBox1.Controls.Add(this.CheckBox1);
            this.groupBox1.Controls.Add(this.TextBox5);
            this.groupBox1.Controls.Add(this.TextBox4);
            this.groupBox1.Controls.Add(this.TextBox3);
            this.groupBox1.Controls.Add(this.TextBox2);
            this.groupBox1.Controls.Add(this.TextBox1);
            this.groupBox1.Location = new System.Drawing.Point(226, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(853, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregunta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "R/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "R/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "R/";
            // 
            // Btguardar
            // 
            this.Btguardar.Location = new System.Drawing.Point(-1, 212);
            this.Btguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btguardar.Name = "Btguardar";
            this.Btguardar.Size = new System.Drawing.Size(854, 48);
            this.Btguardar.TabIndex = 6;
            this.Btguardar.Text = "Guardar pregunta";
            this.Btguardar.UseVisualStyleBackColor = true;
            this.Btguardar.Click += new System.EventHandler(this.Btguardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "R/";
            // 
            // Labelpreg
            // 
            this.Labelpreg.AutoSize = true;
            this.Labelpreg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Labelpreg.Location = new System.Drawing.Point(37, 30);
            this.Labelpreg.Name = "Labelpreg";
            this.Labelpreg.Size = new System.Drawing.Size(24, 28);
            this.Labelpreg.TabIndex = 7;
            this.Labelpreg.Text = "1";
            // 
            // CheckBox4
            // 
            this.CheckBox4.AutoSize = true;
            this.CheckBox4.Location = new System.Drawing.Point(808, 167);
            this.CheckBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBox4.Name = "CheckBox4";
            this.CheckBox4.Size = new System.Drawing.Size(22, 21);
            this.CheckBox4.TabIndex = 8;
            this.CheckBox4.UseVisualStyleBackColor = true;
            this.CheckBox4.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // CheckBox3
            // 
            this.CheckBox3.AutoSize = true;
            this.CheckBox3.Location = new System.Drawing.Point(808, 133);
            this.CheckBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.Size(22, 21);
            this.CheckBox3.TabIndex = 7;
            this.CheckBox3.UseVisualStyleBackColor = true;
            this.CheckBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Location = new System.Drawing.Point(808, 102);
            this.CheckBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(22, 21);
            this.CheckBox2.TabIndex = 6;
            this.CheckBox2.UseVisualStyleBackColor = true;
            this.CheckBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(808, 70);
            this.CheckBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(22, 21);
            this.CheckBox1.TabIndex = 5;
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // TextBox5
            // 
            this.TextBox5.Location = new System.Drawing.Point(99, 166);
            this.TextBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(685, 26);
            this.TextBox5.TabIndex = 4;
            this.TextBox5.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(99, 132);
            this.TextBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(685, 26);
            this.TextBox4.TabIndex = 3;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(99, 100);
            this.TextBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(685, 26);
            this.TextBox3.TabIndex = 2;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(99, 68);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(685, 26);
            this.TextBox2.TabIndex = 1;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(64, 32);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(720, 26);
            this.TextBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(50, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nivel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(6, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Puntos";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Labnivel
            // 
            this.Labnivel.AutoSize = true;
            this.Labnivel.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold);
            this.Labnivel.ForeColor = System.Drawing.Color.Red;
            this.Labnivel.Location = new System.Drawing.Point(37, 75);
            this.Labnivel.Name = "Labnivel";
            this.Labnivel.Size = new System.Drawing.Size(107, 128);
            this.Labnivel.TabIndex = 3;
            this.Labnivel.Text = "0";
            this.Labnivel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Labnivel.TextChanged += new System.EventHandler(this.Labnivel_TextChanged);
            // 
            // Txpuntos
            // 
            this.Txpuntos.Location = new System.Drawing.Point(71, 227);
            this.Txpuntos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txpuntos.Name = "Txpuntos";
            this.Txpuntos.Size = new System.Drawing.Size(109, 26);
            this.Txpuntos.TabIndex = 5;
            this.Txpuntos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txpuntos.TextChanged += new System.EventHandler(this.Txpuntos_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Labnivel);
            this.groupBox2.Controls.Add(this.Txpuntos);
            this.groupBox2.Location = new System.Drawing.Point(31, 44);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(182, 265);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // Ingresar_preguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 352);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ingresar_preguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fomulario de ingreso de preguntas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdpruebasofka1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TextBox5;
        private TextBox TextBox4;
        private TextBox TextBox3;
        private TextBox TextBox2;
        private TextBox TextBox1;
        private Label label1;
        private Label label2;
        private Label Labnivel;
        private TextBox Txpuntos;
        private Button Btguardar;
        private Label label5;
        private Label Labelpreg;
        private CheckBox CheckBox4;
        private CheckBox CheckBox3;
        private CheckBox CheckBox2;
        private CheckBox CheckBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label7;
        private Label label3;
        private BindingSource bdpruebasofka1DataSetBindingSource;
       
    }
}