using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Entity;

namespace KitabeviApp.Data.EfCore.Abstract
{
    public interface IKitapRepository : IGenericRepository<Kitap>
    {
        //�uan burada IGenericRepository'den gelen Kitap i�in haz�rlanm�� CRUD metotlar� var.
        //E�er bir class IKitapRep.den miras al�rsa, t�m bu CRUD metotlar� da oraya implemente edilir.
        //Buraya ayr�ca yaz�lacak metotlar(a�a��daki gibi) sadece kitap entity'sine �zg� metotlard�r.
        List<Kitap> KategoriyeGoreKitapListesi(int id);
    }
}