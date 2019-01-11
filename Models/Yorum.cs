using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Yorum
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int yorumID { get; set; }
    public string icerik { get; set; }
    public int muzikID { get; set; }
    public Muzik muzik { get; set; }
    public int kullaniciID { get; set; }
    public Kullanici kullanici { get; set; }
}