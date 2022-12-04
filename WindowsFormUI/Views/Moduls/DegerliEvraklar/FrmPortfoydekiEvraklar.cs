using Business.Abstract;

namespace WindowsFormUI.Views.Moduls.DegerliEvraklar
{
    public partial class FrmPortfoydekiEvraklar : FrmBase
    {
        IDegerliEvrakService _degerliEvrakService;
        ICariService _cariService;
        public bool SecimIcin { get;set; }
        
        public FrmPortfoydekiEvraklar(IDegerliEvrakService degerliEvrakService, ICariService cariService)
        {
            InitializeComponent();
            _degerliEvrakService = degerliEvrakService;
            _cariService = cariService;
            SecimIcin = false;
        }

    }
}