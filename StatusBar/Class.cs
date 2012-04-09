using System.Windows;
using Microsoft.Phone.Shell;

namespace StatusBarUtil
{
    public class StatusBar
    {
        static ProgressIndicator sysProg = new ProgressIndicator();

        #region フィールド
        static public bool isVisible
        {
            get
            {
                return sysProg.IsVisible;
            }
        }

        static public double Value
        {
            get
            {
                return sysProg.Value;
            }
        }

        static public string Text
        {
            get
            {
                return sysProg.Text;
            }
        }

        static public bool isIndeterminate
        {
            get
            {
                return sysProg.IsIndeterminate;
            }
        }
        #endregion

        #region メソッド
        /// <summary>
        /// ステータスバーにメッセージを表示します。
        /// </summary>
        /// <param name="t">ステータスバーを設定するページ（たぶんthis）</param>
        /// <param name="mes">表示するメッセージ</param>
        public static void ShowStatusBar(object t, string mes)
        {
            sysProg.Text = mes;
            sysProg.IsIndeterminate = false;
            sysProg.IsVisible = true;
            SystemTray.SetProgressIndicator((DependencyObject)t, sysProg);
        }

        /// <summary>
        /// ステータスバーにメッセージと処理が進行中であることをを表示します。
        /// </summary>
        /// <param name="t">ステータスバーを設定するページ（たぶんthis）</param>
        /// <param name="mes">表示するメッセージ</param>
        /// <param name="isIndeterminate">進行中かどうか</param>
        public static void ShowStatusBar(object t, string mes, bool isIndeterminate)
        {
            sysProg.Text = mes;
            sysProg.IsIndeterminate = isIndeterminate;
            sysProg.IsVisible = true;
            sysProg.Value = 0;
            SystemTray.SetProgressIndicator((DependencyObject)t, sysProg);
        }

        /// <summary>
        /// ステータスバーにメッセージと処理が進行中であることをを表示します。
        /// </summary>
        /// <param name="t">ステータスバーを設定するページ（たぶんthis）</param>
        /// <param name="mes">表示するメッセージ</param>
        /// <param name="value">進捗度（0-100）</param>
        public static void ShowStatusBar(object t, string mes, int value)
        {
            sysProg.Text = mes;
            sysProg.IsIndeterminate = false;
            sysProg.IsVisible = true;
            sysProg.Value = value;
            SystemTray.SetProgressIndicator((DependencyObject)t, sysProg);
        }

        /// <summary>
        /// ステータスバーの表示を制御します。
        /// </summary>
        /// <param name="t">ステータスバーを設定するページ（たぶんthis）</param>
        /// <param name="isShow">表示するかどうか</param>
        public static void ShowStatusBar(object t, bool isShow)
        {
            sysProg.IsVisible = isShow;
            SystemTray.SetProgressIndicator((DependencyObject)t, sysProg);
        }
        #endregion
    }
}
