using System.ComponentModel.DataAnnotations;

namespace Otthonbazar.Data
{
    public enum AdvertisementType
    {
        [Display(Name = "Lakás")]
        Flat,
        [Display(Name = "Ház")]
        House,
        [Display(Name = "Nyaraló")]
        HolidayHouse,
        [Display(Name = "Építési telek")]
        BuildingPlot
    }
}