//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1.MyServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Add", ReplyAction="http://tempuri.org/IService1/AddResponse")]
        int Add(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Add", ReplyAction="http://tempuri.org/IService1/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Square", ReplyAction="http://tempuri.org/IService1/SquareResponse")]
        int Square(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Square", ReplyAction="http://tempuri.org/IService1/SquareResponse")]
        System.Threading.Tasks.Task<int> SquareAsync(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Ping", ReplyAction="http://tempuri.org/IService1/PingResponse")]
        void Ping();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Ping", ReplyAction="http://tempuri.org/IService1/PingResponse")]
        System.Threading.Tasks.Task PingAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ConsoleApplication1.MyServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ConsoleApplication1.MyServiceReference.IService1>, ConsoleApplication1.MyServiceReference.IService1 {
        
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
        
        public int Add(int a, int b) {
            return base.Channel.Add(a, b);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int a, int b) {
            return base.Channel.AddAsync(a, b);
        }
        
        public int Square(int a) {
            return base.Channel.Square(a);
        }
        
        public System.Threading.Tasks.Task<int> SquareAsync(int a) {
            return base.Channel.SquareAsync(a);
        }
        
        public void Ping() {
            base.Channel.Ping();
        }
        
        public System.Threading.Tasks.Task PingAsync() {
            return base.Channel.PingAsync();
        }
    }
}
