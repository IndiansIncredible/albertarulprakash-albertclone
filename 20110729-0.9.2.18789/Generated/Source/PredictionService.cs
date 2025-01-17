//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Prediction.V1_2.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class Input {
        
        private Input.InputData input;
        
        [Newtonsoft.Json.JsonPropertyAttribute("input")]
        public virtual Input.InputData InputValue {
            get {
                return this.input;
            }
            set {
                this.input = value;
            }
        }
        
        public class InputData {
            
            private IList<System.String> csvInstance;
            
            [Newtonsoft.Json.JsonPropertyAttribute("csvInstance")]
            public virtual IList<System.String> CsvInstance {
                get {
                    return this.csvInstance;
                }
                set {
                    this.csvInstance = value;
                }
            }
        }
    }
    
    public class Output : Google.Apis.Requests.IDirectResponseSchema {
        
        private string id;
        
        private string kind;
        
        private string outputLabel;
        
        private IList<Output.OutputMultiData> outputMulti;
        
        private double outputValue;
        
        private string selfLink;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("outputLabel")]
        public virtual string OutputLabel {
            get {
                return this.outputLabel;
            }
            set {
                this.outputLabel = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("outputMulti")]
        public virtual IList<Output.OutputMultiData> OutputMulti {
            get {
                return this.outputMulti;
            }
            set {
                this.outputMulti = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("outputValue")]
        public virtual double OutputValue {
            get {
                return this.outputValue;
            }
            set {
                this.outputValue = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink {
            get {
                return this.selfLink;
            }
            set {
                this.selfLink = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this.error;
            }
            set {
                this.error = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this.eTag;
            }
            set {
                this.eTag = value;
            }
        }
        
        public class OutputMultiData {
            
            private string label;
            
            private double score;
            
            [Newtonsoft.Json.JsonPropertyAttribute("label")]
            public virtual string Label {
                get {
                    return this.label;
                }
                set {
                    this.label = value;
                }
            }
            
            [Newtonsoft.Json.JsonPropertyAttribute("score")]
            public virtual double Score {
                get {
                    return this.score;
                }
                set {
                    this.score = value;
                }
            }
        }
    }
    
    public class Training : Google.Apis.Requests.IDirectResponseSchema {
        
        private string id;
        
        private string kind;
        
        private Training.ModelInfoData modelInfo;
        
        private string selfLink;
        
        private string trainingStatus;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("modelInfo")]
        public virtual Training.ModelInfoData ModelInfo {
            get {
                return this.modelInfo;
            }
            set {
                this.modelInfo = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink {
            get {
                return this.selfLink;
            }
            set {
                this.selfLink = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("trainingStatus")]
        public virtual string TrainingStatus {
            get {
                return this.trainingStatus;
            }
            set {
                this.trainingStatus = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this.error;
            }
            set {
                this.error = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this.eTag;
            }
            set {
                this.eTag = value;
            }
        }
        
        public class ModelInfoData {
            
            private double classificationAccuracy;
            
            private double meanSquaredError;
            
            private string modelType;
            
            [Newtonsoft.Json.JsonPropertyAttribute("classificationAccuracy")]
            public virtual double ClassificationAccuracy {
                get {
                    return this.classificationAccuracy;
                }
                set {
                    this.classificationAccuracy = value;
                }
            }
            
            [Newtonsoft.Json.JsonPropertyAttribute("meanSquaredError")]
            public virtual double MeanSquaredError {
                get {
                    return this.meanSquaredError;
                }
                set {
                    this.meanSquaredError = value;
                }
            }
            
            [Newtonsoft.Json.JsonPropertyAttribute("modelType")]
            public virtual string ModelType {
                get {
                    return this.modelType;
                }
                set {
                    this.modelType = value;
                }
            }
        }
    }
    
    public class Update {
        
        private string classLabel;
        
        private IList<System.String> csvInstance;
        
        [Newtonsoft.Json.JsonPropertyAttribute("classLabel")]
        public virtual string ClassLabel {
            get {
                return this.classLabel;
            }
            set {
                this.classLabel = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("csvInstance")]
        public virtual IList<System.String> CsvInstance {
            get {
                return this.csvInstance;
            }
            set {
                this.csvInstance = value;
            }
        }
    }
}
namespace Google.Apis.Prediction.V1_2 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public class PredictionService : Google.Apis.Discovery.IRequestProvider {
        
        private Google.Apis.Discovery.IService genericService;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string Version = "v1.2";
        
        private const string Name = "prediction";
        
        private const string BaseUri = "https://www.googleapis.com/prediction/v1.2/";
        
        private const Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string developerKey;
        
        private HostedmodelsResource hostedmodels;
        
        private TrainingResource training;
        
        public PredictionService(Google.Apis.Discovery.IService genericService, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.genericService = genericService;
            this.authenticator = authenticator;
            this.hostedmodels = new HostedmodelsResource(this);
            this.training = new TrainingResource(this);
        }
        
        public PredictionService() : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.CachedWebDiscoveryDevice(new System.Uri(string.Format("https://www.googleapis.com/discovery/v1/apis/{0}/{1}/rest", PredictionService.Name, PredictionService.Version)))).GetService(PredictionService.Version, PredictionService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameterV1_0(new System.Uri(PredictionService.BaseUri))), Google.Apis.Authentication.AuthenticatorFactory.GetInstance().GetRegisteredAuthenticator()) {
        }
        
        /// <summary>Sets the DeveloperKey which this service uses for all requests</summary>
        public virtual string DeveloperKey {
            get {
                return this.developerKey;
            }
            set {
                this.developerKey = value;
            }
        }
        
        public virtual HostedmodelsResource Hostedmodels {
            get {
                return this.hostedmodels;
            }
        }
        
        public virtual TrainingResource Training {
            get {
                return this.training;
            }
        }
        
        public virtual Google.Apis.Requests.IRequest CreateRequest(string resource, string method) {
            Google.Apis.Requests.IRequest request = this.genericService.CreateRequest(resource, method);
            if (!string.IsNullOrEmpty(DeveloperKey)) {
                request = request.WithDeveloperKey(this.DeveloperKey);
            }
            return request.WithAuthentication(authenticator);
        }
        
        public virtual void RegisterSerializer(Google.Apis.ISerializer serializer) {
            genericService.Serializer = serializer;
        }
        
        public virtual string SerializeObject(object obj) {
            return genericService.SerializeRequest(obj);
        }
        
        public virtual T DeserializeResponse<T>(Google.Apis.Requests.IResponse response)
         {
            return genericService.DeserializeResponse<T>(response);
        }
        
        /// <summary>A list of all OAuth2.0 scopes. Each of these scopes relates to a permission or group of permissions that different methods of this API may need.</summary>
        public enum Scopes {
            
            /// <summary>Manage your data in the Google Prediction API</summary>
            [Google.Apis.Util.StringValueAttribute("https://www.googleapis.com/auth/prediction")]
            Prediction,
        }
    }
    
    public class HostedmodelsResource {
        
        private Google.Apis.Discovery.IRequestProvider service;
        
        private const string Resource = "hostedmodels";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(HostedmodelsResource));
        
        public HostedmodelsResource(PredictionService service) {
            this.service = service;
        }
        
        /// <summary>Submit input and request an output against a hosted model</summary>
        /// <param name="hostedModelName">Required - The name of a hosted model</param>
        public virtual PredictRequest Predict(Google.Apis.Prediction.V1_2.Data.Input body, string hostedModelName) {
            return new PredictRequest(service, body, hostedModelName);
        }
        
        public class PredictRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Prediction.V1_2.Data.Output> {
            
            private string hostedModelName;
            
            private Google.Apis.Prediction.V1_2.Data.Input bodyValue;
            
            public PredictRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Prediction.V1_2.Data.Input body, string hostedModelName) : 
                    base(service) {
                this.Body = body;
                this.hostedModelName = hostedModelName;
            }
            
            /// <summary>The name of a hosted model</summary>
            [Google.Apis.Util.RequestParameterAttribute("hostedModelName")]
            public virtual string HostedModelName {
                get {
                    return this.hostedModelName;
                }
            }
            
            /// <summary>Gets/Sets the Body of this Request.</summary>
            public virtual Google.Apis.Prediction.V1_2.Data.Input Body {
                get {
                    return this.bodyValue;
                }
                set {
                    this.bodyValue = value;
                }
            }
            
            protected override string ResourceName {
                get {
                    return "hostedmodels";
                }
            }
            
            protected override string MethodName {
                get {
                    return "predict";
                }
            }
            
            protected override object GetBody() {
                return this.Body;
            }
        }
    }
    
    public class TrainingResource {
        
        private Google.Apis.Discovery.IRequestProvider service;
        
        private const string Resource = "training";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(TrainingResource));
        
        public TrainingResource(PredictionService service) {
            this.service = service;
        }
        
        /// <summary>Delete a trained model</summary>
        /// <param name="data">Required - mybucket%2Fmydata resource in Google Storage</param>
        public virtual DeleteRequest Delete(string data) {
            return new DeleteRequest(service, data);
        }
        
        /// <summary>Check training status of your model</summary>
        /// <param name="data">Required - mybucket%2Fmydata resource in Google Storage</param>
        public virtual GetRequest Get(string data) {
            return new GetRequest(service, data);
        }
        
        /// <summary>Begin training your model</summary>
        public virtual InsertRequest Insert(Google.Apis.Prediction.V1_2.Data.Training body) {
            return new InsertRequest(service, body);
        }
        
        /// <summary>Begin training your model</summary>
        /// <param name="data">Optional - mybucket%2Fmydata resource in Google Storage</param>
        public virtual InsertRequest Insert(Google.Apis.Prediction.V1_2.Data.Training body, [System.Runtime.InteropServices.OptionalAttribute()] string data) {
            return new InsertRequest(service, body, data);
        }
        
        /// <summary>Add new data to a trained model</summary>
        /// <param name="data">Required</param>
        public virtual UpdateRequest Update(Google.Apis.Prediction.V1_2.Data.Update body, string data) {
            return new UpdateRequest(service, body, data);
        }
        
        public class DeleteRequest : Google.Apis.Requests.ServiceRequest<string> {
            
            private string data;
            
            public DeleteRequest(Google.Apis.Discovery.IRequestProvider service, string data) : 
                    base(service) {
                this.data = data;
            }
            
            /// <summary>mybucket%2Fmydata resource in Google Storage</summary>
            [Google.Apis.Util.RequestParameterAttribute("data")]
            public virtual string Data {
                get {
                    return this.data;
                }
            }
            
            protected override string ResourceName {
                get {
                    return "training";
                }
            }
            
            protected override string MethodName {
                get {
                    return "delete";
                }
            }
        }
        
        public class GetRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Prediction.V1_2.Data.Training> {
            
            private string data;
            
            public GetRequest(Google.Apis.Discovery.IRequestProvider service, string data) : 
                    base(service) {
                this.data = data;
            }
            
            /// <summary>mybucket%2Fmydata resource in Google Storage</summary>
            [Google.Apis.Util.RequestParameterAttribute("data")]
            public virtual string Data {
                get {
                    return this.data;
                }
            }
            
            protected override string ResourceName {
                get {
                    return "training";
                }
            }
            
            protected override string MethodName {
                get {
                    return "get";
                }
            }
        }
        
        public class InsertRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Prediction.V1_2.Data.Training> {
            
            private string data;
            
            private Google.Apis.Prediction.V1_2.Data.Training bodyValue;
            
            public InsertRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Prediction.V1_2.Data.Training body) : 
                    base(service) {
                this.Body = body;
            }
            
            public InsertRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Prediction.V1_2.Data.Training body, [System.Runtime.InteropServices.OptionalAttribute()] string data) : 
                    base(service) {
                this.Body = body;
                this.data = data;
            }
            
            /// <summary>mybucket%2Fmydata resource in Google Storage</summary>
            [Google.Apis.Util.RequestParameterAttribute("data")]
            public virtual string Data {
                get {
                    return this.data;
                }
                set {
                    this.data = value;
                }
            }
            
            /// <summary>Gets/Sets the Body of this Request.</summary>
            public virtual Google.Apis.Prediction.V1_2.Data.Training Body {
                get {
                    return this.bodyValue;
                }
                set {
                    this.bodyValue = value;
                }
            }
            
            protected override string ResourceName {
                get {
                    return "training";
                }
            }
            
            protected override string MethodName {
                get {
                    return "insert";
                }
            }
            
            protected override object GetBody() {
                return this.Body;
            }
        }
        
        public class UpdateRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Prediction.V1_2.Data.Training> {
            
            private string data;
            
            private Google.Apis.Prediction.V1_2.Data.Update bodyValue;
            
            public UpdateRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Prediction.V1_2.Data.Update body, string data) : 
                    base(service) {
                this.Body = body;
                this.data = data;
            }
            
            [Google.Apis.Util.RequestParameterAttribute("data")]
            public virtual string Data {
                get {
                    return this.data;
                }
            }
            
            /// <summary>Gets/Sets the Body of this Request.</summary>
            public virtual Google.Apis.Prediction.V1_2.Data.Update Body {
                get {
                    return this.bodyValue;
                }
                set {
                    this.bodyValue = value;
                }
            }
            
            protected override string ResourceName {
                get {
                    return "training";
                }
            }
            
            protected override string MethodName {
                get {
                    return "update";
                }
            }
            
            protected override object GetBody() {
                return this.Body;
            }
        }
    }
}
