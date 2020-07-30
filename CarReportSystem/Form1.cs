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
            //dataGridView.DataSource = CarReport;
            
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


        //データ接続
        private void btGridViewOpen_Click(object sender, EventArgs e)
        {

            // TODO: このコード行はデータを 'infosys202004DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202004DataSet.CarReport);
            dgvCarReports.Columns[0].Visible = false;
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

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //データベース更新(反映)
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202004DataSet);
         
        }
  
        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] byteData)
        {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(byteData);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] byteData = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return byteData;
        }

        //一行選択したときのラジオボタン
        private void setMakerRadioButtonSet(string carMaker)
        {
            switch (carMaker)
            {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "外車":
                    rbGisya.Checked = true;
                    break;
                case "その他":
                    rbsonota.Checked = true;
                    break;

            }
        }

        //変更ボタン
        private void btGridViewFix_Click(object sender, EventArgs e)
        {
            dgvCarReports.CurrentRow.Cells[2].Value = cbAuthor.Text;
            dgvCarReports.CurrentRow.Cells[6].Value = ImageToByteArray(pictureBox.Image);

            if(pictureBox.Image != null)
            {
                dgvCarReports.CurrentRow.Cells[6].Value = ImageToByteArray(pictureBox.Image);
            }
            else
            {
                dgvCarReports.CurrentRow.Cells[6].Value = null;
            }


            //データベース反映
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202004DataSet);
        }

        //データグリッドビィーをクリック
        private void dgvCarReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //選択したレコード（行)の、インデックスで指定した項目を取り出す
                dateTimePicker.Value = (DateTime)dgvCarReports.CurrentRow.Cells[1].Value; 
            var maker = dgvCarReports.CurrentRow.Cells[3].Value;

            //編集者
            cbAuthor.Text = dgvCarReports.CurrentRow.Cells[2].Value.ToString();

                //画像
                setMakerRadioButtonSet((string)maker);
                pictureBox.Image = ByteArrayToImage((byte[])dgvCarReports.CurrentRow.Cells[6].Value);
            }
            catch (InvalidCastException)//画像がDBに登録されていないとき
            {
                pictureBox.Image = null;
            }
            catch(Exception ex)//上記以外のデータをすべて疲労
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        //終了ボタン
        private void btEnd_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btGridViewDelete_Click(object sender, EventArgs e)
        {

        }

        private void btSearchExe_Click(object sender, EventArgs e)
        {
            
            if (rband.Checked == true){
                this.carReportTableAdapter.FillByCar(this.infosys202004DataSet.CarReport, tbSearchCarName.Text, tbSearchCarMekar.Text, tbSearchDate.Value.ToString());
            }

            else if (rbor.Checked == true)
            {
                this.carReportTableAdapter.FillByCarOr(this.infosys202004DataSet.CarReport, tbSearchDate.Value.ToString(), tbSearchCarMekar.Text, tbSearchCarName.Text);
  }
            


        }

    }
}


