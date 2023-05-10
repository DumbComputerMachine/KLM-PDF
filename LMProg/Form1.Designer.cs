namespace LMProg {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listView1 = new ListView();
            SelectionDownButton = new Button();
            SelectionUpButton = new Button();
            RemoveAllButton = new Button();
            RemoveSelectedButton = new Button();
            PreviewButton = new Button();
            CreateFileButton = new Button();
            CreatePDFButton = new Button();
            FileSelectTextBox = new TextBox();
            FileSelectButton = new Button();
            InsertBeforeButton = new Button();
            InsertAfterButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            GroupBoxAddFile = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            InsertButton = new Button();
            GroupBoxOpenFile = new GroupBox();
            GroupBoxAddEmpty = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            InsertEmptyButton = new Button();
            InsertEmptyBeforeButton = new Button();
            InsertEmptyAfterButton = new Button();
            GroupBoxDeleteItem = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            GroupBoxFileOps = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            PrintButton = new Button();
            errorProvider1 = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            GroupBoxAddFile.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            GroupBoxOpenFile.SuspendLayout();
            GroupBoxAddEmpty.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            GroupBoxDeleteItem.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            GroupBoxFileOps.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.AllowDrop = true;
            listView1.AutoArrange = false;
            listView1.CheckBoxes = true;
            tableLayoutPanel1.SetColumnSpan(listView1, 6);
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(3, 287);
            listView1.Name = "listView1";
            tableLayoutPanel1.SetRowSpan(listView1, 2);
            listView1.Size = new Size(576, 182);
            listView1.TabIndex = 14;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.ItemChecked += listView1_ItemChecked;
            listView1.SelectedIndexChanged += ListView1_SelectedIndexChanged;
            // 
            // SelectionDownButton
            // 
            SelectionDownButton.AutoSize = true;
            SelectionDownButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SelectionDownButton.Dock = DockStyle.Top;
            SelectionDownButton.Font = new Font("Webdings", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SelectionDownButton.Location = new Point(585, 381);
            SelectionDownButton.Name = "SelectionDownButton";
            SelectionDownButton.Size = new Size(37, 29);
            SelectionDownButton.TabIndex = 12;
            SelectionDownButton.Text = "6";
            SelectionDownButton.UseVisualStyleBackColor = true;
            SelectionDownButton.Click += MoveItemDownButton;
            // 
            // SelectionUpButton
            // 
            SelectionUpButton.AutoSize = true;
            SelectionUpButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SelectionUpButton.Dock = DockStyle.Bottom;
            SelectionUpButton.Font = new Font("Webdings", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SelectionUpButton.Location = new Point(585, 346);
            SelectionUpButton.Name = "SelectionUpButton";
            SelectionUpButton.Size = new Size(37, 29);
            SelectionUpButton.TabIndex = 11;
            SelectionUpButton.Text = "5";
            SelectionUpButton.UseVisualStyleBackColor = true;
            SelectionUpButton.Click += MoveItemUpButton;
            // 
            // RemoveAllButton
            // 
            RemoveAllButton.AutoEllipsis = true;
            RemoveAllButton.Dock = DockStyle.Fill;
            RemoveAllButton.Location = new Point(288, 3);
            RemoveAllButton.Name = "RemoveAllButton";
            RemoveAllButton.Size = new Size(279, 24);
            RemoveAllButton.TabIndex = 3;
            RemoveAllButton.Text = "Poista kaikki";
            RemoveAllButton.UseVisualStyleBackColor = true;
            RemoveAllButton.Click += RemoveAllButton_Click;
            // 
            // RemoveSelectedButton
            // 
            RemoveSelectedButton.AutoEllipsis = true;
            RemoveSelectedButton.Dock = DockStyle.Fill;
            RemoveSelectedButton.Location = new Point(3, 3);
            RemoveSelectedButton.Name = "RemoveSelectedButton";
            RemoveSelectedButton.Size = new Size(279, 24);
            RemoveSelectedButton.TabIndex = 2;
            RemoveSelectedButton.Text = "Poista valitut";
            RemoveSelectedButton.UseVisualStyleBackColor = true;
            RemoveSelectedButton.Click += RemoveSelectedButton_Click;
            // 
            // PreviewButton
            // 
            PreviewButton.AutoSize = true;
            PreviewButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(PreviewButton, 2);
            PreviewButton.Dock = DockStyle.Fill;
            PreviewButton.Enabled = false;
            PreviewButton.Location = new Point(197, 525);
            PreviewButton.Name = "PreviewButton";
            PreviewButton.Size = new Size(188, 45);
            PreviewButton.TabIndex = 4;
            PreviewButton.Text = "Esikatselu";
            PreviewButton.UseVisualStyleBackColor = true;
            // 
            // CreateFileButton
            // 
            CreateFileButton.AutoSize = true;
            CreateFileButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CreateFileButton.Dock = DockStyle.Fill;
            CreateFileButton.Enabled = false;
            CreateFileButton.Location = new Point(3, 3);
            CreateFileButton.Name = "CreateFileButton";
            CreateFileButton.Size = new Size(176, 30);
            CreateFileButton.TabIndex = 5;
            CreateFileButton.Text = "AutoPrint";
            CreateFileButton.UseVisualStyleBackColor = true;
            // 
            // CreatePDFButton
            // 
            CreatePDFButton.AutoSize = true;
            CreatePDFButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CreatePDFButton.Dock = DockStyle.Fill;
            CreatePDFButton.Location = new Point(3, 39);
            CreatePDFButton.Name = "CreatePDFButton";
            CreatePDFButton.Size = new Size(176, 31);
            CreatePDFButton.TabIndex = 6;
            CreatePDFButton.Text = "PDF";
            CreatePDFButton.UseVisualStyleBackColor = true;
            CreatePDFButton.Click += CreatePDFButton_Click;
            // 
            // FileSelectTextBox
            // 
            FileSelectTextBox.AcceptsReturn = true;
            FileSelectTextBox.AllowDrop = true;
            FileSelectTextBox.CausesValidation = false;
            tableLayoutPanel1.SetColumnSpan(FileSelectTextBox, 5);
            FileSelectTextBox.Dock = DockStyle.Fill;
            FileSelectTextBox.HideSelection = false;
            FileSelectTextBox.Location = new Point(3, 3);
            FileSelectTextBox.Margin = new Padding(3, 3, 20, 3);
            FileSelectTextBox.Multiline = true;
            FileSelectTextBox.Name = "FileSelectTextBox";
            FileSelectTextBox.PlaceholderText = "Lisättävät tiedostot";
            FileSelectTextBox.Size = new Size(462, 84);
            FileSelectTextBox.TabIndex = 10;
            FileSelectTextBox.WordWrap = false;
            FileSelectTextBox.TextChanged += FileSelectTextBox_TextChanged;
            FileSelectTextBox.Enter += FileSelectTextBox_Enter;
            FileSelectTextBox.Leave += FileSelectTextBox_Leave;
            // 
            // FileSelectButton
            // 
            FileSelectButton.AutoSize = true;
            FileSelectButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FileSelectButton.Dock = DockStyle.Top;
            FileSelectButton.Font = new Font("Wingdings", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FileSelectButton.Location = new Point(3, 19);
            FileSelectButton.Name = "FileSelectButton";
            FileSelectButton.Size = new Size(85, 27);
            FileSelectButton.TabIndex = 9;
            FileSelectButton.Text = "1";
            FileSelectButton.UseVisualStyleBackColor = true;
            FileSelectButton.Click += FileSelectButton_Click;
            // 
            // InsertBeforeButton
            // 
            InsertBeforeButton.AutoEllipsis = true;
            InsertBeforeButton.Dock = DockStyle.Top;
            InsertBeforeButton.Location = new Point(192, 3);
            InsertBeforeButton.Name = "InsertBeforeButton";
            InsertBeforeButton.Size = new Size(184, 24);
            InsertBeforeButton.TabIndex = 8;
            InsertBeforeButton.Text = "Lisää ennen";
            InsertBeforeButton.UseVisualStyleBackColor = true;
            InsertBeforeButton.Click += InsertBeforeButton_Click;
            // 
            // InsertAfterButton
            // 
            InsertAfterButton.AutoEllipsis = true;
            InsertAfterButton.Dock = DockStyle.Top;
            InsertAfterButton.Location = new Point(382, 3);
            InsertAfterButton.Name = "InsertAfterButton";
            InsertAfterButton.Size = new Size(185, 24);
            InsertAfterButton.TabIndex = 7;
            InsertAfterButton.Text = "Lisää jälkeen";
            InsertAfterButton.UseVisualStyleBackColor = true;
            InsertAfterButton.Click += InsertAfterButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(SelectionUpButton, 6, 6);
            tableLayoutPanel1.Controls.Add(SelectionDownButton, 6, 7);
            tableLayoutPanel1.Controls.Add(listView1, 0, 6);
            tableLayoutPanel1.Controls.Add(FileSelectTextBox, 0, 0);
            tableLayoutPanel1.Controls.Add(GroupBoxAddFile, 0, 1);
            tableLayoutPanel1.Controls.Add(GroupBoxOpenFile, 5, 0);
            tableLayoutPanel1.Controls.Add(GroupBoxAddEmpty, 0, 3);
            tableLayoutPanel1.Controls.Add(GroupBoxDeleteItem, 0, 5);
            tableLayoutPanel1.Controls.Add(GroupBoxFileOps, 0, 8);
            tableLayoutPanel1.Controls.Add(PreviewButton, 2, 10);
            tableLayoutPanel1.Controls.Add(PrintButton, 4, 10);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(625, 573);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // GroupBoxAddFile
            // 
            tableLayoutPanel1.SetColumnSpan(GroupBoxAddFile, 6);
            GroupBoxAddFile.Controls.Add(tableLayoutPanel2);
            GroupBoxAddFile.Dock = DockStyle.Top;
            GroupBoxAddFile.Location = new Point(3, 93);
            GroupBoxAddFile.Name = "GroupBoxAddFile";
            GroupBoxAddFile.Size = new Size(576, 52);
            GroupBoxAddFile.TabIndex = 17;
            GroupBoxAddFile.TabStop = false;
            GroupBoxAddFile.Text = "Tiedoston lisäys";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Controls.Add(InsertButton, 0, 0);
            tableLayoutPanel2.Controls.Add(InsertAfterButton, 2, 0);
            tableLayoutPanel2.Controls.Add(InsertBeforeButton, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(570, 30);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // InsertButton
            // 
            InsertButton.AutoEllipsis = true;
            InsertButton.Dock = DockStyle.Top;
            InsertButton.Location = new Point(3, 3);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(183, 24);
            InsertButton.TabIndex = 15;
            InsertButton.Text = "Lisää";
            InsertButton.UseVisualStyleBackColor = true;
            InsertButton.Click += InsertButton_Click;
            // 
            // GroupBoxOpenFile
            // 
            GroupBoxOpenFile.AutoSize = true;
            GroupBoxOpenFile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GroupBoxOpenFile.Controls.Add(FileSelectButton);
            GroupBoxOpenFile.Dock = DockStyle.Top;
            GroupBoxOpenFile.Location = new Point(488, 3);
            GroupBoxOpenFile.Name = "GroupBoxOpenFile";
            GroupBoxOpenFile.Size = new Size(91, 49);
            GroupBoxOpenFile.TabIndex = 18;
            GroupBoxOpenFile.TabStop = false;
            GroupBoxOpenFile.Text = "Avaa";
            // 
            // GroupBoxAddEmpty
            // 
            tableLayoutPanel1.SetColumnSpan(GroupBoxAddEmpty, 6);
            GroupBoxAddEmpty.Controls.Add(tableLayoutPanel4);
            GroupBoxAddEmpty.Dock = DockStyle.Fill;
            GroupBoxAddEmpty.Location = new Point(3, 161);
            GroupBoxAddEmpty.Name = "GroupBoxAddEmpty";
            GroupBoxAddEmpty.Size = new Size(576, 52);
            GroupBoxAddEmpty.TabIndex = 20;
            GroupBoxAddEmpty.TabStop = false;
            GroupBoxAddEmpty.Text = "Tyhän lisäys";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(InsertEmptyButton, 0, 0);
            tableLayoutPanel4.Controls.Add(InsertEmptyBeforeButton, 1, 0);
            tableLayoutPanel4.Controls.Add(InsertEmptyAfterButton, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 19);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(570, 30);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // InsertEmptyButton
            // 
            InsertEmptyButton.Dock = DockStyle.Fill;
            InsertEmptyButton.Location = new Point(3, 3);
            InsertEmptyButton.Name = "InsertEmptyButton";
            InsertEmptyButton.Size = new Size(184, 24);
            InsertEmptyButton.TabIndex = 0;
            InsertEmptyButton.Text = "Lisää";
            InsertEmptyButton.UseVisualStyleBackColor = true;
            InsertEmptyButton.Click += InsertEmptyButton_Click;
            // 
            // InsertEmptyBeforeButton
            // 
            InsertEmptyBeforeButton.Dock = DockStyle.Fill;
            InsertEmptyBeforeButton.Location = new Point(193, 3);
            InsertEmptyBeforeButton.Name = "InsertEmptyBeforeButton";
            InsertEmptyBeforeButton.Size = new Size(184, 24);
            InsertEmptyBeforeButton.TabIndex = 1;
            InsertEmptyBeforeButton.Text = "Lisää ennen";
            InsertEmptyBeforeButton.UseVisualStyleBackColor = true;
            InsertEmptyBeforeButton.Click += InsertEmptyBeforeButton_Click;
            // 
            // InsertEmptyAfterButton
            // 
            InsertEmptyAfterButton.Dock = DockStyle.Fill;
            InsertEmptyAfterButton.Location = new Point(383, 3);
            InsertEmptyAfterButton.Name = "InsertEmptyAfterButton";
            InsertEmptyAfterButton.Size = new Size(184, 24);
            InsertEmptyAfterButton.TabIndex = 2;
            InsertEmptyAfterButton.Text = "Lisää jälkeen";
            InsertEmptyAfterButton.UseVisualStyleBackColor = true;
            InsertEmptyAfterButton.Click += InsertEmptyAfterButton_Click;
            // 
            // GroupBoxDeleteItem
            // 
            tableLayoutPanel1.SetColumnSpan(GroupBoxDeleteItem, 6);
            GroupBoxDeleteItem.Controls.Add(tableLayoutPanel3);
            GroupBoxDeleteItem.Dock = DockStyle.Fill;
            GroupBoxDeleteItem.Location = new Point(3, 229);
            GroupBoxDeleteItem.Name = "GroupBoxDeleteItem";
            GroupBoxDeleteItem.Size = new Size(576, 52);
            GroupBoxDeleteItem.TabIndex = 19;
            GroupBoxDeleteItem.TabStop = false;
            GroupBoxDeleteItem.Text = "Poisto";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(RemoveAllButton, 1, 0);
            tableLayoutPanel3.Controls.Add(RemoveSelectedButton, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(570, 30);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // GroupBoxFileOps
            // 
            tableLayoutPanel1.SetColumnSpan(GroupBoxFileOps, 2);
            GroupBoxFileOps.Controls.Add(tableLayoutPanel5);
            GroupBoxFileOps.Dock = DockStyle.Fill;
            GroupBoxFileOps.Location = new Point(3, 475);
            GroupBoxFileOps.Name = "GroupBoxFileOps";
            tableLayoutPanel1.SetRowSpan(GroupBoxFileOps, 3);
            GroupBoxFileOps.Size = new Size(188, 95);
            GroupBoxFileOps.TabIndex = 21;
            GroupBoxFileOps.TabStop = false;
            GroupBoxFileOps.Text = "Tiedoston tallennus";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(CreatePDFButton, 0, 1);
            tableLayoutPanel5.Controls.Add(CreateFileButton, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 19);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(182, 73);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // PrintButton
            // 
            PrintButton.AutoSize = true;
            PrintButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(PrintButton, 2);
            PrintButton.Dock = DockStyle.Fill;
            PrintButton.Enabled = false;
            PrintButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PrintButton.Location = new Point(391, 525);
            PrintButton.Name = "PrintButton";
            PrintButton.Size = new Size(188, 45);
            PrintButton.TabIndex = 16;
            PrintButton.Text = "Tulosta";
            PrintButton.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 573);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            GroupBoxAddFile.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            GroupBoxOpenFile.ResumeLayout(false);
            GroupBoxOpenFile.PerformLayout();
            GroupBoxAddEmpty.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            GroupBoxDeleteItem.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            GroupBoxFileOps.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button InsertAfterButton;
        private Button InsertBeforeButton;
        private Button FileSelectButton;
        private TextBox FileSelectTextBox;
        private Button CreatePDFButton;
        private Button CreateFileButton;
        private Button PreviewButton;
        private Button RemoveSelectedButton;
        private Button RemoveAllButton;
        private Button SelectionUpButton;
        private Button SelectionDownButton;
        private Button InsertButton;
        private Button PrintButton;
        private ErrorProvider errorProvider1;
        private GroupBox GroupBoxAddFile;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox GroupBoxOpenFile;
        private GroupBox GroupBoxAddEmpty;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox GroupBoxDeleteItem;
        private TableLayoutPanel tableLayoutPanel3;
        private Button InsertEmptyButton;
        private Button InsertEmptyBeforeButton;
        private Button InsertEmptyAfterButton;
        private GroupBox GroupBoxFileOps;
        private TableLayoutPanel tableLayoutPanel5;
    }
}