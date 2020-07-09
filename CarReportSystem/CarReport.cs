using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem
{
    [Serializable]
    class CarReport
    {
        [System.ComponentModel.DisplayName("作成日")]
        public DateTime CreatedDate { get; set; } //作成日

        [System.ComponentModel.DisplayName("記録者")]
        public string Author { get; set; } //記録者

        [System.ComponentModel.DisplayName("メーカー")]
        public CarMaker MaKer { get; set; } //メーカー（列挙型)

        [System.ComponentModel.DisplayName("車名")]
        public string Name { get; set; } //車名

        [System.ComponentModel.DisplayName("レポート")]
        public string Report { get; set; } //レポート 

        [System.ComponentModel.DisplayName("画像")]
        public Image Picture{ get; set; } //画像


        //メーカー
        public enum CarMaker
        {
            DEFAULT,
            トヨタ,
            日産,
            ホンダ,
            スバル,
            外車,
            その他
        }
    }

    

   
}
