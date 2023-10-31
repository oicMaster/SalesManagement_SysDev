﻿using System;
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

        //①グリッドビューの表示形式を変更する
        //dataGridViewDsp.Columns[0].HeaderText = "";これは列名　必須
        //dataGridViewDsp.Columns[0].Visible = false;これは非表示　必須
        //グリッドビューの最後にいらないのがついてきているので、それを非表示にする
        //dataGridViewDsp.Columns[0].DisplayIndex = ;これは順番変更　基本このままでいいです。
        //dataGridViewDsp.Columns[0].DefaultCellStyle.Format = "";これはセルの表示内容を変更できる　これは今は設定しなくていいです。
        //例: if(flag==0)なら表示 if(flag==2)なら非表示みたいに使える
        //②:登録など、かけていないところあれば書いてください。if文は!の有無に気を付けてください。
        //➂TextChangedとKeyPressで～文字以内しか入力できないようにする,<6のみにした場合に7文字目が入力されるの注意、if文は<と=で2つ必要(ダイアログボックスなし)
        //例：if(<6){if(=6){バックスペースのみ入力許可}入力許可}
        //KeyPressは押したキーについて、TextChangedがテキストが変わった瞬間なので、基本上記if文はTextChangedになると思います。ページのメソッド参照
        //if文に ==6&&e.KeyChar != '\b'とかにすれば多分いけるはず。無理そうなら飛ばしてください。
        //数値型のみに設定するだけで構わないです。
        //④管理システムメモと順番が違うメソッドは順番通りにしてください。基本ChangedやPressなどを固めています。
        //⑤コピーした後、ボタンとメソッドを紐づけていないので、プロパティ→雷マークから対応するメソッドを選んでください。(全部)


        //太田、千田、西山で上記1～4まで　AriivalとChumonとClientとHattyuとOrderは確認済です。後半になればなるほど空白です。基本ClientかArrival辺りを参考にしてください。
        //特にEmployeeは最初の状態でおいているので、西山は確認用として作成してください。随時太田千田に質問、確認を取ってください。
        //中野、安井、山路でモジュール構成図を作る。サンプルとClient、Arrival辺りを見ながら大雑把に

        //太田へ　モジュールには3.1.1みたいな定義が必要になるので、来週あたりはそれを設定しながら設計書と数値を合わせていくことにします。
        //中野へ　モジュール構造図の方で人手が足りていると判断した場合は、仕様書のマージ削除(整頓作業)かコードの方の抜け部分をお願いします。
        //全員へモジュールの数値が必要な個所は空白で、のちに設計書に改めて書き込む事になると思います。
        //　　　日ごとに課題を大雑把に設定します。金曜日確認時、あまりにも遅れている場合には課題とします。
        //　　　後日進捗一覧を作って全体で話し合う際に使うので、その際に今後の進め方などを話すことになると思います。

        //早上がりについて、今のところ基本火曜日は一律五限まで作業してもらい、進捗の具合を見て金曜日に行うかどうか判断するカタチにしようと考えています。
        //また、バイトや就活など用事があって欠席、早退がある場合はリーダー、もしくは全体ラインにて事前に連絡をください。

        //また、ガントチャートは基本一週間単位で設定してください。
        //日報は基本完成未完成関係なく★３で構いません。
        //日報用、田中は未設定のフォームの作成・コード作成・提出物やコードの全体チェックを行います。
        //自分が2つ勘違いしており、登録は従来通りのものでOK、モジュール構成図は大雑把で構わないとのことです。
        //備考：全てのメソッドでGener a teをGener e teと書いてました。すみません。治せるなら治しておいてください。
        //システム管理メモも更新しておきました。
        //マージする順番は太田→千田→西山の順で行ってください。(マージできなかった場合はメモ帳、もしくは次回登校時に確認するため)
        //もしかしたらInputCheckいらないかもです。

        //次回予定
        //検索はtxbじゃなく変数を作ると複数検索が可能になる。
        //確定は更新と別テーブルへの登録を行っている(2つ)
        //非表示も表示するメソッドを追加する
        //MessageDspのメソッドを追加する
        //レイアウトを設計する

        //ページサイズは入力後にすぐ更新されるメソッドが必要
        //パスワード登録、データベース作成が必要
        //営業所、メーカの登録
        //小分類大分類

        //登録と検索は基本空白かどうかチェックにする
        //ページサイズとページナンバーは数字入力しかできない
        //主キーのテキストボックスの入力有無でボタンやテキストボックスが切り替わる
        //非表示理由の入力によって非表示フラグの内容が変わる
        //　外部キーをコンボボックスにする
        //　数値のみ入力可にして、データの数(Count)以上の数値は入力できないようにする
        //　リストを2つ用意して数値と名前を入れる。
        //　↑今のところなしにしようと思っています。

    }
}
