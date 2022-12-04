namespace Entities.UserDefinedType
{
    /// <summary>
    /// Fatura tablosunda yer alan Tür alanı için Veri Tipi
    /// </summary>
    public class FaturaTur
    {
        private string _faturaTur;
        public FaturaTur Tur { get => _faturaTur; }
        public FaturaTur()
        {
            _faturaTur = "Satış Faturası";
        }
        public FaturaTur(FaturaTur faturaTur)
        {
            _faturaTur = faturaTur;
        }
        public FaturaTur(string faturaTur)
        {
            _faturaTur = faturaTur;
        }
        public FaturaTur(int faturaTur)
        {
            _faturaTur = faturaTur < 0 ? "Satış Faturası" : "Alış Faturası";
        }
        public FaturaTur(bool faturaTur)
        {
            _faturaTur = !faturaTur ? "Satış Faturası" : "Alış Faturası";
        }
        public static implicit operator bool(FaturaTur fatura) => fatura == "Alış Faturası";
        public static implicit operator string(FaturaTur fatura) => !fatura ? "Satış Faturası" : "Alış Faturası";
        public static implicit operator int(FaturaTur fatura) => !fatura ? -1 : 1;
        public static implicit operator FaturaTur(bool trueFalse) => !trueFalse ? new FaturaTur() : new FaturaTur(1);
        public static implicit operator FaturaTur(string metin) => metin == "Satış Faturası" ? new FaturaTur() : new FaturaTur(1);
        public static implicit operator FaturaTur(int sayi) => sayi == -1 ? new FaturaTur() : new FaturaTur(1);
    }
}