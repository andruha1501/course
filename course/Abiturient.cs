using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    class Abiturient
    {
        public string Surname;
        public string Name;
        public string LastName;

        public string Birthday;
        public string Nationality;

        public string PlaceLive;

        public string Document;
        public string NumberDocument;

        public string NumberTelefone;
        public string Email;

        public string Average;
        public string Subject1;
        public string Subject2;
        public string Subject3;
        public int Complex;
        public string PlusComplex;
        public string Contract;

        public void SortAbit(List<Abiturient> a) 
        {
            for (int i = 0; i < a.Count; i++)
            {
                for (int k = i + 1; k < a.Count - 1; k++)
                {
                    if (String.Compare(a[i].Surname, a[k].Surname) == 1)
                    {
                        Abiturient j = a[i];
                        a[i] = a[k];
                        a[k] = j;
                    }
                }
            }
        }
    }
}
