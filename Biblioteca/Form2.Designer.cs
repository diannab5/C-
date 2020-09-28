namespace Biblioteca
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaCarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaInFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tableAdapterManager1 = new Biblioteca.bazadateDataSetTableAdapters.TableAdapterManager();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optiuniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optiuniToolStripMenuItem
            // 
            this.optiuniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaCarteToolStripMenuItem,
            this.salveazaInFisierToolStripMenuItem});
            this.optiuniToolStripMenuItem.Name = "optiuniToolStripMenuItem";
            this.optiuniToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.optiuniToolStripMenuItem.Text = "Optiuni";
            // 
            // adaugaCarteToolStripMenuItem
            // 
            this.adaugaCarteToolStripMenuItem.Name = "adaugaCarteToolStripMenuItem";
            this.adaugaCarteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.adaugaCarteToolStripMenuItem.Text = "Adauga carte";
            this.adaugaCarteToolStripMenuItem.Click += new System.EventHandler(this.adaugaCarteToolStripMenuItem_Click);
            // 
            // salveazaInFisierToolStripMenuItem
            // 
            this.salveazaInFisierToolStripMenuItem.Name = "salveazaInFisierToolStripMenuItem";
            this.salveazaInFisierToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.salveazaInFisierToolStripMenuItem.Text = "Salveaza in fisier";
            this.salveazaInFisierToolStripMenuItem.Click += new System.EventHandler(this.salveazaInFisierToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(243, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista carti";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(78, 90);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(538, 282);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CartiTableAdapter = null;
            this.tableAdapterManager1.CititoriTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = Biblioteca.bazadateDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(708, 407);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optiuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaCarteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem salveazaInFisierToolStripMenuItem;
        private bazadateDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}