/**************************************************
 * File:            CTracer.cs
 * Create Date:     28.11.2007
 * Author:          Tomasz Bator
 **************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ANRTournament.Objects
{
    /// <summary>
    /// Abstrakcyjna klasa zawieraj�ca funkcje do zapisywania log�w do pliku
    /// </summary>
    public abstract class Tracer
    {
        private static int iGlobalTraceLevel = 0;
        /// <summary>
        /// Globalna granica poziom trace'�w 
        /// (trace'y z poziomem wy�szym nie b�d� wpisywane)
        /// </summary>
        public static int GlobalTraceLevel
        {
            get { return iGlobalTraceLevel; }
            set { iGlobalTraceLevel = value; }
        }

        /// <summary>
        /// Funkcja wpisuj�ca do pliku podan� tre�� trace'a
        /// </summary>
        /// <param name="Level">Poziom wstawianego trace'a</param>
        /// <param name="TraceString">Tre�� wstawianego typu string</param>
        public static void PutTrace(int Level, string TraceString)
        {
            if (Level > iGlobalTraceLevel) return;

            string sTraceFilePath = String.Format("Trace_{0}.txt", DateTime.Now.ToShortDateString().Replace(':', '_').Replace('-', '_'));
            StreamWriter sr = new StreamWriter(sTraceFilePath, true);
            sr.WriteLine(String.Format("{0}:{1}    {2}", DateTime.Now, DateTime.Now.Millisecond, TraceString));
            sr.Close();
        }

        /// <summary>
        /// Funkcja wpisuj�ca do pliku podan� tre�� trace'a
        /// </summary>
        /// <param name="Level">Poziom wstawianego trace'a</param>
        /// <param name="TraceString">Tre�� wstawianego trace'a typu string</param>
        /// <param name="TraceInt">Tre�� wstawianego trace'a typu int</param>
        public static void PutTrace(int Level, string TraceString, int TraceInt)
        {
            if (Level > iGlobalTraceLevel) return;

            string sTraceFilePath = String.Format("Trace_{0}.txt", DateTime.Now.ToShortDateString().Replace(':', '_').Replace('-', '_'));
            StreamWriter sr = new StreamWriter(sTraceFilePath, true);
            sr.WriteLine(String.Format("{0}:{1}    {2} {3}", DateTime.Now, DateTime.Now.Millisecond, TraceString, TraceInt));
            sr.Close();
        }
    }
}
