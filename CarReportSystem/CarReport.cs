using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem
{
    class CarReport
    {
        public DateTime CreatedDate; //作成日
        public string Author; //記録者
        public CarMaker MaKer; //メーカー（列挙型)
        public string Name; //車名
        public string Report; //レポート 
        public Image Picture; //画像
    }

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
