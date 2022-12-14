//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment1Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckPrime", ReplyAction="http://tempuri.org/IService1/CheckPrimeResponse")]
        string CheckPrime(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckPrime", ReplyAction="http://tempuri.org/IService1/CheckPrimeResponse")]
        System.Threading.Tasks.Task<string> CheckPrimeAsync(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SumDigits", ReplyAction="http://tempuri.org/IService1/SumDigitsResponse")]
        int SumDigits(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SumDigits", ReplyAction="http://tempuri.org/IService1/SumDigitsResponse")]
        System.Threading.Tasks.Task<int> SumDigitsAsync(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReverseString", ReplyAction="http://tempuri.org/IService1/ReverseStringResponse")]
        string ReverseString(string word);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReverseString", ReplyAction="http://tempuri.org/IService1/ReverseStringResponse")]
        System.Threading.Tasks.Task<string> ReverseStringAsync(string word);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrintHTMLTag", ReplyAction="http://tempuri.org/IService1/PrintHTMLTagResponse")]
        string PrintHTMLTag(string tag, string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrintHTMLTag", ReplyAction="http://tempuri.org/IService1/PrintHTMLTagResponse")]
        System.Threading.Tasks.Task<string> PrintHTMLTagAsync(string tag, string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortNumbers", ReplyAction="http://tempuri.org/IService1/SortNumbersResponse")]
        string SortNumbers(string sort, string numbers);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortNumbers", ReplyAction="http://tempuri.org/IService1/SortNumbersResponse")]
        System.Threading.Tasks.Task<string> SortNumbersAsync(string sort, string numbers);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Assignment1Client.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Assignment1Client.ServiceReference1.IService1>, Assignment1Client.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string CheckPrime(int number) {
            return base.Channel.CheckPrime(number);
        }
        
        public System.Threading.Tasks.Task<string> CheckPrimeAsync(int number) {
            return base.Channel.CheckPrimeAsync(number);
        }
        
        public int SumDigits(int number) {
            return base.Channel.SumDigits(number);
        }
        
        public System.Threading.Tasks.Task<int> SumDigitsAsync(int number) {
            return base.Channel.SumDigitsAsync(number);
        }
        
        public string ReverseString(string word) {
            return base.Channel.ReverseString(word);
        }
        
        public System.Threading.Tasks.Task<string> ReverseStringAsync(string word) {
            return base.Channel.ReverseStringAsync(word);
        }
        
        public string PrintHTMLTag(string tag, string data) {
            return base.Channel.PrintHTMLTag(tag, data);
        }
        
        public System.Threading.Tasks.Task<string> PrintHTMLTagAsync(string tag, string data) {
            return base.Channel.PrintHTMLTagAsync(tag, data);
        }
        
        public string SortNumbers(string sort, string numbers) {
            return base.Channel.SortNumbers(sort, numbers);
        }
        
        public System.Threading.Tasks.Task<string> SortNumbersAsync(string sort, string numbers) {
            return base.Channel.SortNumbersAsync(sort, numbers);
        }
    }
}
