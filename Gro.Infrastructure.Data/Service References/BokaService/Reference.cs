﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gro.Infrastructure.Data.BokaService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://lantmannen.com/centralen/", ConfigurationName="BokaService.BokaServiceSoap")]
    public interface BokaServiceSoap {
        
        // CODEGEN: Generating message contract since element name SearchString from namespace http://lantmannen.com/centralen/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://lantmannen.com/centralen/getIO", ReplyAction="*")]
        Gro.Infrastructure.Data.BokaService.getIOResponse getIO(Gro.Infrastructure.Data.BokaService.getIORequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://lantmannen.com/centralen/getIO", ReplyAction="*")]
        System.Threading.Tasks.Task<Gro.Infrastructure.Data.BokaService.getIOResponse> getIOAsync(Gro.Infrastructure.Data.BokaService.getIORequest request);
        
        // CODEGEN: Generating message contract since element name Supplier from namespace http://lantmannen.com/centralen/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://lantmannen.com/centralen/getIOlist", ReplyAction="*")]
        Gro.Infrastructure.Data.BokaService.getIOlistResponse getIOlist(Gro.Infrastructure.Data.BokaService.getIOlistRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://lantmannen.com/centralen/getIOlist", ReplyAction="*")]
        System.Threading.Tasks.Task<Gro.Infrastructure.Data.BokaService.getIOlistResponse> getIOlistAsync(Gro.Infrastructure.Data.BokaService.getIOlistRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getIORequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getIO", Namespace="http://lantmannen.com/centralen/", Order=0)]
        public Gro.Infrastructure.Data.BokaService.getIORequestBody Body;
        
        public getIORequest() {
        }
        
        public getIORequest(Gro.Infrastructure.Data.BokaService.getIORequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://lantmannen.com/centralen/")]
    public partial class getIORequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SearchString;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int Typ;
        
        public getIORequestBody() {
        }
        
        public getIORequestBody(string SearchString, int Typ) {
            this.SearchString = SearchString;
            this.Typ = Typ;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getIOResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getIOResponse", Namespace="http://lantmannen.com/centralen/", Order=0)]
        public Gro.Infrastructure.Data.BokaService.getIOResponseBody Body;
        
        public getIOResponse() {
        }
        
        public getIOResponse(Gro.Infrastructure.Data.BokaService.getIOResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://lantmannen.com/centralen/")]
    public partial class getIOResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Gro.Core.DataModels.Boka.BookingOrder getIOResult;
        
        public getIOResponseBody() {
        }
        
        public getIOResponseBody(Gro.Core.DataModels.Boka.BookingOrder getIOResult) {
            this.getIOResult = getIOResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getIOlistRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getIOlist", Namespace="http://lantmannen.com/centralen/", Order=0)]
        public Gro.Infrastructure.Data.BokaService.getIOlistRequestBody Body;
        
        public getIOlistRequest() {
        }
        
        public getIOlistRequest(Gro.Infrastructure.Data.BokaService.getIOlistRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://lantmannen.com/centralen/")]
    public partial class getIOlistRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Supplier;
        
        public getIOlistRequestBody() {
        }
        
        public getIOlistRequestBody(string Supplier) {
            this.Supplier = Supplier;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getIOlistResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getIOlistResponse", Namespace="http://lantmannen.com/centralen/", Order=0)]
        public Gro.Infrastructure.Data.BokaService.getIOlistResponseBody Body;
        
        public getIOlistResponse() {
        }
        
        public getIOlistResponse(Gro.Infrastructure.Data.BokaService.getIOlistResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://lantmannen.com/centralen/")]
    public partial class getIOlistResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Gro.Core.DataModels.Boka.CustomerSearch.DeleveryAssuranceList[] getIOlistResult;
        
        public getIOlistResponseBody() {
        }
        
        public getIOlistResponseBody(Gro.Core.DataModels.Boka.CustomerSearch.DeleveryAssuranceList[] getIOlistResult) {
            this.getIOlistResult = getIOlistResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BokaServiceSoapChannel : Gro.Infrastructure.Data.BokaService.BokaServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BokaServiceSoapClient : System.ServiceModel.ClientBase<Gro.Infrastructure.Data.BokaService.BokaServiceSoap>, Gro.Infrastructure.Data.BokaService.BokaServiceSoap {
        
        public BokaServiceSoapClient() {
        }
        
        public BokaServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BokaServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BokaServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BokaServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Gro.Infrastructure.Data.BokaService.getIOResponse Gro.Infrastructure.Data.BokaService.BokaServiceSoap.getIO(Gro.Infrastructure.Data.BokaService.getIORequest request) {
            return base.Channel.getIO(request);
        }
        
        public Gro.Core.DataModels.Boka.BookingOrder getIO(string SearchString, int Typ) {
            Gro.Infrastructure.Data.BokaService.getIORequest inValue = new Gro.Infrastructure.Data.BokaService.getIORequest();
            inValue.Body = new Gro.Infrastructure.Data.BokaService.getIORequestBody();
            inValue.Body.SearchString = SearchString;
            inValue.Body.Typ = Typ;
            Gro.Infrastructure.Data.BokaService.getIOResponse retVal = ((Gro.Infrastructure.Data.BokaService.BokaServiceSoap)(this)).getIO(inValue);
            return retVal.Body.getIOResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Gro.Infrastructure.Data.BokaService.getIOResponse> Gro.Infrastructure.Data.BokaService.BokaServiceSoap.getIOAsync(Gro.Infrastructure.Data.BokaService.getIORequest request) {
            return base.Channel.getIOAsync(request);
        }
        
        public System.Threading.Tasks.Task<Gro.Infrastructure.Data.BokaService.getIOResponse> getIOAsync(string SearchString, int Typ) {
            Gro.Infrastructure.Data.BokaService.getIORequest inValue = new Gro.Infrastructure.Data.BokaService.getIORequest();
            inValue.Body = new Gro.Infrastructure.Data.BokaService.getIORequestBody();
            inValue.Body.SearchString = SearchString;
            inValue.Body.Typ = Typ;
            return ((Gro.Infrastructure.Data.BokaService.BokaServiceSoap)(this)).getIOAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Gro.Infrastructure.Data.BokaService.getIOlistResponse Gro.Infrastructure.Data.BokaService.BokaServiceSoap.getIOlist(Gro.Infrastructure.Data.BokaService.getIOlistRequest request) {
            return base.Channel.getIOlist(request);
        }
        
        public Gro.Core.DataModels.Boka.CustomerSearch.DeleveryAssuranceList[] getIOlist(string Supplier) {
            Gro.Infrastructure.Data.BokaService.getIOlistRequest inValue = new Gro.Infrastructure.Data.BokaService.getIOlistRequest();
            inValue.Body = new Gro.Infrastructure.Data.BokaService.getIOlistRequestBody();
            inValue.Body.Supplier = Supplier;
            Gro.Infrastructure.Data.BokaService.getIOlistResponse retVal = ((Gro.Infrastructure.Data.BokaService.BokaServiceSoap)(this)).getIOlist(inValue);
            return retVal.Body.getIOlistResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Gro.Infrastructure.Data.BokaService.getIOlistResponse> Gro.Infrastructure.Data.BokaService.BokaServiceSoap.getIOlistAsync(Gro.Infrastructure.Data.BokaService.getIOlistRequest request) {
            return base.Channel.getIOlistAsync(request);
        }
        
        public System.Threading.Tasks.Task<Gro.Infrastructure.Data.BokaService.getIOlistResponse> getIOlistAsync(string Supplier) {
            Gro.Infrastructure.Data.BokaService.getIOlistRequest inValue = new Gro.Infrastructure.Data.BokaService.getIOlistRequest();
            inValue.Body = new Gro.Infrastructure.Data.BokaService.getIOlistRequestBody();
            inValue.Body.Supplier = Supplier;
            return ((Gro.Infrastructure.Data.BokaService.BokaServiceSoap)(this)).getIOlistAsync(inValue);
        }
    }
}
