using System.ComponentModel.DataAnnotations;

public class QRCodeModel
{
    [Display(Name = "Enter QR Code Text")]
    public string QRCodeText { get; set; }
}