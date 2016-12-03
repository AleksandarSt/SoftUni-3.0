using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GringotsDB.Models
{
    [ComplexType]
    public class MagicWand
    {
        [MaxLength(100)]
        public string MagicWandCreator { get; set; }

        [Range(0, short.MaxValue)]
        public int MagicWandSize { get; set; }
    }
}
