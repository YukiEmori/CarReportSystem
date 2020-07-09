using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {
        //車データを入れるバインディングリスト
        BindingList<CarReport> CarReport = new BindingList<CarReport>();

        public Form1()
        {
            InitializeComponent();
            dataGridView.DataSource = CarReport;
            
        }

       

        //追加ボタン
        private void btGridViewAdd_Click(object sender, EventArgs e)
        {

            //CarReportオブジェクトの生成
            CarReport obj = new CarReport
            {
                CreatedDate = dateTimePicker.Value,
                Author = comboBoxAuthor.Text,
                MaKer = Makers(),
                Name = comboBoxName.Text,
                Report = txReport.Text,
                Picture = pictureBox.Image
            };

            //リストの先頭(インデックス0)へ追加
            CarReport.Insert(0, obj);

            ////選択行をクリア
            dataGridView.ClearSelection();

            //追加時にcomboBoxに追加をする
            comboBoxName.Items.Add(comboBoxName.Text);
            comboBoxAuthor.Items.Add(comboBoxAuthor.Text);

            //登録時中身を空にする
            inputitemAllClear();

        }

        private CarReport.CarMaker Makers()
        {
            // 指定したグループ内のラジオボタンでチェックされている物を取り出す
            var RadioButtonChecked_InGroup = groupBox1.Controls.OfType<RadioButton>()
                .SingleOrDefault(rb => rb.Checked == true);

            if (RadioButtonChecked_InGroup == null)
            {
                return CarReportSystem.CarReport.CarMaker.DEFAULT;
            }

                switch (RadioButtonChecked_InGroup.Text)
                {
                    
                    case "トヨタ":
                        return CarReportSystem.CarReport.CarMaker.トヨタ;
                    case "日産":
                        return CarReportSystem.CarReport.CarMaker.日産;
                    case "ホンダ":
                        return CarReportSystem.CarReport.CarMaker.ホンダ;
                    case "スバル":
                        return CarReportSystem.CarReport.CarMaker.スバル;
                    case "外車":
                        return CarReportSystem.CarReport.CarMaker.外車;
                    case "その他":
                        return CarReportSystem.CarReport.CarMaker.その他;
    
                }
            return 0;
                   
        }

        //画像の追加
        private void btImageOpen_Click(object sender, EventArgs e)
        {
            if(ofdOpenImage.ShowDialog() == DialogResult.OK)
            {
                //選択した画像をピクチャーボックスに表示
                pictureBox.Image = Image.FromFile(ofdOpenImage.FileName);
                //ピクチャーボックスのサイズに画像を調節
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        //画像の削除
        private void btImageDelete_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
            {
                return;
            }
            DialogResult result = MessageBox.Show("削除していいですか", "確認", MessageBoxButtons.OKCancel);

            // 判定
            if (result == DialogResult.OK)
            {
                pictureBox.Image = null;
            }
        }

            private void btGridViewDelete_Click(object sender, EventArgs e)
        {
            CarReport.RemoveAt(dataGridView.CurrentRow.Index);
        }

        private void btGridViewFix_Click(object sender, EventArgs e)
        {
            CarReport SelectedCar = CarReport[dataGridView.CurrentRow.Index];
            SelectedCar.CreatedDate = dateTimePicker.Value;
            SelectedCar.Author = comboBoxAuthor.Text;
            SelectedCar.MaKer = Makers();
            SelectedCar.Name = comboBoxName.Text;
            SelectedCar.Report = txReport.Text;
            SelectedCar.Picture = pictureBox.Image;

            dataGridView.Refresh(); //データグリッドビューの再描画
        }


     


        //データを開く
        private void btGridViewOpen_Click(object sender, EventArgs e)
        {
            //オープンファイルダイアログを表示
            if (ofdOpenDate.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(ofdOpenDate.FileName, FileMode.Open))
                {
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        //逆シリアル化して読み込む
                        CarReport = (BindingList<CarReport>)formatter.Deserialize(fs);
                        //データグリッドビューに再設定
                        dataGridView.DataSource = CarReport;
                        
                    }
                    catch (SerializationException ex)
                    {
                        Console.WriteLine("Failed to deserialize. Reason: " + ex.Message);
                        throw;
                    }

                }
            }
        }

        //保存
        private void btSave_Click(object sender, EventArgs e)
        {
            //セーブファイルダイアログを表示
            if (sfdSaveData.ShowDialog() == DialogResult.OK)
            {


                BinaryFormatter formatter = new BinaryFormatter();
                //ファイルをストリーム
                using (FileStream fs = new FileStream(sfdSaveData.FileName, FileMode.Create))
                {
                    try
                    {
                        //シリアル化して保存
                        formatter.Serialize(fs,CarReport);
                    }
                    catch (SerializationException ex)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + ex.Message);
                        throw;
                    }
                }

            }
        }

        private void btEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //入力項目を全クリア
        private void inputitemAllClear()
        {
            comboBoxAuthor.Text = "";
            comboBoxName.Text = "";
            groupBox1.Text = "";
            txReport.Text = "";
            pictureBox.Image = null;
        }
    }
    }
