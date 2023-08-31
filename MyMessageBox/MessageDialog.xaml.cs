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
    /// MessageDialog.xaml の相互作用ロジック
    /// </summary>
    public partial class MessageDialog : Window
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="owner">呼び出し元のWindow</param>
        /// <param name="message">表示したい文字列</param>
        public MessageDialog(Window owner,string message)
        {
            InitializeComponent();

            this.Owner = owner; //呼び出し元のWindow
            this.WindowStartupLocation = WindowStartupLocation.CenterOwner; //起動時の表示位置を親画面の中央に合わせる
            uxMessage.Text = message;　//引数で渡された文字列をテキストボックスにセット
        }

        /// <summary>
        /// OKボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOK_Click(object sender, RoutedEventArgs e)
        {
            //ダイアログの戻り値として true をセット
            DialogResult = true;
        }

        /// <summary>
        /// キャンセルボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void uxCancel_Click(object sender, RoutedEventArgs e)
        {
            //ダイアログの戻り値戻り値としてfalseをセット
            DialogResult = false;
        }
    }
}
