using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.Data.SqlClient;
using System.Data;

namespace BEL
{
    public class BEL_HOADON
    {
        private string _IDHD;
        private string _IDNV;
        private string _IDKH;
        private string _Ngaylap;
        private string _GioLap;
        private int _TongTien;
        public BEL_HOADON()
        {
            _IDHD = null;
            _IDNV = null;
            _IDKH = null;
            _Ngaylap = null;
            _GioLap = null;
        }
        public BEL_HOADON(DataRow row)
        {
            this._IDHD = row["IDHD"].ToString();
            this._IDNV = row["IDNV"].ToString();
            this._Ngaylap = row["Ngaylap"].ToString();
            this._GioLap = row["GioLap"].ToString();
            this._TongTien = (int)row["TongTien"];
        }
        public BEL_HOADON(string idhd,string idnv, string idkh, string ngaylap)
        {
            this._IDHD = idhd;
            this._IDNV = idnv;
            this._IDKH = idkh;
            this._Ngaylap = ngaylap;
        }
        public string IDHD
        {
            get { return this._IDHD; }
            set { this._IDHD = value; }
        }
        public string IDNV
        {
            get { return this._IDNV; }
            set { this._IDNV = value; }
        }
        public string IDKH
        {
            get { return this._IDKH; }
            set { this._IDKH = value; }
        }
        public string NGAYLAP
        {
            get { return this._Ngaylap; }
            set { this._Ngaylap = value; }
        }
        public string GIOLAP
        {
            get { return this._GioLap; }
            set { this._GioLap = value; }
        }
        public int TONGTIEN
        {
            get { return this._TongTien; }
            set { this._TongTien = value; }
        }
    }
}
