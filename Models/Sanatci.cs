using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Sanatci
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int sanatciID { get; set; }
    public string sanatciAd { get; set; }
    public List<Muzik> muziks { get; set; }
}