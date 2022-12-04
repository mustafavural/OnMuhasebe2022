using Business.Abstract;

namespace WindowsFormUI.Views.Moduls.DegerliEvraklar
{
    public partial class FrmMusteriyeEvrakCik : FrmBase
    {
        IDegerliEvrakService _degerliEvrakService;
        ICariService _cariService;
        public FrmMusteriyeEvrakCik(IDegerliEvrakService degerliEvrakService, ICariService cariService)
        {
            InitializeComponent();
            _degerliEvrakService = degerliEvrakService;
            _cariService = cariService;
        }
    }
}
