using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Muzik
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int muzikID { get; set; }
    public string muzikAd { get; set; }
    public string sozler { get; set; }
    
    public int sanatciID { get; set; }
    public Sanatci sanatci { get; set; }
    public List<Yorum> yorums { get; set; }
    public List<Etiket> etikets { get; set; }
}