using System.Collections.Generic;
using UnityEngine;

namespace Sample.Memento.Sample2
{
    public class TextEditorSnapShotManager
    {
        /// <summary>
        /// 管理するテキストエディタ
        /// </summary>
        private TextEditor m_Editor;

        /// <summary>
        /// スナップショットを管理するためのディクショナリ
        /// 名前を付けてスナップショットを保持する
        /// </summary>
        private Dictionary<string, TextEditorMemento> m_MementoDictionary = new Dictionary<string, TextEditorMemento>();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="editor">管理するテキストエディタ</param>
        public TextEditorSnapShotManager(TextEditor editor)
        {
            m_Editor = editor;
        }

        /// <summary>
        /// 名前を付けてスナップショットを保存する
        /// </summary>
        /// <param name="snapShotName">スナップショット名</param>
        public void SaveSnapShot(string snapShotName)
        {
            m_MementoDictionary.Add(snapShotName, m_Editor.CreateMemento());
        }

        public bool LoadSnapShot(string snapShotName)
        {
            if (m_MementoDictionary.ContainsKey(snapShotName) == false)
            {
                return false;
            }

            m_Editor.SetMemento(m_MementoDictionary[snapShotName]);
            return true;
        }
    }
}