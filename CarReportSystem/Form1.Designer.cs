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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btImageOpen = new System.Windows.Forms.Button();
            this.btImageDelete = new System.Windows.Forms.Button();
            this.btGridViewAdd = new System.Windows.Forms.Button();
            this.btGridViewFix = new System.Windows.Forms.Button();
            this.btGridViewDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btGridViewOpen = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.txReport = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "レポート：";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(121, 26);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker.TabIndex = 5;
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(121, 69);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(239, 20);
            this.comboBoxAuthor.TabIndex = 6;
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(121, 164);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(239, 20);
            this.comboBoxName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "画像：";
            // 
            // btImageOpen
            // 
            this.btImageOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImageOpen.Location = new System.Drawing.Point(640, 22);
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
            this.btImageDelete.Location = new System.Drawing.Point(733, 22);
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
            this.btGridViewAdd.Location = new System.Drawing.Point(534, 297);
            this.btGridViewAdd.Name = "btGridViewAdd";
            this.btGridViewAdd.Size = new System.Drawing.Size(75, 23);
            this.btGridViewAdd.TabIndex = 17;
            this.btGridViewAdd.Text = "追加";
            this.btGridViewAdd.UseVisualStyleBackColor = true;
            this.btGridViewAdd.Click += new System.EventHandler(this.btGridViewAdd_Click);
            // 
            // btGridViewFix
            // 
            this.btGridViewFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGridViewFix.Location = new System.Drawing.Point(640, 297);
            this.btGridViewFix.Name = "btGridViewFix";
            this.btGridViewFix.Size = new System.Drawing.Size(75, 23);
            this.btGridViewFix.TabIndex = 18;
            this.btGridViewFix.Text = "修正";
            this.btGridViewFix.UseVisualStyleBackColor = true;
            this.btGridViewFix.Click += new System.EventHandler(this.btGridViewFix_Click);
            // 
            // btGridViewDelete
            // 
            this.btGridViewDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGridViewDelete.Location = new System.Drawing.Point(733, 297);
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
            this.label7.Location = new System.Drawing.Point(35, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "記事一覧：";
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Location = new System.Drawing.Point(28, 421);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 21;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btGridViewOpen
            // 
            this.btGridViewOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGridViewOpen.Location = new System.Drawing.Point(28, 377);
            this.btGridViewOpen.Name = "btGridViewOpen";
            this.btGridViewOpen.Size = new System.Drawing.Size(75, 23);
            this.btGridViewOpen.TabIndex = 22;
            this.btGridViewOpen.Text = "開く";
            this.btGridViewOpen.UseVisualStyleBackColor = true;
            this.btGridViewOpen.Click += new System.EventHandler(this.btGridViewOpen_Click);
            // 
            // btEnd
            // 
            this.btEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnd.Location = new System.Drawing.Point(695, 496);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(113, 23);
            this.btEnd.TabIndex = 23;
            this.btEnd.Text = "終了";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // txReport
            // 
            this.txReport.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txReport.Location = new System.Drawing.Point(127, 219);
            this.txReport.Multiline = true;
            this.txReport.Name = "txReport";
            this.txReport.Size = new System.Drawing.Size(363, 107);
            this.txReport.TabIndex = 24;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(547, 59);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(247, 214);
            this.pictureBox.TabIndex = 25;
            this.pictureBox.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(121, 332);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 21;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(687, 148);
            this.dataGridView.TabIndex = 26;
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
            this.groupBox1.Location = new System.Drawing.Point(121, 98);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
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
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.comboBoxAuthor);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "試乗レポート管理システム";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBoxAuthor;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btImageOpen;
        private System.Windows.Forms.Button btImageDelete;
        private System.Windows.Forms.Button btGridViewAdd;
        private System.Windows.Forms.Button btGridViewFix;
        private System.Windows.Forms.Button btGridViewDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btGridViewOpen;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.TextBox txReport;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridView dataGridView;
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
    }
}

