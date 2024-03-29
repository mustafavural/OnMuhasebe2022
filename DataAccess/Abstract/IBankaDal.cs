﻿using Core.DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IBankaDal : IEntityRepository<Banka>
    {
        decimal GetHesapBakiye(int hesapId);
        bool KontrolHesapKullaniliyorMu(int id);
    }
}
