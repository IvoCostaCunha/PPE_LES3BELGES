namespace gestionPriseCommande
{
    partial class menuPrincipal
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandesClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisirUneCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierCoordonnéesClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.commandesClientToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.produitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 41);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(98, 37);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(175, 38);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // commandesClientToolStripMenuItem
            // 
            this.commandesClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saisirUneCommandeToolStripMenuItem});
            this.commandesClientToolStripMenuItem.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandesClientToolStripMenuItem.Name = "commandesClientToolStripMenuItem";
            this.commandesClientToolStripMenuItem.Size = new System.Drawing.Size(226, 37);
            this.commandesClientToolStripMenuItem.Text = "Commandes Client";
            // 
            // saisirUneCommandeToolStripMenuItem
            // 
            this.saisirUneCommandeToolStripMenuItem.Name = "saisirUneCommandeToolStripMenuItem";
            this.saisirUneCommandeToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.saisirUneCommandeToolStripMenuItem.Text = "Saisir une commande ";
            this.saisirUneCommandeToolStripMenuItem.Click += new System.EventHandler(this.saisirUneCommandeToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechercherUnClientToolStripMenuItem,
            this.nouveauClientToolStripMenuItem,
            this.modifierCoordonnéesClientToolStripMenuItem});
            this.clientsToolStripMenuItem.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(99, 37);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // rechercherUnClientToolStripMenuItem
            // 
            this.rechercherUnClientToolStripMenuItem.Name = "rechercherUnClientToolStripMenuItem";
            this.rechercherUnClientToolStripMenuItem.Size = new System.Drawing.Size(379, 38);
            this.rechercherUnClientToolStripMenuItem.Text = "Rechercher un client";
            // 
            // nouveauClientToolStripMenuItem
            // 
            this.nouveauClientToolStripMenuItem.Name = "nouveauClientToolStripMenuItem";
            this.nouveauClientToolStripMenuItem.Size = new System.Drawing.Size(379, 38);
            this.nouveauClientToolStripMenuItem.Text = "Nouveau client";
            // 
            // modifierCoordonnéesClientToolStripMenuItem
            // 
            this.modifierCoordonnéesClientToolStripMenuItem.Name = "modifierCoordonnéesClientToolStripMenuItem";
            this.modifierCoordonnéesClientToolStripMenuItem.Size = new System.Drawing.Size(379, 38);
            this.modifierCoordonnéesClientToolStripMenuItem.Text = "Modifier coordonnées client";
            // 
            // produitToolStripMenuItem
            // 
            this.produitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechercherProduitToolStripMenuItem});
            this.produitToolStripMenuItem.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(102, 37);
            this.produitToolStripMenuItem.Text = "Produit";
            // 
            // rechercherProduitToolStripMenuItem
            // 
            this.rechercherProduitToolStripMenuItem.Name = "rechercherProduitToolStripMenuItem";
            this.rechercherProduitToolStripMenuItem.Size = new System.Drawing.Size(291, 38);
            this.rechercherProduitToolStripMenuItem.Text = "Rechercher produit";
            // 
            // menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 492);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.menuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandesClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisirUneCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherUnClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierCoordonnéesClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherProduitToolStripMenuItem;
    }
}