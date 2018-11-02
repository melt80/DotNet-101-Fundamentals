using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Exercise
{
    public class MenuRepository
    {
        private List<MenuItem> _menuRepository = new List<MenuItem>();

        public void AddMenuItemToList(MenuItem item)
        {
            _menuRepository.Add(item);
        }

        public List<MenuItem> GetList()
        {
            return _menuRepository;
        }

        //public string Message(Customer customer)
        //{
        //    var message = "";

        //    if (customer.YearsWithKomodo < 1)
        //        message = "New Customer Added.";
        //    else if (customer.YearsWithKomodo >= 1)
        //        message = "You entered a legacy customer.";
        //    return message;
        //}
    }
}
