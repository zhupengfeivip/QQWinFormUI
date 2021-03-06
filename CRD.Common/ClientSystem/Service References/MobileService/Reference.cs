//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行库版本:2.0.50727.1433
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientSystem.MobileService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://api.showji.com/Locating/", ConfigurationName="MobileService.MobileSoap")]
    public interface MobileSoap {
        
        // CODEGEN: 命名空间 http://api.showji.com/Locating/ 的元素名称 Mobile 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://api.showji.com/Locating/Query", ReplyAction="*")]
        ClientSystem.MobileService.QueryResponse Query(ClientSystem.MobileService.QueryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.showji.com/Locating/GetStatus", ReplyAction="*")]
        bool GetStatus();
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueryRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Query", Namespace="http://api.showji.com/Locating/", Order=0)]
        public ClientSystem.MobileService.QueryRequestBody Body;
        
        public QueryRequest() {
        }
        
        public QueryRequest(ClientSystem.MobileService.QueryRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://api.showji.com/Locating/")]
    public partial class QueryRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Mobile;
        
        public QueryRequestBody() {
        }
        
        public QueryRequestBody(string Mobile) {
            this.Mobile = Mobile;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueryResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QueryResponse", Namespace="http://api.showji.com/Locating/", Order=0)]
        public ClientSystem.MobileService.QueryResponseBody Body;
        
        public QueryResponse() {
        }
        
        public QueryResponse(ClientSystem.MobileService.QueryResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://api.showji.com/Locating/")]
    public partial class QueryResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool QueryResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Province;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string City;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string AreaCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string PostCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Corp;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string Card;
        
        public QueryResponseBody() {
        }
        
        public QueryResponseBody(bool QueryResult, string Province, string City, string AreaCode, string PostCode, string Corp, string Card) {
            this.QueryResult = QueryResult;
            this.Province = Province;
            this.City = City;
            this.AreaCode = AreaCode;
            this.PostCode = PostCode;
            this.Corp = Corp;
            this.Card = Card;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface MobileSoapChannel : ClientSystem.MobileService.MobileSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class MobileSoapClient : System.ServiceModel.ClientBase<ClientSystem.MobileService.MobileSoap>, ClientSystem.MobileService.MobileSoap {
        
        public MobileSoapClient() {
        }
        
        public MobileSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MobileSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MobileSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MobileSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientSystem.MobileService.QueryResponse ClientSystem.MobileService.MobileSoap.Query(ClientSystem.MobileService.QueryRequest request) {
            return base.Channel.Query(request);
        }
        
        public bool Query(string Mobile, out string Province, out string City, out string AreaCode, out string PostCode, out string Corp, out string Card) {
            ClientSystem.MobileService.QueryRequest inValue = new ClientSystem.MobileService.QueryRequest();
            inValue.Body = new ClientSystem.MobileService.QueryRequestBody();
            inValue.Body.Mobile = Mobile;
            ClientSystem.MobileService.QueryResponse retVal = ((ClientSystem.MobileService.MobileSoap)(this)).Query(inValue);
            Province = retVal.Body.Province;
            City = retVal.Body.City;
            AreaCode = retVal.Body.AreaCode;
            PostCode = retVal.Body.PostCode;
            Corp = retVal.Body.Corp;
            Card = retVal.Body.Card;
            return retVal.Body.QueryResult;
        }
        
        public bool GetStatus() {
            return base.Channel.GetStatus();
        }
    }
}
