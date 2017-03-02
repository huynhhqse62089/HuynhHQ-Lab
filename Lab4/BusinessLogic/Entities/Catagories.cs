using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public class Catagories
    {
        private string catagoryId;
        private string catagoryName;
        private string description;
        private string picture;

        public string Picture
        {
            get { return picture; }
            set { picture = value; }
        }


        public string Description
        {
            get { return description; }
            set { description = value; }
        }


        public string CatagoryName
        {
            get { return catagoryName; }
            set { catagoryName = value; }
        }

        public string CatagoryId
        {
            get { return catagoryId; }
            set { catagoryId = value; }
        }

    }
}
