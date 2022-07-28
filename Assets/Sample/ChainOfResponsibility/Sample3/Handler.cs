using UnityEngine;

namespace Sample.ChainOfResponsibility.Sample3
{
    public abstract class Handler
    {
        private Handler _next;

        public Handler SetHandler(Handler handler)
        {
            _next = handler;
            return handler;
        }

        public virtual void Request(SomeTask task)
        {
            if (Resolve(task))
            {
                Debug.Log($"タスクが{this}によって処理されました");
            }
            else if (_next != null)
            {
                _next.Request(task);
            }
            else
            {
                Debug.Log("タスクを処理することができませんでした。");
            }
        }

        protected abstract bool Resolve(SomeTask task);
    }
}