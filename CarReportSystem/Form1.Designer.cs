namespace CarReportSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.carReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202004DataSet = new CarReportSystem.infosys202004DataSet();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btImageOpen = new System.Windows.Forms.Button();
            this.btImageDelete = new System.Windows.Forms.Button();
            this.btGridViewAdd = new System.Windows.Forms.Button();
            this.btGridViewDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btGridViewOpen = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.txReport = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbGisya = new System.Windows.Forms.RadioButton();
            this.rbsonota = new System.Windows.Forms.RadioButton();
            this.ofdOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ofdOpenDate = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveData = new System.Windows.Forms.SaveFileDialog();
            this.carReportBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.carReportBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dgvCarReports = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btGridViewFix = new System.Windows.Forms.Button();
            this.tbSearchCarName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbSearchDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSearchCarMekar = new System.Windows.Forms.TextBox();
            this.btSearchExe = new System.Windows.Forms.Button();
            this.carReportTableAdapter = new CarReportSystem.infosys202004DataSetTableAdapters.CarReportTableAdapter();
            this.tableAdapterManager = new CarReportSystem.infosys202004DataSetTableAdapters.TableAdapterManager();
            this.rband = new System.Windows.Forms.RadioButton();
            this.rbor = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202004DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingNavigator)).BeginInit();
            this.carReportBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReports)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "レポート：";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReportBindingSource, "CreatedDate", true));
            this.dateTimePicker.Location = new System.Drawing.Point(129, 51);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker.TabIndex = 5;
            // 
            // carReportBindingSource
            // 
            this.carReportBindingSource.DataMember = "CarReport";
            this.carReportBindingSource.DataSource = this.infosys202004DataSet;
            // 
            // infosys202004DataSet
            // 
            this.infosys202004DataSet.DataSetName = "infosys202004DataSet";
            this.infosys202004DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(129, 94);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(239, 20);
            this.cbAuthor.TabIndex = 6;
            // 
            // cbName
            // 
            this.cbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReportBindingSource, "Name", true));
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(129, 190);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(239, 20);
            this.cbName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "画像：";
            // 
            // btImageOpen
            // 
            this.btImageOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImageOpen.Location = new System.Drawing.Point(642, 51);
            this.btImageOpen.Name = "btImageOpen";
            this.btImageOpen.Size = new System.Drawing.Size(75, 23);
            this.btImageOpen.TabIndex = 15;
            this.btImageOpen.Text = "開く";
            this.btImageOpen.UseVisualStyleBackColor = true;
            this.btImageOpen.Click += new System.EventHandler(this.btImageOpen_Click);
            // 
            // btImageDelete
            // 
            this.btImageDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImageDelete.Location = new System.Drawing.Point(735, 51);
            this.btImageDelete.Name = "btImageDelete";
            this.btImageDelete.Size = new System.Drawing.Size(75, 23);
            this.btImageDelete.TabIndex = 16;
            this.btImageDelete.Text = "削除";
            this.btImageDelete.UseVisualStyleBackColor = true;
            this.btImageDelete.Click += new System.EventHandler(this.btImageDelete_Click);
            // 
            // btGridViewAdd
            // 
            this.btGridViewAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGridViewAdd.Location = new System.Drawing.Point(536, 322);
            this.btGridViewAdd.Name = "btGridViewAdd";
            this.btGridViewAdd.Size = new System.Drawing.Size(75, 23);
            this.btGridViewAdd.TabIndex = 17;
            this.btGridViewAdd.Text = "追加";
            this.btGridViewAdd.UseVisualStyleBackColor = true;
            // 
            // btGridViewDelete
            // 
            this.btGridViewDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGridViewDelete.Location = new System.Drawing.Point(735, 322);
            this.btGridViewDelete.Name = "btGridViewDelete";
            this.btGridViewDelete.Size = new System.Drawing.Size(75, 23);
            this.btGridViewDelete.TabIndex = 19;
            this.btGridViewDelete.Text = "削除";
            this.btGridViewDelete.UseVisualStyleBackColor = true;
            this.btGridViewDelete.Click += new System.EventHandler(this.btGridViewDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "記事一覧：";
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Location = new System.Drawing.Point(30, 446);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 21;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // btGridViewOpen
            // 
            this.btGridViewOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGridViewOpen.Location = new System.Drawing.Point(30, 402);
            this.btGridViewOpen.Name = "btGridViewOpen";
            this.btGridViewOpen.Size = new System.Drawing.Size(75, 23);
            this.btGridViewOpen.TabIndex = 22;
            this.btGridViewOpen.Text = "接続";
            this.btGridViewOpen.UseVisualStyleBackColor = true;
            this.btGridViewOpen.Click += new System.EventHandler(this.btGridViewOpen_Click);
            // 
            // btEnd
            // 
            this.btEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnd.Location = new System.Drawing.Point(697, 540);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(113, 23);
            this.btEnd.TabIndex = 23;
            this.btEnd.Text = "終了";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click_1);
            // 
            // txReport
            // 
            this.txReport.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReportBindingSource, "Report", true));
            this.txReport.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txReport.Location = new System.Drawing.Point(129, 244);
            this.txReport.Multiline = true;
            this.txReport.Name = "txReport";
            this.txReport.Size = new System.Drawing.Size(363, 107);
            this.txReport.TabIndex = 24;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(549, 84);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(247, 214);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 25;
            this.pictureBox.TabStop = false;
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Location = new System.Drawing.Point(6, 15);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(47, 16);
            this.rbToyota.TabIndex = 8;
            this.rbToyota.TabStop = true;
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Location = new System.Drawing.Point(59, 15);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(47, 16);
            this.rbNissan.TabIndex = 9;
            this.rbNissan.TabStop = true;
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(112, 15);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 10;
            this.rbHonda.TabStop = true;
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.Location = new System.Drawing.Point(169, 15);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(52, 16);
            this.rbSubaru.TabIndex = 11;
            this.rbSubaru.TabStop = true;
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbGisya
            // 
            this.rbGisya.AutoSize = true;
            this.rbGisya.Location = new System.Drawing.Point(227, 15);
            this.rbGisya.Name = "rbGisya";
            this.rbGisya.Size = new System.Drawing.Size(47, 16);
            this.rbGisya.TabIndex = 12;
            this.rbGisya.TabStop = true;
            this.rbGisya.Text = "外車";
            this.rbGisya.UseVisualStyleBackColor = true;
            // 
            // rbsonota
            // 
            this.rbsonota.AutoSize = true;
            this.rbsonota.Location = new System.Drawing.Point(280, 15);
            this.rbsonota.Name = "rbsonota";
            this.rbsonota.Size = new System.Drawing.Size(54, 16);
            this.rbsonota.TabIndex = 13;
            this.rbsonota.TabStop = true;
            this.rbsonota.Text = "その他";
            this.rbsonota.UseVisualStyleBackColor = true;
            // 
            // ofdOpenImage
            // 
            this.ofdOpenImage.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbToyota);
            this.groupBox1.Controls.Add(this.rbsonota);
            this.groupBox1.Controls.Add(this.rbSubaru);
            this.groupBox1.Controls.Add(this.rbGisya);
            this.groupBox1.Controls.Add(this.rbHonda);
            this.groupBox1.Controls.Add(this.rbNissan);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(129, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 36);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ofdOpenDate
            // 
            this.ofdOpenDate.FileName = "openFileDialog1";
            // 
            // carReportBindingNavigator
            // 
            this.carReportBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.carReportBindingNavigator.BindingSource = this.carReportBindingSource;
            this.carReportBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carReportBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.carReportBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.carReportBindingNavigatorSaveItem});
            this.carReportBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.carReportBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carReportBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carReportBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carReportBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carReportBindingNavigator.Name = "carReportBindingNavigator";
            this.carReportBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carReportBindingNavigator.Size = new System.Drawing.Size(1154, 25);
            this.carReportBindingNavigator.TabIndex = 28;
            this.carReportBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "削除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // carReportBindingNavigatorSaveItem
            // 
            this.carReportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carReportBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("carReportBindingNavigatorSaveItem.Image")));
            this.carReportBindingNavigatorSaveItem.Name = "carReportBindingNavigatorSaveItem";
            this.carReportBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.carReportBindingNavigatorSaveItem.Text = "データの保存";
            // 
            // dgvCarReports
            // 
            this.dgvCarReports.AllowUserToAddRows = false;
            this.dgvCarReports.AllowUserToDeleteRows = false;
            this.dgvCarReports.AutoGenerateColumns = false;
            this.dgvCarReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewImageColumn1});
            this.dgvCarReports.DataSource = this.carReportBindingSource;
            this.dgvCarReports.Location = new System.Drawing.Point(129, 369);
            this.dgvCarReports.MultiSelect = false;
            this.dgvCarReports.Name = "dgvCarReports";
            this.dgvCarReports.ReadOnly = true;
            this.dgvCarReports.RowTemplate.Height = 21;
            this.dgvCarReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarReports.Size = new System.Drawing.Size(681, 141);
            this.dgvCarReports.TabIndex = 28;
            this.dgvCarReports.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarReports_CellContentClick);
            this.dgvCarReports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarReports_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CreatedDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "CreatedDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn3.HeaderText = "Author";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Maker";
            this.dataGridViewTextBoxColumn4.HeaderText = "Maker";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Report";
            this.dataGridViewTextBoxColumn6.HeaderText = "Report";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Picture";
            this.dataGridViewImageColumn1.HeaderText = "Picture";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // btGridViewFix
            // 
            this.btGridViewFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGridViewFix.Location = new System.Drawing.Point(642, 322);
            this.btGridViewFix.Name = "btGridViewFix";
            this.btGridViewFix.Size = new System.Drawing.Size(75, 23);
            this.btGridViewFix.TabIndex = 18;
            this.btGridViewFix.Text = "修正";
            this.btGridViewFix.UseVisualStyleBackColor = true;
            this.btGridViewFix.Click += new System.EventHandler(this.btGridViewFix_Click);
            // 
            // tbSearchCarName
            // 
            this.tbSearchCarName.Location = new System.Drawing.Point(57, 18);
            this.tbSearchCarName.Name = "tbSearchCarName";
            this.tbSearchCarName.Size = new System.Drawing.Size(201, 19);
            this.tbSearchCarName.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 30;
            this.label8.Text = "車名";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.rbor);
            this.groupBox2.Controls.Add(this.rband);
            this.groupBox2.Controls.Add(this.tbSearchDate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbSearchCarMekar);
            this.groupBox2.Controls.Add(this.btSearchExe);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbSearchCarName);
            this.groupBox2.Location = new System.Drawing.Point(840, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 170);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "検索";
            // 
            // tbSearchDate
            // 
            this.tbSearchDate.Location = new System.Drawing.Point(58, 83);
            this.tbSearchDate.Name = "tbSearchDate";
            this.tbSearchDate.Size = new System.Drawing.Size(200, 19);
            this.tbSearchDate.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 35;
            this.label10.Text = "日付";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 12);
            this.label9.TabIndex = 34;
            this.label9.Text = "メーカー";
            // 
            // tbSearchCarMekar
            // 
            this.tbSearchCarMekar.Location = new System.Drawing.Point(57, 53);
            this.tbSearchCarMekar.Name = "tbSearchCarMekar";
            this.tbSearchCarMekar.Size = new System.Drawing.Size(201, 19);
            this.tbSearchCarMekar.TabIndex = 32;
            // 
            // btSearchExe
            // 
            this.btSearchExe.Location = new System.Drawing.Point(177, 128);
            this.btSearchExe.Name = "btSearchExe";
            this.btSearchExe.Size = new System.Drawing.Size(81, 23);
            this.btSearchExe.TabIndex = 31;
            this.btSearchExe.Text = "実行";
            this.btSearchExe.UseVisualStyleBackColor = true;
            this.btSearchExe.Click += new System.EventHandler(this.btSearchExe_Click);
            // 
            // carReportTableAdapter
            // 
            this.carReportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarReportTableAdapter = this.carReportTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarReportSystem.infosys202004DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rband
            // 
            this.rband.AutoSize = true;
            this.rband.Location = new System.Drawing.Point(24, 133);
            this.rband.Name = "rband";
            this.rband.Size = new System.Drawing.Size(47, 16);
            this.rband.TabIndex = 37;
            this.rband.TabStop = true;
            this.rband.Text = "AND";
            this.rband.UseVisualStyleBackColor = true;

            // 
            // rbor
            // 
            this.rbor.AutoSize = true;
            this.rbor.Location = new System.Drawing.Point(92, 133);
            this.rbor.Name = "rbor";
            this.rbor.Size = new System.Drawing.Size(39, 16);
            this.rbor.TabIndex = 38;
            this.rbor.TabStop = true;
            this.rbor.Text = "OR";
            this.rbor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 665);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvCarReports);
            this.Controls.Add(this.carReportBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.txReport);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btGridViewOpen);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btGridViewDelete);
            this.Controls.Add(this.btGridViewFix);
            this.Controls.Add(this.btGridViewAdd);
            this.Controls.Add(this.btImageDelete);
            this.Controls.Add(this.btImageOpen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "試乗レポート管理システム";
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202004DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingNavigator)).EndInit();
            this.carReportBindingNavigator.ResumeLayout(false);
            this.carReportBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReports)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btImageOpen;
        private System.Windows.Forms.Button btImageDelete;
        private System.Windows.Forms.Button btGridViewAdd;
        private System.Windows.Forms.Button btGridViewDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btGridViewOpen;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.TextBox txReport;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbGisya;
        private System.Windows.Forms.RadioButton rbsonota;
        private System.Windows.Forms.OpenFileDialog ofdOpenImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog ofdOpenDate;
        private System.Windows.Forms.SaveFileDialog sfdSaveData;
        private infosys202004DataSet infosys202004DataSet;
        private System.Windows.Forms.BindingSource carReportBindingSource;
        private infosys202004DataSetTableAdapters.CarReportTableAdapter carReportTableAdapter;
        private infosys202004DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator carReportBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton carReportBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dgvCarReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btGridViewFix;
        private System.Windows.Forms.TextBox tbSearchCarName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSearchExe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker tbSearchDate;
        private System.Windows.Forms.TextBox tbSearchCarMekar;
        private System.Windows.Forms.RadioButton rband;
        private System.Windows.Forms.RadioButton rbor;
    }
}

