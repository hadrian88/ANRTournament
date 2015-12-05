using System;
using System.Collections.Generic;
using System.Text;
using Xceed.Wpf.Toolkit;
using System.Windows;

namespace ANRTournament
{
    /// <summary>
    /// Error Message
    /// </summary>
    public class PME
    {
        /// <summary>
        /// Konstruktor domy�lny
        /// </summary>
        private PME()
        {

        }

        /// <summary>
        /// Error Message
        /// </summary>
        /// <param name="sMsg">Tre�� message'a</param>
        public PME(string sMsg)
        {
            (new InfoWindow(sMsg, MessageBoxButton.OK, MessageBoxImage.Error)).ShowDialog();
            //Xceed.Wpf.Toolkit.MessageBox.Show(sMsg, Resources.StringTable.PM_Error, MessageBoxButton.OK, MessageBoxImage.Error);
        }

        ///// <summary>
        ///// Error Message
        ///// </summary>
        ///// <param name="sMsg">Tre�� message'a</param>
        ///// <param name="sTitle">Tytu� message'a</param>
        //public PME(string sMsg, string sTitle)
        //{
        //    Xceed.Wpf.Toolkit.MessageBox.Show(sMsg, sTitle, MessageBoxButton.OK, MessageBoxImage.Error);
        //}        

        /// <summary>
        /// Funkcja wyswietlaj�ca Error Message
        /// </summary>
        /// <param name="sMsg">Tre�� message'a</param>
        /// <param name="buttons">Przyciski message'a jakie maj� si� pojawi�</param>
        /// <returns>dialog result</returns>
        public static MessageBoxResult Show(string sMsg, MessageBoxButton buttons)
        {
            InfoWindow wnd = new InfoWindow(sMsg, buttons, MessageBoxImage.Error);
            wnd.ShowDialog();
            return wnd.Result;
        }
    }

    /// <summary>
    /// Warning Message
    /// </summary>
    public class PMW
    {
        /// <summary>
        /// Konstruktor domy�lny
        /// </summary>
        private PMW()
        {

        }

        /// <summary>
        /// Warning Message
        /// </summary>
        /// <param name="sMsg">Tre�� message'a</param>
        public PMW(string sMsg)
        {
            (new InfoWindow(sMsg, MessageBoxButton.OK, MessageBoxImage.Warning)).ShowDialog();
            //Xceed.Wpf.Toolkit.MessageBox.Show(sMsg, Resources.StringTable.PM_Warning, MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        ///// <summary>
        ///// Warning Message
        ///// </summary>
        ///// <param name="sMsg">Tre�� message'a</param>
        ///// <param name="sTitle">Tytu� message'a</param>
        //public PMW(string sMsg, string sTitle)
        //{
        //    Xceed.Wpf.Toolkit.MessageBox.Show(sMsg, sTitle, MessageBoxButton.OK, MessageBoxImage.Warning);
        //}

        /// <summary>
        /// Funkcja wyswietlaj�ca Warning Message
        /// </summary>
        /// <param name="sMsg">Tre�� message'a</param>
        /// <param name="buttons">Przyciski message'a jakie maj� si� pojawi�</param>
        /// <returns>dialog result</returns>
        public static MessageBoxResult Show(string sMsg, MessageBoxButton buttons)
        {
            InfoWindow wnd = new InfoWindow(sMsg, buttons, MessageBoxImage.Warning);
            wnd.ShowDialog();
            return wnd.Result;
        }
    }

    /// <summary>
    /// Info Message
    /// </summary>
    public class PMI
    {
        /// <summary>
        /// Konstruktor domyslny
        /// </summary>
        private PMI()
        {

        }

        /// <summary>
        /// Info Message
        /// </summary>
        /// <param name="sMsg">Tre�� message'a</param>
        public PMI(string sMsg)
        {
            (new InfoWindow(sMsg, MessageBoxButton.OK, MessageBoxImage.Information)).ShowDialog();
            //Xceed.Wpf.Toolkit.MessageBox.Show(sMsg, Resources.StringTable.PM_Information, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        ///// <summary>
        ///// Info Message
        ///// </summary>
        ///// <param name="sMsg">Tre�� message'a</param>
        ///// <param name="sTitle">Tytu� message'a</param>
        //public PMI(string sMsg, string sTitle)
        //{
        //    Xceed.Wpf.Toolkit.MessageBox.Show(sMsg, sTitle, MessageBoxButton.OK, MessageBoxImage.Information);
        //}

        /// <summary>
        /// Funkcja wyswietlaj�ca Info Message
        /// </summary>
        /// <param name="sMsg">Tre�� message'a</param>
        /// <param name="buttons">Przyciski message'a jakie maj� si� pojawi�</param>
        /// <returns>dialog result</returns>
        public static MessageBoxResult Show(string sMsg, MessageBoxButton buttons)
        {
            InfoWindow wnd = new InfoWindow(sMsg, buttons, MessageBoxImage.Information);
            wnd.ShowDialog();
            return wnd.Result;
            //return Xceed.Wpf.Toolkit.MessageBox.Show(sMsg, Resources.StringTable.PM_Information, buttons, MessageBoxImage.Information);
        }
    }
}
