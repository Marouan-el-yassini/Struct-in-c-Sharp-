using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_In_C_
{
    internal class Program
    {
        public struct Name
        {
            private  string fname, mname ,lname;
            public Name(string first, string middle, string last)
            {
                fname = first;
                mname = middle;
                lname = last;
            }
            public string firstname
            {
                get { return fname; }
                set { fname = firstname; }
            }
            public string middlename
            {
                get { return mname; }
                set { mname = middlename; }
            }
            public string lastname
            {
                get { return lname; }
                set { lname = lastname; }
            }
            public override string ToString()
            {
                return (string.Format("{0} {1} {2}", fname, mname, lname));
            }
            public string Initials()
            {
                return (string.Format("{0} {1} {2}", fname.Substring(0,1), mname.Substring(0,1), lname.Substring(0,1)));
            }
        }
        public class NameTest
        {
            static void Main(string[] args)
            {
                Name myName = new Name("Marouan", "El", "Yassini");
                string fullName, inits;
                fullName = myName.ToString();
                inits = myName.Initials();
                Console.WriteLine("My Name Is {0}", fullName);
                Console.WriteLine("My initial are {0}", inits);

            }
        }
    }
}
