using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Kullanici
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int kullaniciID { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public string ad { get; set; }
    public string soyad { get; set; }
    public string mail { get; set; }
    public List<Yorum> yorums;
}