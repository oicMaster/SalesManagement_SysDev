using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new F_AdClient());
        }

        //①管理システムメモと順番が違うメソッドは順番通りにしてください。基本ChangedやPressなどを固めています。
        //　登録など、かけていないところあれば書いてください。if文は!の有無に気を付けてください。

        //②グリッドビューの表示形式を変更する
        //　dataGridViewDsp.Columns[0].HeaderText = "";これは列名　必須
        //　dataGridViewDsp.Columns[0].Visible = false;これは非表示　必須
        //　グリッドビューの最後にいらないのがついてきているので、それを非表示にする
        //　dataGridViewDsp.Columns[0].DefaultCellStyle.Format = "";これはセルの表示内容を変更できる　これは今は設定しなくていいです。
        //　例: if(flag==0)なら表示 if(flag==2)なら非表示みたいに使える

        //➂コピーした後、ボタンとメソッドを紐づけていないので、プロパティ→雷マークから対応するメソッドを選んでください。(全部)

        //④TextChangedとKeyPressで～文字以内しか入力できないようにする,<6のみにした場合に7文字目が入力されるの注意、if文は<と=で2つ必要(ダイアログボックスなし)
        //　例：if(<6){if(=6){バックスペースのみ入力許可}入力許可}
        //　KeyPressは押したキーについて、TextChangedがテキストが変わった瞬間なので、基本上記if文はTextChangedになると思います。ページのメソッド参照
        //　if文に ==6&&e.KeyChar != '\b'とかにすれば多分いけるはず。無理そうなら飛ばしてください。
        //　数値型のみに設定するだけで構わないです。
    }
}
