using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class UserBUS
    {
        private static UserBUS instance;

        public static UserBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserBUS();
                return instance;
            }
        }

        private UserBUS() { }
        public void Xem(DataGridView data)
        {
            data.DataSource = UserDAO.Instance.Xem();
        }
        public bool Sua(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string id = row.Cells["ID"].Value.ToString();
            string name = row.Cells["Name"].Value.ToString();
            DateTime? dob = (DateTime?)row.Cells["DateOfBirth"].Value;
            string info = row.Cells["Info"].Value.ToString();
            bool? sex = (bool?)row.Cells["Sex"].Value;

            user User = new user();
            User.Name = name;
            User.Info = info;
            User.DateOfBirth = dob;
            User.Sex = sex;
            User.ID = id;
            return UserDAO.Instance.Sua(id, User);
        }
    }
}
