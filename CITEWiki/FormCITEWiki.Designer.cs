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
            ButtonAdd = new Button();
            NameLabel = new ColumnHeader();
            CategoryLabel = new ColumnHeader();
            MyListViewItem = new ListView();
            ButtonEdit = new Button();
            ButtonDelete = new Button();
            button2 = new Button();
            TextBoxName = new TextBox();
            TextBoxCategory = new TextBox();
            TextBoxDefinition = new TextBox();
            textBox4 = new TextBox();
            ButtonOpen = new Button();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TextBoxStructure = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(12, 12);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(75, 23);
            ButtonAdd.TabIndex = 0;
            ButtonAdd.Text = "Add";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.MouseClick += ButtonAdd_Click;
            // 
            // NameLabel
            // 
            NameLabel.Text = "Name";
            NameLabel.Width = 100;
            // 
            // CategoryLabel
            // 
            CategoryLabel.Text = "Category";
            CategoryLabel.Width = 100;
            // 
            // MyListViewItem
            // 
            MyListViewItem.Columns.AddRange(new ColumnHeader[] { NameLabel, CategoryLabel });
            MyListViewItem.Location = new Point(277, 58);
            MyListViewItem.Name = "MyListViewItem";
            MyListViewItem.Size = new Size(245, 319);
            MyListViewItem.TabIndex = 1;
            MyListViewItem.UseCompatibleStateImageBehavior = false;
            MyListViewItem.View = View.Details;
            MyListViewItem.SelectedIndexChanged += ListViewDisplay_SelectedIndexChanged;
            // 
            // ButtonEdit
            // 
            ButtonEdit.Location = new Point(93, 12);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new Size(75, 23);
            ButtonEdit.TabIndex = 2;
            ButtonEdit.Text = "Edit";
            ButtonEdit.UseVisualStyleBackColor = true;
            ButtonEdit.MouseClick += ButtonEdit_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(174, 12);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(75, 23);
            ButtonDelete.TabIndex = 3;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.MouseClick += ButtonDelete_Click;
            // 
            // button2
            // 
            button2.Location = new Point(447, 10);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(94, 67);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(155, 23);
            TextBoxName.TabIndex = 5;
            // 
            // TextBoxCategory
            // 
            TextBoxCategory.Location = new Point(94, 108);
            TextBoxCategory.Name = "TextBoxCategory";
            TextBoxCategory.Size = new Size(155, 23);
            TextBoxCategory.TabIndex = 6;
            // 
            // TextBoxDefinition
            // 
            TextBoxDefinition.Location = new Point(33, 206);
            TextBoxDefinition.Multiline = true;
            TextBoxDefinition.Name = "TextBoxDefinition";
            TextBoxDefinition.Size = new Size(216, 171);
            TextBoxDefinition.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(277, 11);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(164, 23);
            textBox4.TabIndex = 8;
            // 
            // ButtonOpen
            // 
            ButtonOpen.Location = new Point(33, 415);
            ButtonOpen.Name = "ButtonOpen";
            ButtonOpen.Size = new Size(75, 23);
            ButtonOpen.TabIndex = 9;
            ButtonOpen.Text = "Open";
            ButtonOpen.UseVisualStyleBackColor = true;
            ButtonOpen.MouseClick += ButtonOpen_MouseClick;
            // 
            // button4
            // 
            button4.Location = new Point(174, 415);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 10;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 70);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 13;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 188);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 14;
            label3.Text = "Definition";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 108);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 15;
            label4.Text = "Category";
            // 
            // TextBoxStructure
            // 
            TextBoxStructure.Location = new Point(94, 148);
            TextBoxStructure.Name = "TextBoxStructure";
            TextBoxStructure.Size = new Size(155, 23);
            TextBoxStructure.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 148);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 17;
            label5.Text = "Structure";
            // 
            // FormCITEWiki
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 450);
            Controls.Add(label5);
            Controls.Add(TextBoxStructure);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(ButtonOpen);
            Controls.Add(textBox4);
            Controls.Add(TextBoxDefinition);
            Controls.Add(TextBoxCategory);
            Controls.Add(TextBoxName);
            Controls.Add(button2);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonEdit);
            Controls.Add(MyListViewItem);
            Controls.Add(ButtonAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormCITEWiki";
            Text = "Wiki Lookup";
            Load += DataTableForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonAdd;
        private ColumnHeader NameLabel;
        private ColumnHeader CategoryLabel;
        private ListView MyListViewItem;
        private Button ButtonEdit;
        private Button ButtonDelete;
        private Button button2;
        private TextBox TextBoxName;
        private TextBox TextBoxCategory;
        private TextBox TextBoxDefinition;
        private TextBox textBox4;
        private Button ButtonOpen;
        private Button button4;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TextBoxStructure;
        private Label label5;
    }
}