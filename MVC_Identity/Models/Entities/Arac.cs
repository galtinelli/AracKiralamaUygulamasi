using MVC_Identity.Models.Enums;

namespace MVC_Identity.Models.Entities
{
    //Modeli,Marka,Rengi,UretimYili,ModelPaketi,SilindirHacmi(1600),BeygirGucu(98hp),VitesTipi,YakıtTipi,AracTipi
    public class Arac
    {
        //Trafiğe çıkan her araçta şase numarası olması gerekir. Aracın hangi yıl yapıldığı, hangi marka tarafından kaçıncı üretim evresinde yapıldığı, motor tipi, fabrikadan çıkan kaçıncı araç olduğu hakkında tüm bilgilere şase numarası üzerinden ulaşılır. 17 hane içinde hem harf hem de rakam bulunan bir koddur.
        public string AracSaseNo { get; set; }
        public string Renk { get; set; }
        public bool SunRoofDurumu { get; set; }
        public bool OtomatikKlimaDurumu { get; set; }
        public int UretimYili { get; set; }
        public string  MarkaKisaltmasi { get; set; }
        public Marka Marka { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public int ModelPaketId { get; set; }
        public ModelPaket ModelPaket { get; set; }
        public SilindirTipi SilindirTipi { get; set; }
        public BeygirGucu BeygirGucu { get; set; }
        public VitesTipi VitesTipi { get; set; }
        public YakitTipi YakitTipi { get; set; }
        public AracTipi AracTipi { get; set; }
    }
}
