namespace eCommerce
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listViewProdotti = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewCarrello = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewProdotti
            // 
            this.listViewProdotti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewProdotti.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewProdotti.Location = new System.Drawing.Point(28, 12);
            this.listViewProdotti.MultiSelect = false;
            this.listViewProdotti.Name = "listViewProdotti";
            this.listViewProdotti.Size = new System.Drawing.Size(263, 426);
            this.listViewProdotti.TabIndex = 0;
            this.listViewProdotti.UseCompatibleStateImageBehavior = false;
            this.listViewProdotti.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Prodotti";
            this.columnHeader1.Width = 120;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem1.Text = "Metti nel carrello";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aggiungi al carrello";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listViewCarrello
            // 
            this.listViewCarrello.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listViewCarrello.Location = new System.Drawing.Point(513, 34);
            this.listViewCarrello.Name = "listViewCarrello";
            this.listViewCarrello.Size = new System.Drawing.Size(263, 404);
            this.listViewCarrello.TabIndex = 2;
            this.listViewCarrello.UseCompatibleStateImageBehavior = false;
            this.listViewCarrello.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(610, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "il tuo carrello";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prodotti";
            this.columnHeader2.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewCarrello);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewProdotti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listViewProdotti;
        private Button button1;
        private ListView listViewCarrello;
        private Label label1;
        private ColumnHeader columnHeader1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ColumnHeader columnHeader2;
    }
}