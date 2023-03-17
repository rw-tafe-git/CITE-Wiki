namespace CITEWiki
{
    partial class FormCITEWiki
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
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.ColumnHeader();
            this.CategoryLabel = new System.Windows.Forms.ColumnHeader();
            this.ListViewProperties = new System.Windows.Forms.ListView();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxCategory = new System.Windows.Forms.TextBox();
            this.TextBoxDefinition = new System.Windows.Forms.TextBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxStructure = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(12, 12);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonAdd_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.Text = "Name";
            this.NameLabel.Width = 100;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Text = "Category";
            this.CategoryLabel.Width = 100;
            // 
            // ListViewProperties
            // 
            this.ListViewProperties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameLabel,
            this.CategoryLabel});
            this.ListViewProperties.Location = new System.Drawing.Point(277, 58);
            this.ListViewProperties.Name = "ListViewProperties";
            this.ListViewProperties.Size = new System.Drawing.Size(245, 319);
            this.ListViewProperties.TabIndex = 1;
            this.ListViewProperties.UseCompatibleStateImageBehavior = false;
            this.ListViewProperties.View = System.Windows.Forms.View.Details;
            this.ListViewProperties.SelectedIndexChanged += new System.EventHandler(this.ListViewProperties_SelectedIndexChanged);
            this.ListViewProperties.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewProperties_MouseClick);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Enabled = false;
            this.ButtonEdit.Location = new System.Drawing.Point(93, 12);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 2;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonEdit_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Enabled = false;
            this.ButtonDelete.Location = new System.Drawing.Point(174, 12);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 3;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonDelete_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(447, 11);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(75, 23);
            this.ButtonSearch.TabIndex = 4;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(94, 67);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(155, 23);
            this.TextBoxName.TabIndex = 5;
            // 
            // TextBoxCategory
            // 
            this.TextBoxCategory.Location = new System.Drawing.Point(94, 108);
            this.TextBoxCategory.Name = "TextBoxCategory";
            this.TextBoxCategory.Size = new System.Drawing.Size(155, 23);
            this.TextBoxCategory.TabIndex = 6;
            // 
            // TextBoxDefinition
            // 
            this.TextBoxDefinition.Location = new System.Drawing.Point(33, 206);
            this.TextBoxDefinition.Multiline = true;
            this.TextBoxDefinition.Name = "TextBoxDefinition";
            this.TextBoxDefinition.Size = new System.Drawing.Size(216, 171);
            this.TextBoxDefinition.TabIndex = 7;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(277, 11);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(164, 23);
            this.TextBoxSearch.TabIndex = 8;
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Location = new System.Drawing.Point(33, 415);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpen.TabIndex = 9;
            this.ButtonOpen.Text = "Open";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(174, 415);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 10;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Definition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Category";
            // 
            // TextBoxStructure
            // 
            this.TextBoxStructure.Location = new System.Drawing.Point(94, 148);
            this.TextBoxStructure.Name = "TextBoxStructure";
            this.TextBoxStructure.Size = new System.Drawing.Size(155, 23);
            this.TextBoxStructure.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Structure";
            // 
            // FormCITEWiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxStructure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.TextBoxDefinition);
            this.Controls.Add(this.TextBoxCategory);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ListViewProperties);
            this.Controls.Add(this.ButtonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCITEWiki";
            this.Text = "Wiki Lookup";
            this.Load += new System.EventHandler(this.FormCITEWiki_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonAdd;
        private ColumnHeader NameLabel;
        private ColumnHeader CategoryLabel;
        private ListView ListViewProperties;
        private Button ButtonEdit;
        private Button ButtonDelete;
        private Button ButtonSearch;
        private TextBox TextBoxName;
        private TextBox TextBoxCategory;
        private TextBox TextBoxDefinition;
        private TextBox TextBoxSearch;
        private Button ButtonOpen;
        private Button ButtonSave;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TextBoxStructure;
        private Label label5;
    }
}