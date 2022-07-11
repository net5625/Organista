using System.ComponentModel.DataAnnotations;

namespace Organista.Model
{
    /// <summary>
    /// Klasa reprezentująca pieśni.
    /// </summary>
    internal class Canto
    {
        /// <summary>
        /// Identyfikator pieśni.
        /// </summary>
        [Key]
        public ulong ID { get; set; }
        /// <summary>
        /// Nazwa pieśni.
        /// </summary>
        [Required,
            MaxLength(260, ErrorMessage = "To long name.")]
        public string Name { get; set; }
    }
}
