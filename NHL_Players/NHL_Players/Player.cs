using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL_Players
{
    class Player
    {
        public Player(string Name, string Team, string Pos, double Gp, double G, double A, double P, double PlusMinus, double Pim, double Pgp, double Ppg, double Ppp, double Shg, double Shp, double Gwg, double Otg, double S, double SRate, string ToiGp, double Shifts, double Fow)
        {
            this.NAME = Name;
            this.TEAM = Team;
            this.POS = Pos;
            this.GP = Gp;
            this.G = G;
            this.A = A;
            this.P = P;
            this.PlusMinus = PlusMinus;
            this.PIM = Pim;
            this.PGP = Pgp;
            this.PPG = Ppg;
            this.PPP = Ppp;
            this.SHG = Shg;
            this.SHP = Shp;
            this.GWG = Gwg;
            this.OTG = Otg;
            this.S = S;
            this.SPERCENT = SRate;
            this.TOIGP = ToiGp;
            this.SHIFTS = Shifts;
            this.FOW = Fow;
        }

        public Player()
        {

        }


        private string _name;
        public string NAME
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private string _team;
        public string TEAM
        {
            get
            {
                return _team;
            }
            set
            {
                _team = value;
            }
        }

        private string _pos;
        public string POS
        {
            get
            {
                return _pos;
            }
            set
            {
                _pos = value;
            }
        }

        private double _gp;
        public double GP
        {
            get
            {
                return _gp;
            }
            set
            {
                _gp = value;
            }
        }

        private double _g;
        public double G
        {
            get
            {
                return _g;
            }
            set
            {
                _g = value;
            }
        }

        private double _a;
        public double A
        {
            get
            {
                return _a;
            }
            set
            {
                _a = value;
            }
        }

        private double _p;
        public double P
        {
            get
            {
                return _p;
            }
            set
            {
                _p = value;
            }
        }

        private double _plusMinus;
        public double PlusMinus
        {
            get
            {
                return _plusMinus;
            }
            set
            {
                _plusMinus = value;
            }
        }

        private double _pim;
        public double PIM
        {
            get
            {
                return _pim;
            }
            set
            {
                _pim = value;
            }
        }

        private double _pgp;
        public double PGP
        {
            get
            {
                return _pgp;
            }
            set
            {
                _pgp = value;
            }
        }

        private double _ppg;
        public double PPG
        {
            get
            {
                return _ppg;
            }
            set
            {
                _ppg = value;
            }
        }

        private double _ppp;
        public double PPP
        {
            get
            {
                return _ppp;
            }
            set
            {
                _ppp = value;
            }
        }

        private double _shg;
        public double SHG
        {
            get
            {
                return _shg;
            }
            set
            {
                _shg = value;
            }
        }

        private double _shp;
        public double SHP
        {
            get
            {
                return _shp;
            }
            set
            {
                _shp = value;
            }
        }

        private double _gwg;
        public double GWG
        {
            get
            {
                return _gwg;
            }
            set
            {
                _gwg = value;
            }
        }

        private double _otg;
        public double OTG
        {
            get
            {
                return _otg;
            }
            set
            {
                _otg = value;
            }
        }

        private double _s;
        public double S
        {
            get
            {
                return _s;
            }
            set
            {
                _s = value;
            }
        }

        private double _sRate;
        public double SPERCENT
        {
            get
            {
                return _sRate;
            }
            set
            {
                _sRate = value;
            }
        }

        private string _toiGp;
        public string TOIGP
        {
            get
            {
                return _toiGp;
            }
            set
            {
                _toiGp = value;
            }
        }

        private double _shifts;
        public double SHIFTS
        {
            get
            {
                return _shifts;
            }
            set
            {
                _shifts = value;
            }
        }

        private double _fow;
        public double FOW
        {
            get
            {
                return _fow;
            }
            set
            {
                _fow = value;
            }
        }
    }
}
