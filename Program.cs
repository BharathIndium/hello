using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace face_book
{
    class Program
    {
        

			string firstname;
			string lastname;
			string emailid;
			long mobileno;

        public string Firstname { get => firstname; set => firstname = value; }
		public string Lastname { get => lastname; set => lastname = value; }
		public string Emailid { get => emailid; set => emailid = value; }
		public long Mobileno { get => mobileno; set => mobileno = value; }

		public override bool Equals(object obj)
		{
			FACEBOOK F = (FACEBOOK)obj;
			return this.Emailid.Equals(F.Emailid) && this.Mobileno.Equals(F.Mobileno);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		public override string ToString()
		{
			return string.Format("Firstname : {0}\nLastName : {1}\nEmail : {2}\nMobileno: {3}", Firstname, Lastname, Emailid, Mobileno);
		}
    }
}
