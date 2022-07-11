using System.ComponentModel.DataAnnotations;

namespace Organista.Model
{
    /// <summary>
    /// Klasa zawierająca nazwy zestawów.
    /// </summary>
    internal class SetName
    {
        /// <summary>
        /// Identyfikator nazwy.
        /// </summary>
        [Key]
        public ulong ID { get; set; }
        /// <summary>
        /// Nazwa zestawu.
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}
