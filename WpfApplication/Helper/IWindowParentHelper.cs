using System;
using System.Windows;

using WpfApplication.Ui.Common;

namespace WpfApplication.Helper
{
    public interface IWindowParentHelper
    {
        /// <summary>
        ///   Liefert ein Fenster anhand eines Typen.
        /// </summary>
        /// <param name="type"> </param>
        /// <returns> </returns>
        Window GetWindowBySpecificType(Type type);

        /// <summary>
        ///   Fügt ein Fenster zur Auflistung hinzu.
        /// </summary>
        /// <param name="window"> </param>
        void RegisterWindow(Window window);

        /// <summary>
        ///   Entfernt ein Fenster aus der Auflistung.
        /// </summary>
        /// <param name="window"> </param>
        void RemoveWindow(Window window);

        void SetOwner<T>(IWindow window);
    }
}