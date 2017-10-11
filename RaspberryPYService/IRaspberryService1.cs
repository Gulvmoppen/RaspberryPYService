using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RaspberryPYService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRaspberryService1" in both code and config file together.
    [ServiceContract]
    public interface IRaspberryService1
    {

        [OperationContract]
        int Light(int lys);

        [OperationContract]
        int Analog(int anal);
        [OperationContract]
        int Tempreture(int temp);

        [OperationContract]
        int Potentiometer(int potent);


    }




}
