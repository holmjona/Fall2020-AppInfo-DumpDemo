using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DumpDemo.Models {
    public static class DAL {
        private static List<Reference> _FakeDatabase;


        public static List<Reference> ReferencesGet() {
            if (_FakeDatabase == null) {
                BuildStartingLibrary();
            }

            return _FakeDatabase;
        }

        public static Reference ReferenceGet(int id) {
            if (_FakeDatabase == null) {
                BuildStartingLibrary();
            }
            Reference retRef = null;
            foreach (Reference reff in _FakeDatabase) {
                if (reff.ID == id) {
                    retRef = reff;
                }
            }

            return retRef;
        }

        private static void BuildStartingLibrary() {
            _FakeDatabase = new List<Reference>();
            _FakeDatabase.Add(new Reference("Nintendo Power") { ID = 1 });
            _FakeDatabase.Add(new Book("Nancy Drew","Some",1945,"Ida Know") { ID = 2 });
            _FakeDatabase.Add(new Book("Three Investigators","Ano",1975,"") { ID = 4 });
            _FakeDatabase.Add(new AudioBook() {Title = "Encyclopedia Brown", ID = 5 });
        }

        public static int ReferenceAdd(Reference refToAdd) {

            if (refToAdd.Year <= DateTime.Now.Year) {
                Reference newRef = new Reference();
                newRef.Title = refToAdd.Title;
                newRef.Publisher = refToAdd.Publisher;
                newRef.Year = refToAdd.Year;
                newRef.ID = maxID(_FakeDatabase);

                _FakeDatabase.Add(newRef);

                return 1;
            } else {
                return 0;
            }

        }

        public static int maxID(List<Reference> db) {
            int max = 1;
            foreach(Reference reff in db) {
                if (max < reff.ID) {
                    max = reff.ID;
                }
            }
            return max;
        }

    }
}