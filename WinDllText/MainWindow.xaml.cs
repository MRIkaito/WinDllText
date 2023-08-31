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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MyMessageBox;

namespace WinDllText
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }


        //=========================================================
        //  ボタンのイベントハンドラ
        //=========================================================
        /// <summary>
        /// メッセージダイアログの表示ボタンクリック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCallMessageDialog_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog("実行してもよろしいですか？");
        }


        /// <summary>
        /// 入力ダイアログの表示ボタンのクリック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCallImputDialog_Click(object sender, RoutedEventArgs e)
        {
            uxGetMessage.Text = ImputDialog(uxGetMessage.Text);
        }


        //=========================================================
        //  ダイアログ表示用メソッド
        //=========================================================
        /// <summary>
        /// メッセージダイアログの表示
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private bool MessageDialog(string str)
        {
            return (bool)(new MessageDialog(this, str).ShowDialog());
        }


        /// <summary>
        /// 入力ダイアログの表示
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string ImputDialog(string str)
        {
            var dialog = new ImputDialog(this, str);

            return ((bool)dialog.ShowDialog()) ? dialog.Text : str;
        }

    }
}
