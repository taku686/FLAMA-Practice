using UnityEngine;

namespace Sample.Memento.Sample2
{
    /// <summary>
    /// テキストエディタ
    /// メメントの作成とメメントからの状態の復元を行う
    /// </summary>
    public class TextEditor
    {
        /// <summary>
        /// テキスト
        /// </summary>
        private string m_Text = string.Empty;

        /// <summary>
        /// テキストの追記
        /// </summary>
        /// <param name="text">追記するテキスト</param>
        public void AppendText(string text)
        {
            m_Text += text;
        }

        /// <summary>
        /// テキストの表示
        /// </summary>
        public void PrintText()
        {
            Debug.Log(m_Text);
        }

        /// <summary>
        /// 現在のテキストエディタの状態を表すメメントを作成する
        /// </summary>
        /// <returns>作成したメメント</returns>
        public TextEditorMemento CreateMemento()
        {
            return new TextEditorMemento(m_Text);
        }

        /// <summary>
        /// メメントからテキストエディタの状態を復元する
        /// </summary>
        /// <param name="memento">テキストエディタのメメント</param>
        public void SetMemento(TextEditorMemento memento)
        {
            m_Text = memento.Text;
        }
    }
}