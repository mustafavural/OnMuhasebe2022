using Business.Abstract;

namespace WindowsFormUI.Views.Moduls.CekSenetler
{
    public partial class FrmPortfoydekiEvraklar : FrmBase
    {
        ICekSenetBordroService _cekSenetBordroService;
        ICariService _cariService;
        public bool SecimIcin { get;set; }
        
        public FrmPortfoydekiEvraklar(ICekSenetBordroService cekSenetBordroService, ICariService cariService)
        {
            InitializeComponent();
            _cekSenetBordroService = cekSenetBordroService;
            _cariService = cariService;
            SecimIcin = false;
        }

    }
}