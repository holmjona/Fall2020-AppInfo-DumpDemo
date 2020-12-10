using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DumpDemo.Models {
    public class Reference {
        private string _Title = "I have none";
        private int _Year = 0;
        //private int _Age = 0;
        private string _Publisher;

        public Reference() {
            Title = "None";
            //this.Publisher = "No One";
            //this.Magic = "nou";
        }

        public Reference(string title) {
            Title = title;
        }

        public Reference(string title = "None", string pub = "No One") {
            Title = title;
            Publisher = pub;
        }

        public Reference(string pub, int year = 0) {
            Publisher = pub;
        }

        public string Title {
            get {
                return this._Title;
            }
            set {
                _Title = value.Trim();
            }
        }

        public string Publisher {
            get {
                return _Publisher;
            }
            set {
                _Publisher = value.Trim();
            }
        }

        public int Year {
            get {
                return _Year;
            }
            set {
                _Year = value;
                //_Age = DateTime.Now.Year - Year;
            }
        }

        public int Age {
            get {
                // return _Age;
                return DateTime.Now.Year - Year;
            }
            //set {
            //    if (value < 0) {
            //        _Age = 0;
            //    } else if (value > 900) {
            //        _Age = 900;
            //    } else {
            //        _Age = value;
            //    }
            //}
        }


        public void DoSomething() {
            Title = "My Book";
            //return 3;
        }

        //def __str__(self):
        //    return "I am me"

        //public override string ToString() {
        //    return "something";
        //}

    }
}
