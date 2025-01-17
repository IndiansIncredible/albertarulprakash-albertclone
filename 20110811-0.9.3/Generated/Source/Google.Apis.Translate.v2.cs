//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Translate.v2.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class DetectionsListResponse : Google.Apis.Requests.IDirectResponseSchema {
        
        private IList<DetectionsResource> detections;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        /// <summary>A detections contains detection results of several text</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detections")]
        public virtual IList<DetectionsResource> Detections {
            get {
                return this.detections;
            }
            set {
                this.detections = value;
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
    }
    
    /// <summary>An array of languages which we detect for the given text The most likely language list first.</summary>
    public class DetectionsResource : List<DetectionsResource.Entry> {
        
        public class Entry {
            
            private double confidence;
            
            private bool isReliable;
            
            private string language;
            
            /// <summary>The confidence of the detection resul of this language.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
            public virtual double Confidence {
                get {
                    return this.confidence;
                }
                set {
                    this.confidence = value;
                }
            }
            
            /// <summary>A boolean to indicate is the language detection result reliable.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("isReliable")]
            public virtual bool IsReliable {
                get {
                    return this.isReliable;
                }
                set {
                    this.isReliable = value;
                }
            }
            
            /// <summary>The language we detect</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("language")]
            public virtual string Language {
                get {
                    return this.language;
                }
                set {
                    this.language = value;
                }
            }
        }
    }
    
    public class LanguagesListResponse : Google.Apis.Requests.IDirectResponseSchema {
        
        private IList<LanguagesResource> languages;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        /// <summary>List of source/target languages supported by the translation API. If target parameter is unspecified, the list is sorted by the ASCII code point order of the language code. If target parameter is specified, the list is sorted by the collation order of the language name in the target language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languages")]
        public virtual IList<LanguagesResource> Languages {
            get {
                return this.languages;
            }
            set {
                this.languages = value;
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
    }
    
    public class LanguagesResource {
        
        private string language;
        
        private string name;
        
        /// <summary>The language code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language {
            get {
                return this.language;
            }
            set {
                this.language = value;
            }
        }
        
        /// <summary>The localized name of the language if target parameter is given.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name {
            get {
                return this.name;
            }
            set {
                this.name = value;
            }
        }
    }
    
    public class TranslationsListResponse : Google.Apis.Requests.IDirectResponseSchema {
        
        private IList<TranslationsResource> translations;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        /// <summary>Translations contains list of translation results of given text</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("translations")]
        public virtual IList<TranslationsResource> Translations {
            get {
                return this.translations;
            }
            set {
                this.translations = value;
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
    }
    
    public class TranslationsResource {
        
        private string detectedSourceLanguage;
        
        private string translatedText;
        
        /// <summary>Detected source language if source parameter is unspecified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedSourceLanguage")]
        public virtual string DetectedSourceLanguage {
            get {
                return this.detectedSourceLanguage;
            }
            set {
                this.detectedSourceLanguage = value;
            }
        }
        
        /// <summary>The translation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("translatedText")]
        public virtual string TranslatedText {
            get {
                return this.translatedText;
            }
            set {
                this.translatedText = value;
            }
        }
    }
}
namespace Google.Apis.Translate.v2 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public partial class TranslateService : Google.Apis.Discovery.IRequestProvider {
        
        private Google.Apis.Discovery.IService genericService;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string DiscoveryDocument = "{\"kind\":\"discovery#restDescription\",\"id\":\"translate:v2\",\"name\":\"translate\",\"versi" +
            "on\":\"v2\",\"title\":\"Translate API\",\"description\":\"Lets you translate text from one" +
            " language to another\",\"icons\":{\"x16\":\"http://www.google.com/images/icons/product" +
            "/translate-16.png\",\"x32\":\"http://www.google.com/images/icons/product/translate-3" +
            "2.png\"},\"documentationLink\":\"http://code.google.com/apis/language/translate/v2/u" +
            "sing_rest.html\",\"labels\":[\"labs\"],\"protocol\":\"rest\",\"basePath\":\"/language/transl" +
            "ate/\",\"parameters\":{\"alt\":{\"type\":\"string\",\"description\":\"Data format for the re" +
            "sponse.\",\"default\":\"json\",\"enum\":[\"json\"],\"enumDescriptions\":[\"Responses with Co" +
            "ntent-Type of application/json\"],\"location\":\"query\"},\"fields\":{\"type\":\"string\",\"" +
            "description\":\"Selector specifying which fields to include in a partial response." +
            "\",\"location\":\"query\"},\"key\":{\"type\":\"string\",\"description\":\"API key. Your API ke" +
            "y identifies your project and provides you with API access, quota, and reports. " +
            "Required unless you provide an OAuth 2.0 token.\",\"location\":\"query\"},\"oauth_toke" +
            "n\":{\"type\":\"string\",\"description\":\"OAuth 2.0 token for the current user.\",\"locat" +
            "ion\":\"query\"},\"prettyPrint\":{\"type\":\"boolean\",\"description\":\"Returns response wi" +
            "th indentations and line breaks.\",\"default\":\"true\",\"location\":\"query\"},\"userIp\":" +
            "{\"type\":\"string\",\"description\":\"IP address of the site where the request origina" +
            "tes. Use this if you want to enforce per-user limits.\",\"location\":\"query\"}},\"fea" +
            "tures\":[\"dataWrapper\"],\"schemas\":{\"DetectionsListResponse\":{\"id\":\"DetectionsList" +
            "Response\",\"type\":\"object\",\"properties\":{\"detections\":{\"type\":\"array\",\"descriptio" +
            "n\":\"A detections contains detection results of several text\",\"items\":{\"$ref\":\"De" +
            "tectionsResource\"}}}},\"DetectionsResource\":{\"id\":\"DetectionsResource\",\"type\":\"ar" +
            "ray\",\"description\":\"An array of languages which we detect for the given text The" +
            " most likely language list first.\",\"items\":{\"type\":\"object\",\"properties\":{\"confi" +
            "dence\":{\"type\":\"number\",\"description\":\"The confidence of the detection resul of " +
            "this language.\",\"format\":\"float\"},\"isReliable\":{\"type\":\"boolean\",\"description\":\"" +
            "A boolean to indicate is the language detection result reliable.\"},\"language\":{\"" +
            "type\":\"string\",\"description\":\"The language we detect\"}}}},\"LanguagesListResponse" +
            "\":{\"id\":\"LanguagesListResponse\",\"type\":\"object\",\"properties\":{\"languages\":{\"type" +
            "\":\"array\",\"description\":\"List of source/target languages supported by the transl" +
            "ation API. If target parameter is unspecified, the list is sorted by the ASCII c" +
            "ode point order of the language code. If target parameter is specified, the list" +
            " is sorted by the collation order of the language name in the target language.\"," +
            "\"items\":{\"$ref\":\"LanguagesResource\"}}}},\"LanguagesResource\":{\"id\":\"LanguagesReso" +
            "urce\",\"type\":\"object\",\"properties\":{\"language\":{\"type\":\"string\",\"description\":\"T" +
            "he language code.\"},\"name\":{\"type\":\"string\",\"description\":\"The localized name of" +
            " the language if target parameter is given.\"}}},\"TranslationsListResponse\":{\"id\"" +
            ":\"TranslationsListResponse\",\"type\":\"object\",\"properties\":{\"translations\":{\"type\"" +
            ":\"array\",\"description\":\"Translations contains list of translation results of giv" +
            "en text\",\"items\":{\"$ref\":\"TranslationsResource\"}}}},\"TranslationsResource\":{\"id\"" +
            ":\"TranslationsResource\",\"type\":\"object\",\"properties\":{\"detectedSourceLanguage\":{" +
            "\"type\":\"string\",\"description\":\"Detected source language if source parameter is u" +
            "nspecified.\"},\"translatedText\":{\"type\":\"string\",\"description\":\"The translation.\"" +
            "}}}},\"resources\":{\"detections\":{\"methods\":{\"list\":{\"id\":\"language.detections.lis" +
            "t\",\"path\":\"v2/detect\",\"httpMethod\":\"GET\",\"description\":\"Detect the language of t" +
            "ext.\",\"parameters\":{\"q\":{\"type\":\"string\",\"description\":\"The text to detect\",\"req" +
            "uired\":true,\"repeated\":true,\"location\":\"query\"}},\"parameterOrder\":[\"q\"],\"respons" +
            "e\":{\"$ref\":\"DetectionsListResponse\"}}}},\"languages\":{\"methods\":{\"list\":{\"id\":\"la" +
            "nguage.languages.list\",\"path\":\"v2/languages\",\"httpMethod\":\"GET\",\"description\":\"L" +
            "ist the source/target languages supported by the API\",\"parameters\":{\"target\":{\"t" +
            "ype\":\"string\",\"description\":\"the language and collation in which the localized r" +
            "esults should be returned\",\"location\":\"query\"}},\"response\":{\"$ref\":\"LanguagesLis" +
            "tResponse\"}}}},\"translations\":{\"methods\":{\"list\":{\"id\":\"language.translations.li" +
            "st\",\"path\":\"v2\",\"httpMethod\":\"GET\",\"description\":\"Returns text translations from" +
            " one language to another.\",\"parameters\":{\"cid\":{\"type\":\"string\",\"description\":\"T" +
            "he customization id for translate\",\"repeated\":true,\"location\":\"query\"},\"format\":" +
            "{\"type\":\"string\",\"description\":\"The format of the text\",\"enum\":[\"html\",\"text\"],\"" +
            "enumDescriptions\":[\"Specifies the input is in HTML\",\"Specifies the input is in p" +
            "lain textual format\"],\"location\":\"query\"},\"q\":{\"type\":\"string\",\"description\":\"Th" +
            "e text to translate\",\"required\":true,\"repeated\":true,\"location\":\"query\"},\"source" +
            "\":{\"type\":\"string\",\"description\":\"The source language of the text\",\"location\":\"q" +
            "uery\"},\"target\":{\"type\":\"string\",\"description\":\"The target language into which t" +
            "he text should be translated\",\"required\":true,\"location\":\"query\"}},\"parameterOrd" +
            "er\":[\"q\",\"target\"],\"response\":{\"$ref\":\"TranslationsListResponse\"}}}}}}";
        
        private const string Version = "v2";
        
        private const string Name = "translate";
        
        private const string BaseUri = "https://www.googleapis.com/language/translate/";
        
        private const Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string key;
        
        protected TranslateService(Google.Apis.Discovery.IService genericService, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.genericService = genericService;
            this.authenticator = authenticator;
            this.detections = new DetectionsResource(this);
            this.languages = new LanguagesResource(this);
            this.translations = new TranslationsResource(this);
        }
        
        public TranslateService() : 
                this(Google.Apis.Authentication.NullAuthenticator.Instance) {
        }
        
        public TranslateService(Google.Apis.Authentication.IAuthenticator authenticator) : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.StringDiscoveryDevice(DiscoveryDocument)).GetService(TranslateService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameterV1_0(new System.Uri(TranslateService.BaseUri))), authenticator) {
        }
        
        /// <summary>Sets the API-Key (or DeveloperKey) which this service uses for all requests</summary>
        public virtual string Key {
            get {
                return this.key;
            }
            set {
                this.key = value;
            }
        }
        
        public virtual Google.Apis.Requests.IRequest CreateRequest(string resource, string method) {
            Google.Apis.Requests.IRequest request = this.genericService.CreateRequest(resource, method);
            if (!string.IsNullOrEmpty(Key)) {
                request = request.WithKey(this.Key);
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
    }
    
    public class DetectionsResource {
        
        private Google.Apis.Discovery.IRequestProvider service;
        
        private const string Resource = "detections";
        
        public DetectionsResource(TranslateService service) {
            this.service = service;
        }
        
        /// <summary>Detect the language of text.</summary>
        /// <param name="q">Required - The text to detect</param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> q) {
            return new ListRequest(service, q);
        }
        
        public class ListRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Translate.v2.Data.DetectionsListResponse> {
            
            private Google.Apis.Util.Repeatable<string> q;
            
            public ListRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Util.Repeatable<string> q) : 
                    base(service) {
                this.q = q;
            }
            
            /// <summary>The text to detect</summary>
            [Google.Apis.Util.RequestParameterAttribute("q")]
            public virtual Google.Apis.Util.Repeatable<string> Q {
                get {
                    return this.q;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "detections";
                }
            }
            
            protected override string MethodName {
                get {
                    return "list";
                }
            }
        }
    }
    
    public class LanguagesResource {
        
        private Google.Apis.Discovery.IRequestProvider service;
        
        private const string Resource = "languages";
        
        public LanguagesResource(TranslateService service) {
            this.service = service;
        }
        
        /// <summary>List the source/target languages supported by the API</summary>
        public virtual ListRequest List() {
            return new ListRequest(service);
        }
        
        /// <summary>List the source/target languages supported by the API</summary>
        /// <param name="target">Optional - the language and collation in which the localized results should be returned</param>
        public virtual ListRequest List([System.Runtime.InteropServices.OptionalAttribute()] string target) {
            return new ListRequest(service, target);
        }
        
        public class ListRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Translate.v2.Data.LanguagesListResponse> {
            
            private string target;
            
            public ListRequest(Google.Apis.Discovery.IRequestProvider service) : 
                    base(service) {
            }
            
            public ListRequest(Google.Apis.Discovery.IRequestProvider service, [System.Runtime.InteropServices.OptionalAttribute()] string target) : 
                    base(service) {
                this.target = target;
            }
            
            /// <summary>the language and collation in which the localized results should be returned</summary>
            [Google.Apis.Util.RequestParameterAttribute("target")]
            public virtual string Target {
                get {
                    return this.target;
                }
                set {
                    this.target = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "languages";
                }
            }
            
            protected override string MethodName {
                get {
                    return "list";
                }
            }
        }
    }
    
    public class TranslationsResource {
        
        private Google.Apis.Discovery.IRequestProvider service;
        
        private const string Resource = "translations";
        
        public TranslationsResource(TranslateService service) {
            this.service = service;
        }
        
        /// <summary>Returns text translations from one language to another.</summary>
        /// <param name="q">Required - The text to translate</param>
        /// <param name="target">Required - The target language into which the text should be translated</param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> q, string target) {
            return new ListRequest(service, q, target);
        }
        
        /// <summary>Returns text translations from one language to another.</summary>
        /// <param name="q">Required - The text to translate</param>
        /// <param name="target">Required - The target language into which the text should be translated</param>
        /// <param name="cid">Optional - The customization id for translate</param>
        /// <param name="format">Optional - Must be one of the following values [html, text] - The format of the text</param>
        /// <param name="source">Optional - The source language of the text</param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> q, string target, [System.Runtime.InteropServices.OptionalAttribute()] Google.Apis.Util.Repeatable<string> cid, [System.Runtime.InteropServices.OptionalAttribute()] Format? format, [System.Runtime.InteropServices.OptionalAttribute()] string source) {
            return new ListRequest(service, q, target, cid, format, source);
        }
        
        /// <summary>The format of the text</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Format {
            
            /// <summary>Specifies the input is in HTML</summary>
            [Google.Apis.Util.StringValueAttribute("html")]
            Html,
            
            /// <summary>Specifies the input is in plain textual format</summary>
            [Google.Apis.Util.StringValueAttribute("text")]
            Text,
        }
        
        public class ListRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Translate.v2.Data.TranslationsListResponse> {
            
            private Google.Apis.Util.Repeatable<string> cid;
            
            private Format? format;
            
            private Google.Apis.Util.Repeatable<string> q;
            
            private string source;
            
            private string target;
            
            public ListRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Util.Repeatable<string> q, string target) : 
                    base(service) {
                this.q = q;
                this.target = target;
            }
            
            public ListRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Util.Repeatable<string> q, string target, [System.Runtime.InteropServices.OptionalAttribute()] Google.Apis.Util.Repeatable<string> cid, [System.Runtime.InteropServices.OptionalAttribute()] Format? format, [System.Runtime.InteropServices.OptionalAttribute()] string source) : 
                    base(service) {
                this.q = q;
                this.target = target;
                this.cid = cid;
                this.format = format;
                this.source = source;
            }
            
            /// <summary>The customization id for translate</summary>
            [Google.Apis.Util.RequestParameterAttribute("cid")]
            public virtual Google.Apis.Util.Repeatable<string> Cid {
                get {
                    return this.cid;
                }
                set {
                    this.cid = value;
                }
            }
            
            /// <summary>The format of the text</summary>
            [Google.Apis.Util.RequestParameterAttribute("format")]
            public virtual Format? Format {
                get {
                    return this.format;
                }
                set {
                    this.format = value;
                }
            }
            
            /// <summary>The text to translate</summary>
            [Google.Apis.Util.RequestParameterAttribute("q")]
            public virtual Google.Apis.Util.Repeatable<string> Q {
                get {
                    return this.q;
                }
            }
            
            /// <summary>The source language of the text</summary>
            [Google.Apis.Util.RequestParameterAttribute("source")]
            public virtual string Source {
                get {
                    return this.source;
                }
                set {
                    this.source = value;
                }
            }
            
            /// <summary>The target language into which the text should be translated</summary>
            [Google.Apis.Util.RequestParameterAttribute("target")]
            public virtual string Target {
                get {
                    return this.target;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "translations";
                }
            }
            
            protected override string MethodName {
                get {
                    return "list";
                }
            }
        }
    }
    
    public partial class TranslateService {
        
        private const string Resource = "";
        
        private DetectionsResource detections;
        
        private LanguagesResource languages;
        
        private TranslationsResource translations;
        
        private Google.Apis.Discovery.IRequestProvider service {
            get {
                return this;
            }
        }
        
        public virtual DetectionsResource Detections {
            get {
                return this.detections;
            }
        }
        
        public virtual LanguagesResource Languages {
            get {
                return this.languages;
            }
        }
        
        public virtual TranslationsResource Translations {
            get {
                return this.translations;
            }
        }
    }
}
