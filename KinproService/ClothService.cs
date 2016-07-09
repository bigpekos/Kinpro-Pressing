using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinproService
{
    public class ClothService : IClothService
    {
        KinproPressingEntities _KinproPressingEntitie;

        public ClothService()
        {
            _KinproPressingEntitie = new KinproPressingEntities();
        }

        public List<GetAllClothsSetting_Result> GetAllClothsSetting()
        {
            ObjectResult<GetAllClothsSetting_Result> order = _KinproPressingEntitie.GetAllClothsSetting();
            return order.ToList();
        }


        public void AddCloth(string name, int price, string ClothDescription)
        {
            _KinproPressingEntitie.AddCloth(name, price, ClothDescription);
        }

        public void UpdateCloth(string name, int itemId, int price, string clothDescription, int clientId)
        {
            _KinproPressingEntitie.UpdateCloth(name, itemId, price, clothDescription, clientId);
        }

        public void DeleteCloth(int id)
        {
            _KinproPressingEntitie.DeleteCloth(id);
        }
    }
}
