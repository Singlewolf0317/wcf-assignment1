﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFAssignment1Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string CheckPrime(int number);
        [OperationContract]
        int SumDigits(int number);
        [OperationContract]
        string ReverseString(string word);
        [OperationContract]
        string PrintHTMLTag(string tag, string data);
        [OperationContract]
        string SortNumbers(string sort, string numbers);
    }
}
