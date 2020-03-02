using Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IUye
    {
        
        int insert(string sqlCumlesi);
        int insertOlcu(string sqlCumlesi);
        void delete(string sqlCumlesi);
        void update(string sqlCumlesi);

        List<UyeDTO> uyeListesi(string sqlCumlesi);
        List<VucutDTO> olcuListesi(string sqlCumlesi);
    }
}
