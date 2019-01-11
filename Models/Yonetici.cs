using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Yonetici
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int adminID { get; set; }
    public string username { get; set; }
    public string password { get; set; }

}