using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Employees
    {
        #region Nhóm các thuộc tính của Employees
        private int _id;
        private string _id_card;
        private string _name;
        private string _email;
        private string _phone;
        #endregion
        #region Nhóm các constructore của Employees
        public Employees()
        {
            this._id = 0;
            IdCard = "0000";
            this._name="Chưa xác định";
        }
        public Employees(int _id, string _id_card, string _name, string _email, string _phone)
        {
            this._id = _id;
            this._id_card = _id_card;
            this._name = _name;
            Email = _email;
            Phone = _phone;
        }
        #endregion
        #region Nhóm các properties của E
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string IdCard
        {
            get { return _id_card; }
            set { _id_card = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        } 
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        #endregion

        #region Nhóm các methods của Employees
        public void PrintInfo()
        {
            string message = $"{Id}\t{IdCard}\t{Name}\t{Email}\t{Phone}";
            Console.WriteLine(message);
        }
        public override string ToString()
        {
            string message = $"{Id}\t{IdCard}\t{Name}\t{Email}\t{Phone}";
            return message;
        }
        #endregion
    }
}
