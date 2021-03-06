//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICalculatorService")]
public interface ICalculatorService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Add", ReplyAction="http://tempuri.org/ICalculatorService/AddResponse")]
    int Add(int a, int b);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Add", ReplyAction="http://tempuri.org/ICalculatorService/AddResponse")]
    System.Threading.Tasks.Task<int> AddAsync(int a, int b);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Square", ReplyAction="http://tempuri.org/ICalculatorService/SquareResponse")]
    int Square(int a);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Square", ReplyAction="http://tempuri.org/ICalculatorService/SquareResponse")]
    System.Threading.Tasks.Task<int> SquareAsync(int a);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Ping", ReplyAction="http://tempuri.org/ICalculatorService/PingResponse")]
    void Ping();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Ping", ReplyAction="http://tempuri.org/ICalculatorService/PingResponse")]
    System.Threading.Tasks.Task PingAsync();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ICalculatorServiceChannel : ICalculatorService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class CalculatorServiceClient : System.ServiceModel.ClientBase<ICalculatorService>, ICalculatorService
{
    
    public CalculatorServiceClient()
    {
    }
    
    public CalculatorServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public CalculatorServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalculatorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalculatorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public int Add(int a, int b)
    {
        return base.Channel.Add(a, b);
    }
    
    public System.Threading.Tasks.Task<int> AddAsync(int a, int b)
    {
        return base.Channel.AddAsync(a, b);
    }
    
    public int Square(int a)
    {
        return base.Channel.Square(a);
    }
    
    public System.Threading.Tasks.Task<int> SquareAsync(int a)
    {
        return base.Channel.SquareAsync(a);
    }
    
    public void Ping()
    {
        base.Channel.Ping();
    }
    
    public System.Threading.Tasks.Task PingAsync()
    {
        return base.Channel.PingAsync();
    }
}
