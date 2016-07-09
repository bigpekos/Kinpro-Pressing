using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace KinproService
{
    [ServiceContract]
    public interface IClothService
    {

        [OperationContract]
        List<GetAllClothsSetting_Result> GetAllClothsSetting();

        [OperationContract]
        void AddCloth(string name, int price, string ClothDescription);

        [OperationContract]
        void UpdateCloth(string name, int itemId, int price, string clothDescription, int clientId);

        [OperationContract]
        void DeleteCloth(int id);


    }
}
