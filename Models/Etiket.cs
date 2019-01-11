using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Etiket
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int etiketID { get; set; }
    public string etiketAd { get; set; }
    public int muzikID { get; set; }
    public Muzik muzik { get; set; }
}