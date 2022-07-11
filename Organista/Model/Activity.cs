using System;
using System.ComponentModel.DataAnnotations;

namespace Organista.Model
{
    /// <summary>
    /// Klasa reprezentująca pojedyńczą aktywność użytkownika - organisty.
    /// </summary>
    internal class Activity
    {
        /// <summary>
        /// Identyfikator rekordu.
        /// </summary>
        [Key]
        public ulong ID { get; set; }
        /// <summary>
        /// Data dodania aktywności.
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Ilość mszy.
        /// </summary>
        public byte Mass { get; set; } = (byte)0;
        /// <summary>
        /// Ilość Nabożeństw.
        /// </summary>
        public byte Devotion { get; set; } = (byte)0;
        /// <summary>
        /// Ilość godzinek.
        /// </summary>
        public byte Hours { get; set; } = (byte)0;
        /// <summary>
        /// Ilość dróg krzyżowych.
        /// </summary>
        public byte Cross { get; set; } = (byte)0;
        /// <summary>
        /// Ilość Nabożeństw Pasyjnych - Gorzkich żali.
        /// </summary>
        public byte Bitter { get; set; } = (byte)0;
        /// <summary>
        /// Ilość pogrzebów.
        /// </summary>
        public byte Funeral { get; set; } = (byte)0;
        /// <summary>
        /// Ilość ślubów.
        /// </summary>
        public byte Wedding { get; set; } = (byte)0;
    }
}
