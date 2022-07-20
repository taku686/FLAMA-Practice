using System;
using UnityEngine;

namespace Sample.Memento.Sample2
{
    public class Client : MonoBehaviour
    {
        private void Start()
        {
            // テキストエディタとスナップショットマネージャの作成
            var editor = new TextEditor();
            var snapShotManager = new TextEditorSnapShotManager(editor);

            // テキストの追記
            editor.AppendText("A");

            // スナップショットの保存
            snapShotManager.SaveSnapShot("FirstSnapShot");

            // さらにテキストを追加
            editor.AppendText("B");

            // 表示
            editor.PrintText();

            // スナップショットから状態を復元
            if (snapShotManager.LoadSnapShot("FirstSnapShot"))
            {
                // 復元後の状態でテキストを表示
                editor.PrintText();
            }
        }
    }
}