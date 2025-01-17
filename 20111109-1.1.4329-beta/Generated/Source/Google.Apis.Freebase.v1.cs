//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5420
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Freebase.v1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class ContentserviceGet : Google.Apis.Requests.IDirectResponseSchema {
        
        private string result;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        /// <summary>The text requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual string Result {
            get {
                return this.result;
            }
            set {
                this.result = value;
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
}
namespace Google.Apis.Freebase.v1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public partial class FreebaseService : Google.Apis.Discovery.IRequestProvider {
        
        private Google.Apis.Discovery.IService genericService;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string DiscoveryDocument = "{\"kind\":\"discovery#restDescription\",\"id\":\"freebase:v1\",\"name\":\"freebase\",\"version" +
            "\":\"v1\",\"title\":\"Freebase API\",\"description\":\"Lets you access the Freebase reposi" +
            "tory of open data.\",\"icons\":{\"x16\":\"http://www.google.com/images/icons/product/f" +
            "reebase-16.png\",\"x32\":\"http://www.google.com/images/icons/product/freebase-32.pn" +
            "g\"},\"documentationLink\":\"http://wiki.freebase.com/wiki/New_Freebase_API\",\"labels" +
            "\":[\"labs\"],\"protocol\":\"rest\",\"basePath\":\"/freebase/v1/\",\"parameters\":{\"alt\":{\"ty" +
            "pe\":\"string\",\"description\":\"Data format for the response.\",\"default\":\"json\",\"enu" +
            "m\":[\"json\"],\"enumDescriptions\":[\"Responses with Content-Type of application/json" +
            "\"],\"location\":\"query\"},\"fields\":{\"type\":\"string\",\"description\":\"Selector specify" +
            "ing which fields to include in a partial response.\",\"location\":\"query\"},\"key\":{\"" +
            "type\":\"string\",\"description\":\"API key. Your API key identifies your project and " +
            "provides you with API access, quota, and reports. Required unless you provide an" +
            " OAuth 2.0 token.\",\"location\":\"query\"},\"oauth_token\":{\"type\":\"string\",\"descripti" +
            "on\":\"OAuth 2.0 token for the current user.\",\"location\":\"query\"},\"prettyPrint\":{\"" +
            "type\":\"boolean\",\"description\":\"Returns response with indentations and line break" +
            "s.\",\"default\":\"true\",\"location\":\"query\"},\"quotaUser\":{\"type\":\"string\",\"descripti" +
            "on\":\"Available to use for quota purposes for server-side applications. Can be an" +
            "y arbitrary string assigned to a user, but should not exceed 40 characters. Over" +
            "rides userIp if both are provided.\",\"location\":\"query\"},\"userIp\":{\"type\":\"string" +
            "\",\"description\":\"IP address of the site where the request originates. Use this i" +
            "f you want to enforce per-user limits.\",\"location\":\"query\"}},\"schemas\":{\"Content" +
            "serviceGet\":{\"id\":\"ContentserviceGet\",\"type\":\"object\",\"properties\":{\"result\":{\"t" +
            "ype\":\"string\",\"description\":\"The text requested.\"}}}},\"methods\":{\"image\":{\"id\":\"" +
            "freebase.image\",\"path\":\"image{/id*}\",\"httpMethod\":\"GET\",\"description\":\"Returns t" +
            "he scaled/cropped image attached to a freebase node.\",\"parameters\":{\"fallbackid\"" +
            ":{\"type\":\"string\",\"description\":\"Use the image associated with this secondary id" +
            " if no image is associated with the primary id.\",\"default\":\"/freebase/no_image_p" +
            "ng\",\"pattern\":\"/[^.]*$\",\"location\":\"query\"},\"id\":{\"type\":\"string\",\"description\":" +
            "\"Freebase entity or content id, mid, or guid.\",\"required\":true,\"repeated\":true,\"" +
            "location\":\"path\"},\"maxheight\":{\"type\":\"integer\",\"description\":\"Maximum height in" +
            " pixels for resulting image.\",\"format\":\"uint32\",\"maximum\":\"4096\",\"location\":\"que" +
            "ry\"},\"maxwidth\":{\"type\":\"integer\",\"description\":\"Maximum width in pixels for res" +
            "ulting image.\",\"format\":\"uint32\",\"maximum\":\"4096\",\"location\":\"query\"},\"mode\":{\"t" +
            "ype\":\"string\",\"description\":\"Method used to scale or crop image.\",\"default\":\"fit" +
            "\",\"enum\":[\"fill\",\"fillcrop\",\"fillcropmid\",\"fit\"],\"enumDescriptions\":[\"TODO(bendr" +
            "ees)\",\"TODO(bendrees)\",\"TODO(bendrees)\",\"TODO(bendrees)\"],\"location\":\"query\"},\"p" +
            "ad\":{\"type\":\"boolean\",\"description\":\"A boolean specifying whether the resulting " +
            "image should be padded up to the requested dimensions.\",\"default\":\"false\",\"locat" +
            "ion\":\"query\"}},\"parameterOrder\":[\"id\"]},\"mqlread\":{\"id\":\"freebase.mqlread\",\"path" +
            "\":\"mqlread\",\"httpMethod\":\"GET\",\"description\":\"Performs MQL Queries.\",\"parameters" +
            "\":{\"as_of_time\":{\"type\":\"string\",\"description\":\"Run the query as it would\'ve bee" +
            "n run at the specified point in time.\",\"location\":\"query\"},\"callback\":{\"type\":\"s" +
            "tring\",\"description\":\"JS method name for JSONP callbacks.\",\"pattern\":\"([A-Za-z0-" +
            "9_$.]|\\\\[|\\\\])+\",\"location\":\"query\"},\"cost\":{\"type\":\"boolean\",\"description\":\"Sho" +
            "w the costs or not.\",\"default\":\"false\",\"location\":\"query\"},\"cursor\":{\"type\":\"str" +
            "ing\",\"description\":\"The mql cursor.\",\"location\":\"query\"},\"html_escape\":{\"type\":\"" +
            "boolean\",\"description\":\"Whether or not to escape entities.\",\"default\":\"true\",\"lo" +
            "cation\":\"query\"},\"indent\":{\"type\":\"integer\",\"description\":\"How many spaces to in" +
            "dent the json.\",\"default\":\"0\",\"format\":\"uint32\",\"maximum\":\"10\",\"location\":\"query" +
            "\"},\"lang\":{\"type\":\"string\",\"description\":\"The language of the results - an id of" +
            " a /type/lang object.\",\"default\":\"/lang/en\",\"location\":\"query\"},\"query\":{\"type\":" +
            "\"string\",\"description\":\"An envelope containing a single MQL query.\",\"required\":t" +
            "rue,\"location\":\"query\"},\"uniqueness_failure\":{\"type\":\"string\",\"description\":\"How" +
            " MQL responds to uniqueness failures.\",\"default\":\"hard\",\"enum\":[\"hard\",\"soft\"],\"" +
            "enumDescriptions\":[\"Be strict - throw an error.\",\"Just return the first encounte" +
            "red object.\"],\"location\":\"query\"}},\"parameterOrder\":[\"query\"]}},\"resources\":{\"te" +
            "xt\":{\"methods\":{\"get\":{\"id\":\"freebase.text.get\",\"path\":\"text{/id*}\",\"httpMethod\"" +
            ":\"GET\",\"description\":\"Returns blob attached to node at specified id as HTML\",\"pa" +
            "rameters\":{\"format\":{\"type\":\"string\",\"description\":\"Sanitizing transformation.\"," +
            "\"default\":\"plain\",\"enum\":[\"html\",\"plain\",\"raw\"],\"enumDescriptions\":[\"Return vali" +
            "d, sanitized html.\",\"Return plain text - strip html tags.\",\"Return the entire co" +
            "ntent as-is.\"],\"location\":\"query\"},\"id\":{\"type\":\"string\",\"description\":\"The id o" +
            "f the item that you want data about\",\"required\":true,\"repeated\":true,\"location\":" +
            "\"path\"},\"maxlength\":{\"type\":\"integer\",\"description\":\"The max number of character" +
            "s to return. Valid only for \'plain\' format.\",\"format\":\"uint32\",\"location\":\"query" +
            "\"}},\"parameterOrder\":[\"id\"],\"response\":{\"$ref\":\"ContentserviceGet\"}}}}}}";
        
        private const string Version = "v1";
        
        private const string Name = "freebase";
        
        private const string BaseUri = "https://www.googleapis.com/freebase/v1/";
        
        private const Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string key;
        
        protected FreebaseService(Google.Apis.Discovery.IService genericService, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.genericService = genericService;
            this.authenticator = authenticator;
            this.text = new TextResource(this);
        }
        
        public FreebaseService() : 
                this(Google.Apis.Authentication.NullAuthenticator.Instance) {
        }
        
        public FreebaseService(Google.Apis.Authentication.IAuthenticator authenticator) : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.StringDiscoveryDevice(DiscoveryDocument)).GetService(FreebaseService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameterV1_0(new System.Uri(FreebaseService.BaseUri))), authenticator) {
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
    
    public class TextResource {
        
        private Google.Apis.Discovery.IRequestProvider service;
        
        private const string Resource = "text";
        
        public TextResource(FreebaseService service) {
            this.service = service;
        }
        
        /// <summary>Returns blob attached to node at specified id as HTML</summary>
        /// <param name="id">Required - The id of the item that you want data about</param>
        public virtual GetRequest Get(Google.Apis.Util.Repeatable<string> id) {
            return new GetRequest(service, id);
        }
        
        /// <summary>Sanitizing transformation.</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Format {
            
            /// <summary>Return valid, sanitized html.</summary>
            [Google.Apis.Util.StringValueAttribute("html")]
            Html,
            
            /// <summary>Return plain text - strip html tags.</summary>
            [Google.Apis.Util.StringValueAttribute("plain")]
            Plain,
            
            /// <summary>Return the entire content as-is.</summary>
            [Google.Apis.Util.StringValueAttribute("raw")]
            Raw,
        }
        
        public class GetRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Freebase.v1.Data.ContentserviceGet> {
            
            private string oauth_token;
            
            private System.Boolean? prettyPrint;
            
            private string quotaUser;
            
            private Format? format;
            
            private Google.Apis.Util.Repeatable<string> id;
            
            private System.Int64? maxlength;
            
            public GetRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Util.Repeatable<string> id) : 
                    base(service) {
                this.id = id;
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token")]
            public virtual string Oauth_token {
                get {
                    return this.oauth_token;
                }
                set {
                    this.oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint")]
            public virtual System.Boolean? PrettyPrint {
                get {
                    return this.prettyPrint;
                }
                set {
                    this.prettyPrint = value;
                }
            }
            
            /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser")]
            public virtual string QuotaUser {
                get {
                    return this.quotaUser;
                }
                set {
                    this.quotaUser = value;
                }
            }
            
            /// <summary>Sanitizing transformation.</summary>
            [Google.Apis.Util.RequestParameterAttribute("format")]
            public virtual Format? Format {
                get {
                    return this.format;
                }
                set {
                    this.format = value;
                }
            }
            
            /// <summary>The id of the item that you want data about</summary>
            [Google.Apis.Util.RequestParameterAttribute("id")]
            public virtual Google.Apis.Util.Repeatable<string> Id {
                get {
                    return this.id;
                }
            }
            
            /// <summary>The max number of characters to return. Valid only for 'plain' format.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxlength")]
            public virtual System.Int64? Maxlength {
                get {
                    return this.maxlength;
                }
                set {
                    this.maxlength = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "text";
                }
            }
            
            protected override string MethodName {
                get {
                    return "get";
                }
            }
        }
    }
    
    public partial class FreebaseService {
        
        private const string Resource = "";
        
        private TextResource text;
        
        private Google.Apis.Discovery.IRequestProvider service {
            get {
                return this;
            }
        }
        
        public virtual TextResource Text {
            get {
                return this.text;
            }
        }
        
        /// <summary>Returns the scaled/cropped image attached to a freebase node.</summary>
        /// <param name="id">Required - Freebase entity or content id, mid, or guid.</param>
        public virtual ImageRequest Image(Google.Apis.Util.Repeatable<string> id) {
            return new ImageRequest(service, id);
        }
        
        /// <summary>Performs MQL Queries.</summary>
        /// <param name="query">Required - An envelope containing a single MQL query.</param>
        public virtual MqlreadRequest Mqlread(string query) {
            return new MqlreadRequest(service, query);
        }
        
        /// <summary>Method used to scale or crop image.</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Mode {
            
            /// <summary>TODO(bendrees)</summary>
            [Google.Apis.Util.StringValueAttribute("fill")]
            Fill,
            
            /// <summary>TODO(bendrees)</summary>
            [Google.Apis.Util.StringValueAttribute("fillcrop")]
            Fillcrop,
            
            /// <summary>TODO(bendrees)</summary>
            [Google.Apis.Util.StringValueAttribute("fillcropmid")]
            Fillcropmid,
            
            /// <summary>TODO(bendrees)</summary>
            [Google.Apis.Util.StringValueAttribute("fit")]
            Fit,
        }
        
        /// <summary>How MQL responds to uniqueness failures.</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Uniqueness_failure {
            
            /// <summary>Be strict - throw an error.</summary>
            [Google.Apis.Util.StringValueAttribute("hard")]
            Hard,
            
            /// <summary>Just return the first encountered object.</summary>
            [Google.Apis.Util.StringValueAttribute("soft")]
            Soft,
        }
        
        public class ImageRequest : Google.Apis.Requests.ServiceRequest<string> {
            
            private string oauth_token;
            
            private System.Boolean? prettyPrint;
            
            private string quotaUser;
            
            private string fallbackid;
            
            private Google.Apis.Util.Repeatable<string> id;
            
            private System.Int64? maxheight;
            
            private System.Int64? maxwidth;
            
            private Mode? mode;
            
            private System.Boolean? pad;
            
            public ImageRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Util.Repeatable<string> id) : 
                    base(service) {
                this.id = id;
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token")]
            public virtual string Oauth_token {
                get {
                    return this.oauth_token;
                }
                set {
                    this.oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint")]
            public virtual System.Boolean? PrettyPrint {
                get {
                    return this.prettyPrint;
                }
                set {
                    this.prettyPrint = value;
                }
            }
            
            /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser")]
            public virtual string QuotaUser {
                get {
                    return this.quotaUser;
                }
                set {
                    this.quotaUser = value;
                }
            }
            
            /// <summary>Use the image associated with this secondary id if no image is associated with the primary id.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fallbackid")]
            public virtual string Fallbackid {
                get {
                    return this.fallbackid;
                }
                set {
                    this.fallbackid = value;
                }
            }
            
            /// <summary>Freebase entity or content id, mid, or guid.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id")]
            public virtual Google.Apis.Util.Repeatable<string> Id {
                get {
                    return this.id;
                }
            }
            
            /// <summary>Maximum height in pixels for resulting image.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxheight")]
            public virtual System.Int64? Maxheight {
                get {
                    return this.maxheight;
                }
                set {
                    this.maxheight = value;
                }
            }
            
            /// <summary>Maximum width in pixels for resulting image.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxwidth")]
            public virtual System.Int64? Maxwidth {
                get {
                    return this.maxwidth;
                }
                set {
                    this.maxwidth = value;
                }
            }
            
            /// <summary>Method used to scale or crop image.</summary>
            [Google.Apis.Util.RequestParameterAttribute("mode")]
            public virtual Mode? Mode {
                get {
                    return this.mode;
                }
                set {
                    this.mode = value;
                }
            }
            
            /// <summary>A boolean specifying whether the resulting image should be padded up to the requested dimensions.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pad")]
            public virtual System.Boolean? Pad {
                get {
                    return this.pad;
                }
                set {
                    this.pad = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "";
                }
            }
            
            protected override string MethodName {
                get {
                    return "image";
                }
            }
        }
        
        public class MqlreadRequest : Google.Apis.Requests.ServiceRequest<string> {
            
            private string oauth_token;
            
            private System.Boolean? prettyPrint;
            
            private string quotaUser;
            
            private string as_of_time;
            
            private string callback;
            
            private System.Boolean? cost;
            
            private string cursor;
            
            private System.Boolean? html_escape;
            
            private System.Int64? indent;
            
            private string lang;
            
            private string query;
            
            private Uniqueness_failure? uniqueness_failure;
            
            public MqlreadRequest(Google.Apis.Discovery.IRequestProvider service, string query) : 
                    base(service) {
                this.query = query;
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token")]
            public virtual string Oauth_token {
                get {
                    return this.oauth_token;
                }
                set {
                    this.oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint")]
            public virtual System.Boolean? PrettyPrint {
                get {
                    return this.prettyPrint;
                }
                set {
                    this.prettyPrint = value;
                }
            }
            
            /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser")]
            public virtual string QuotaUser {
                get {
                    return this.quotaUser;
                }
                set {
                    this.quotaUser = value;
                }
            }
            
            /// <summary>Run the query as it would've been run at the specified point in time.</summary>
            [Google.Apis.Util.RequestParameterAttribute("as_of_time")]
            public virtual string As_of_time {
                get {
                    return this.as_of_time;
                }
                set {
                    this.as_of_time = value;
                }
            }
            
            /// <summary>JS method name for JSONP callbacks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("callback")]
            public virtual string Callback {
                get {
                    return this.callback;
                }
                set {
                    this.callback = value;
                }
            }
            
            /// <summary>Show the costs or not.</summary>
            [Google.Apis.Util.RequestParameterAttribute("cost")]
            public virtual System.Boolean? Cost {
                get {
                    return this.cost;
                }
                set {
                    this.cost = value;
                }
            }
            
            /// <summary>The mql cursor.</summary>
            [Google.Apis.Util.RequestParameterAttribute("cursor")]
            public virtual string Cursor {
                get {
                    return this.cursor;
                }
                set {
                    this.cursor = value;
                }
            }
            
            /// <summary>Whether or not to escape entities.</summary>
            [Google.Apis.Util.RequestParameterAttribute("html_escape")]
            public virtual System.Boolean? Html_escape {
                get {
                    return this.html_escape;
                }
                set {
                    this.html_escape = value;
                }
            }
            
            /// <summary>How many spaces to indent the json.</summary>
            [Google.Apis.Util.RequestParameterAttribute("indent")]
            public virtual System.Int64? Indent {
                get {
                    return this.indent;
                }
                set {
                    this.indent = value;
                }
            }
            
            /// <summary>The language of the results - an id of a /type/lang object.</summary>
            [Google.Apis.Util.RequestParameterAttribute("lang")]
            public virtual string Lang {
                get {
                    return this.lang;
                }
                set {
                    this.lang = value;
                }
            }
            
            /// <summary>An envelope containing a single MQL query.</summary>
            [Google.Apis.Util.RequestParameterAttribute("query")]
            public virtual string Query {
                get {
                    return this.query;
                }
            }
            
            /// <summary>How MQL responds to uniqueness failures.</summary>
            [Google.Apis.Util.RequestParameterAttribute("uniqueness_failure")]
            public virtual Uniqueness_failure? Uniqueness_failure {
                get {
                    return this.uniqueness_failure;
                }
                set {
                    this.uniqueness_failure = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "";
                }
            }
            
            protected override string MethodName {
                get {
                    return "mqlread";
                }
            }
        }
    }
}
