using Business.Abstract;

namespace WindowsFormUI.Views.Moduls.CekSenetler
{
    public partial class FrmMusteriyeEvrakCik : FrmBase
    {
        ICekSenetBordroService _cekSenetBordroService;
        ICariService _cariService;
        public FrmMusteriyeEvrakCik(ICekSenetBordroService cekSenetBordroService, ICariService cariService)
        {
            InitializeComponent();
            _cekSenetBordroService = cekSenetBordroService;
            _cariService = cariService;
        }
    }
}