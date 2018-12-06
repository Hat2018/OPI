namespace lab5_three_
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выбратьЦветПераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьПолеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.круглыйХолстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pBoxCircl = new System.Windows.Forms.PictureBox();
            this.прямокутнийХолстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCircl)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Размер пера";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьЦветПераToolStripMenuItem,
            this.очиститьПолеToolStripMenuItem,
            this.круглыйХолстToolStripMenuItem,
            this.прямокутнийХолстToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выбратьЦветПераToolStripMenuItem
            // 
            this.выбратьЦветПераToolStripMenuItem.Name = "выбратьЦветПераToolStripMenuItem";
            this.выбратьЦветПераToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.выбратьЦветПераToolStripMenuItem.Text = "Выбрать цвет пера";
            this.выбратьЦветПераToolStripMenuItem.Click += new System.EventHandler(this.выбратьЦветПераToolStripMenuItem_Click);
            // 
            // очиститьПолеToolStripMenuItem
            // 
            this.очиститьПолеToolStripMenuItem.Name = "очиститьПолеToolStripMenuItem";
            this.очиститьПолеToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.очиститьПолеToolStripMenuItem.Text = "Очистить поле";
            this.очиститьПолеToolStripMenuItem.Click += new System.EventHandler(this.очиститьПолеToolStripMenuItem_Click);
            // 
            // круглыйХолстToolStripMenuItem
            // 
            this.круглыйХолстToolStripMenuItem.Name = "круглыйХолстToolStripMenuItem";
            this.круглыйХолстToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.круглыйХолстToolStripMenuItem.Text = "Круглый холст";
            this.круглыйХолстToolStripMenuItem.Click += new System.EventHandler(this.круглыйХолстToolStripMenuItem_Click);
            // 
            // pBoxCircl
            // 
            this.pBoxCircl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pBoxCircl.Location = new System.Drawing.Point(15, 73);
            this.pBoxCircl.Name = "pBoxCircl";
            this.pBoxCircl.Size = new System.Drawing.Size(608, 500);
            this.pBoxCircl.TabIndex = 9;
            this.pBoxCircl.TabStop = false;
            this.pBoxCircl.Click += new System.EventHandler(this.pBoxCircl_Click);
            this.pBoxCircl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBoxCircl_MouseDown);
            this.pBoxCircl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBoxCircl_MouseMove);
            this.pBoxCircl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBoxCircl_MouseUp);
            // 
            // прямокутнийХолстToolStripMenuItem
            // 
            this.прямокутнийХолстToolStripMenuItem.Name = "прямокутнийХолстToolStripMenuItem";
            this.прямокутнийХолстToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.прямокутнийХолстToolStripMenuItem.Text = "Прямокутний холст";
            this.прямокутнийХолстToolStripMenuItem.Click += new System.EventHandler(this.прямокутнийХолстToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pBoxCircl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCircl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выбратьЦветПераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьПолеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem круглыйХолстToolStripMenuItem;
        private System.Windows.Forms.PictureBox pBoxCircl;
        private System.Windows.Forms.ToolStripMenuItem прямокутнийХолстToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}