using UnityEngine;

namespace Sample.Memento.Sample2
{
    public class TextEditorMemento 
    {
        /// <summary>
        /// テキスト
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="text"></param>
        public TextEditorMemento(string text)
        {
            Text = text;
        }
    }
}