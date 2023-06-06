using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComponentsLibrary.Services
{
    public class ToastService
    {
        public event Action<string, string, ToastLevel>? OnShow;
        public event Action? OnHide;


        public void Show(string title, string message, ToastLevel level)
        {
            OnShow?.Invoke(title, message, level);
        }

        public void Hide()=> OnHide?.Invoke();

    }
}
