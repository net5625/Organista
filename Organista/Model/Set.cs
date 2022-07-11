using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Organista.Model
{
    /// <summary>
    /// Klasa reprezentująca zestaw.
    /// </summary>
    internal class Set
    {
        /// <summary>
        /// Identyfikator zestawu.
        /// </summary>
        [Key]
        public ulong ID { get; set; }
        /// <summary>
        /// Data dodania zestawu.
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Nazwa zestawu
        /// </summary>
        public SetName Name { get; set; }
        /// <summary>
        /// Pieśni, których dotyczy zestaw.
        /// </summary>
        public ICollection<Canto> Cantos { get; set; }
    }
}
