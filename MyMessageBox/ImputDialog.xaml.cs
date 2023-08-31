using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MyMessageBox
{
    /// <summary>
    /// ImputDialog.xaml の相互作用ロジック
    /// </summary>
    public partial class ImputDialog : Window
    {

        /// <summary>
        /// 編集した入力値を呼び出し元に返すためのプロパティ
        /// </summary>
        public string Text { get { return uxImputText.Text; } set { uxImputText.Text = value; } }


        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="owner">呼び出し元のWindow</param>
        /// <param name="str">編集したい文字列</param>
        public ImputDialog(Window owner,string str)
        {
            InitializeComponent();

            this.Owner = owner; //呼び出し元のWindow
            this.WindowStartupLocation = WindowStartupLocation.CenterOwner; //起動時の表示位置を親画面の中央に合わせる
            uxImputText.Text = str;//引数で渡された文字列をテキストボックスにセット
        }


        /// <summary>
        /// 登録ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOK_Click(object sender, RoutedEventArgs e)
        {
            //ダイアログの戻り値として true をセット
            DialogResult = true;
        }


        /// <summary>
        /// 中止ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void uxCancel_Click(object sender, RoutedEventArgs e)
        {
            //ダイアログの戻り値戻り値としてfalseをセット
            DialogResult = false;
        }


        private void uxImputText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
