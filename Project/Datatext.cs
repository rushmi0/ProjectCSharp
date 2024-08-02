using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Project
{
    class Datatext
    {
        //list array ตัวอักษร
        public List<string> kana = new List<string>(new string[]
        {
           "ア","イ","ウ","エ","オ",
             "カ","キ","ク","ケ","コ",
             "サ","シ","ス","セ","ソ",
             "タ","チ","ツ","テ","ト",
             "ナ","ニ","ヌ","ネ","ノ",
             "ハ","ヒ","フ","ヘ","ホ",
             "マ","ミ","ム","メ","モ",
             "ヤ","ユ","ヨ",
             "ラ","リ","ル","レ","ロ",
             "ワ","ヲ","ン"
        });

        public string[] answer =
        {
            "a","i","u","e","o",
            "ka","ki","ku","ke","ko",
            "sa","shi","su","se","so",
            "ta","chi","tsu","te","to",
            "na","ni","nu","ne","no",
            "ha","hi","fu","he","ho",
            "ma","mi","mu","me","mo",
            "ya","yu","yo",
            "ra","ri","ru","re","ro",
            "wa","wo","n"
        };

        //list array ไฟล์เสียง
        public string[] kanasound = {

           @"a.wav",@"i.wav",@"u.wav",@"e.wav",@"o.wav",
            @"ka.wav",@"ki.wav",@"ku.wav",@"ke.wav",@"ko.wav",
            @"sa.wav",@"shi.wav",@"su.wav",@"se.wav",@"so.wav",
            @"ta.wav",@"chi.wav",@"tsu.wav",@"te.wav",@"to.wav",
            @"na.wav",@"ni.wav",@"nu.wav",@"ne.wav",@"no.wav",
            @"ha.wav",@"hi.wav",@"fu.wav",@"he.wav",@"ho.wav",
            @"ma.wav",@"mi.wav",@"mu.wav",@"me.wav",@"mo.wav",
            @"ya.wav",@"yu.wav",@"yo.wav",
            @"ra.wav",@"ri.wav",@"ru.wav",@"re.wav",@"ro.wav",
            @"wa.wav",@"wo.wav",@"nn.wav"

        };



        public string textJPN(int input) {  //แสดงตัวอักษร

            return kana[input];
        }
        public string textENG(int input) //แสดงตัวอักษรโรมันจิ
        {
            return answer[input];
        }
        public string soundFile(int input) //แสดงเสียง
        {
            return kanasound[input];
        }

        

            
        
    }
}
