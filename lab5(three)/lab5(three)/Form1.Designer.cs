namespace lab5_three_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pBoxRec1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выбратьЦветПераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьПолеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.круглыйХолстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прямокутнийХолстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox11 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRec1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBoxRec1
            // 
            this.pBoxRec1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pBoxRec1.Location = new System.Drawing.Point(25, 63);
            this.pBoxRec1.Name = "pBoxRec1";
            this.pBoxRec1.Size = new System.Drawing.Size(512, 306);
            this.pBoxRec1.TabIndex = 0;
            this.pBoxRec1.TabStop = false;
            this.pBoxRec1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBoxRec1_MouseDown);
            this.pBoxRec1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBoxRec1_MouseMove);
            this.pBoxRec1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBoxRec1_MouseUp);
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
            this.menuStrip1.TabIndex = 1;
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
            // прямокутнийХолстToolStripMenuItem
            // 
            this.прямокутнийХолстToolStripMenuItem.Name = "прямокутнийХолстToolStripMenuItem";
            this.прямокутнийХолстToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.прямокутнийХолстToolStripMenuItem.Text = "Прямокутний холст";
            this.прямокутнийХолстToolStripMenuItem.Click += new System.EventHandler(this.прямокутнийХолстToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.textBox11.Location = new System.Drawing.Point(198, 23);
            this.textBox11.Name = "button1";
            this.textBox11.Size = new System.Drawing.Size(75, 23);
            this.textBox11.TabIndex = 2;
            this.textBox11.Text = "ОК";
            this.textBox11.UseVisualStyleBackColor = true;
            this.textBox11.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Размер пера";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.pBoxRec1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRec1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pBoxRec1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выбратьЦветПераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьПолеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem круглыйХолстToolStripMenuItem;
        private System.Windows.Forms.Button textBox11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem прямокутнийХолстToolStripMenuItem;
    }
}

