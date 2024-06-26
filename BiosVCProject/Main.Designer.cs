namespace BiosVCProject
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            barActions = new ToolStrip();
            btnAddNew = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            btnEditVersion = new ToolStripButton();
            toolTip1 = new ToolTip(components);
            listBiosVersions = new ListView();
            Fabriquant = new ColumnHeader();
            Modele = new ColumnHeader();
            Version = new ColumnHeader();
            Chemin = new ColumnHeader();
            barTop = new ToolStrip();
            toolFichier = new ToolStripButton();
            toolAction = new ToolStripButton();
            toolAffichage = new ToolStripButton();
            toolAide = new ToolStripDropDownButton();
            àProposToolStripMenuItem = new ToolStripMenuItem();
            debugOutput = new RichTextBox();
            groupBox1 = new GroupBox();
            barActions.SuspendLayout();
            barTop.SuspendLayout();
            SuspendLayout();
            // 
            // barActions
            // 
            barActions.ImageScalingSize = new Size(20, 20);
            barActions.Items.AddRange(new ToolStripItem[] { btnAddNew, toolStripSeparator1, btnDelete, btnEditVersion });
            barActions.Location = new Point(0, 27);
            barActions.Name = "barActions";
            barActions.RenderMode = ToolStripRenderMode.System;
            barActions.Size = new Size(800, 27);
            barActions.TabIndex = 2;
            barActions.Text = "toolStrip1";
            // 
            // btnAddNew
            // 
            btnAddNew.Image = (Image)resources.GetObject("btnAddNew.Image");
            btnAddNew.ImageTransparentColor = Color.Magenta;
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(82, 24);
            btnAddNew.Text = "Ajouter";
            btnAddNew.ToolTipText = "Ajouter une version";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnDelete
            // 
            btnDelete.Alignment = ToolStripItemAlignment.Right;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 24);
            btnDelete.Text = "Supprimer";
            btnDelete.ToolTipText = "Supprimer une version";
            // 
            // btnEditVersion
            // 
            btnEditVersion.Alignment = ToolStripItemAlignment.Right;
            btnEditVersion.Image = (Image)resources.GetObject("btnEditVersion.Image");
            btnEditVersion.ImageTransparentColor = Color.Magenta;
            btnEditVersion.Name = "btnEditVersion";
            btnEditVersion.Size = new Size(90, 24);
            btnEditVersion.Text = "Modifier";
            btnEditVersion.ToolTipText = "Modifier une version";
            // 
            // listBiosVersions
            // 
            listBiosVersions.BackColor = SystemColors.Window;
            listBiosVersions.Columns.AddRange(new ColumnHeader[] { Fabriquant, Modele, Version, Chemin });
            listBiosVersions.Dock = DockStyle.Fill;
            listBiosVersions.ForeColor = SystemColors.WindowText;
            listBiosVersions.FullRowSelect = true;
            listBiosVersions.GridLines = true;
            listBiosVersions.Location = new Point(0, 54);
            listBiosVersions.Name = "listBiosVersions";
            listBiosVersions.Size = new Size(800, 396);
            listBiosVersions.TabIndex = 1;
            listBiosVersions.UseCompatibleStateImageBehavior = false;
            listBiosVersions.View = View.Details;
            // 
            // Fabriquant
            // 
            Fabriquant.Text = "Fabriquant";
            Fabriquant.Width = 100;
            // 
            // Modele
            // 
            Modele.Text = "Modèle";
            Modele.Width = 100;
            // 
            // Version
            // 
            Version.Text = "Version";
            Version.Width = 100;
            // 
            // Chemin
            // 
            Chemin.Text = "Chemin";
            Chemin.Width = 496;
            // 
            // barTop
            // 
            barTop.ImageScalingSize = new Size(20, 20);
            barTop.Items.AddRange(new ToolStripItem[] { toolFichier, toolAction, toolAffichage, toolAide });
            barTop.Location = new Point(0, 0);
            barTop.Name = "barTop";
            barTop.RenderMode = ToolStripRenderMode.System;
            barTop.Size = new Size(800, 27);
            barTop.TabIndex = 1;
            barTop.Text = "toolStrip2";
            // 
            // toolFichier
            // 
            toolFichier.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolFichier.Image = (Image)resources.GetObject("toolFichier.Image");
            toolFichier.ImageTransparentColor = Color.Magenta;
            toolFichier.Name = "toolFichier";
            toolFichier.Size = new Size(56, 24);
            toolFichier.Text = "Fichier";
            // 
            // toolAction
            // 
            toolAction.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolAction.Image = (Image)resources.GetObject("toolAction.Image");
            toolAction.ImageTransparentColor = Color.Magenta;
            toolAction.Name = "toolAction";
            toolAction.Size = new Size(56, 24);
            toolAction.Text = "Action";
            // 
            // toolAffichage
            // 
            toolAffichage.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolAffichage.Image = (Image)resources.GetObject("toolAffichage.Image");
            toolAffichage.ImageTransparentColor = Color.Magenta;
            toolAffichage.Name = "toolAffichage";
            toolAffichage.Size = new Size(77, 24);
            toolAffichage.Text = "Affichage";
            // 
            // toolAide
            // 
            toolAide.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolAide.DropDownItems.AddRange(new ToolStripItem[] { àProposToolStripMenuItem });
            toolAide.Image = (Image)resources.GetObject("toolAide.Image");
            toolAide.ImageTransparentColor = Color.Magenta;
            toolAide.Name = "toolAide";
            toolAide.ShowDropDownArrow = false;
            toolAide.Size = new Size(44, 24);
            toolAide.Text = "Aide";
            // 
            // àProposToolStripMenuItem
            // 
            àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            àProposToolStripMenuItem.Size = new Size(224, 26);
            àProposToolStripMenuItem.Text = "À Propos";
            // 
            // debugOutput
            // 
            debugOutput.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            debugOutput.Location = new Point(541, 263);
            debugOutput.Name = "debugOutput";
            debugOutput.Size = new Size(259, 187);
            debugOutput.TabIndex = 3;
            debugOutput.Text = "";
            debugOutput.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(297, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(8, 8);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(debugOutput);
            Controls.Add(listBiosVersions);
            Controls.Add(barActions);
            Controls.Add(barTop);
            Name = "Main";
            ShowIcon = false;
            Text = "Bios Version Control Ver.1.0.0";
            barActions.ResumeLayout(false);
            barActions.PerformLayout();
            barTop.ResumeLayout(false);
            barTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip barActions;
        private ToolStripButton btnAddNew;
        private ToolStripButton btnDelete;
        private ToolStripButton btnEditVersion;
        private ToolTip toolTip1;
        private ListView listBiosVersions;
        private ColumnHeader Fabriquant;
        private ColumnHeader Modele;
        private ColumnHeader Version;
        private ColumnHeader Chemin;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStrip barTop;
        private ToolStripButton toolFichier;
        private ToolStripButton toolAction;
        private ToolStripButton toolAffichage;
        private ToolStripDropDownButton toolAide;
        private ToolStripMenuItem àProposToolStripMenuItem;
        private RichTextBox debugOutput;
        private GroupBox groupBox1;
    }
}
