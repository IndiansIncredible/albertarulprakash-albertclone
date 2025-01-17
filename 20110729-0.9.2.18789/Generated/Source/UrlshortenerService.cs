//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Urlshortener.V1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class AnalyticsSnapshot {
        
        private IList<StringCount> browsers;
        
        private IList<StringCount> countries;
        
        private string longUrlClicks;
        
        private IList<StringCount> platforms;
        
        private IList<StringCount> referrers;
        
        private string shortUrlClicks;
        
        /// <summary>Top browsers, e.g. &quot;Chrome&quot;; sorted by (descending) click counts. Only present if this data is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("browsers")]
        public virtual IList<StringCount> Browsers {
            get {
                return this.browsers;
            }
            set {
                this.browsers = value;
            }
        }
        
        /// <summary>Top countries (expressed as country codes), e.g. &quot;US&quot; or &quot;DE&quot;; sorted by (descending) click counts. Only present if this data is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countries")]
        public virtual IList<StringCount> Countries {
            get {
                return this.countries;
            }
            set {
                this.countries = value;
            }
        }
        
        /// <summary>Number of clicks on all goo.gl short URLs pointing to this long URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longUrlClicks")]
        public virtual string LongUrlClicks {
            get {
                return this.longUrlClicks;
            }
            set {
                this.longUrlClicks = value;
            }
        }
        
        /// <summary>Top platforms or OSes, e.g. &quot;Windows&quot;; sorted by (descending) click counts. Only present if this data is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platforms")]
        public virtual IList<StringCount> Platforms {
            get {
                return this.platforms;
            }
            set {
                this.platforms = value;
            }
        }
        
        /// <summary>Top referring hosts, e.g. &quot;www.google.com&quot;; sorted by (descending) click counts. Only present if this data is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referrers")]
        public virtual IList<StringCount> Referrers {
            get {
                return this.referrers;
            }
            set {
                this.referrers = value;
            }
        }
        
        /// <summary>Number of clicks on this short URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortUrlClicks")]
        public virtual string ShortUrlClicks {
            get {
                return this.shortUrlClicks;
            }
            set {
                this.shortUrlClicks = value;
            }
        }
    }
    
    public class AnalyticsSummary {
        
        private AnalyticsSnapshot allTime;
        
        private AnalyticsSnapshot day;
        
        private AnalyticsSnapshot month;
        
        private AnalyticsSnapshot twoHours;
        
        private AnalyticsSnapshot week;
        
        [Newtonsoft.Json.JsonPropertyAttribute("allTime")]
        public virtual AnalyticsSnapshot AllTime {
            get {
                return this.allTime;
            }
            set {
                this.allTime = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual AnalyticsSnapshot Day {
            get {
                return this.day;
            }
            set {
                this.day = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual AnalyticsSnapshot Month {
            get {
                return this.month;
            }
            set {
                this.month = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("twoHours")]
        public virtual AnalyticsSnapshot TwoHours {
            get {
                return this.twoHours;
            }
            set {
                this.twoHours = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("week")]
        public virtual AnalyticsSnapshot Week {
            get {
                return this.week;
            }
            set {
                this.week = value;
            }
        }
    }
    
    public class StringCount {
        
        private string count;
        
        private string id;
        
        /// <summary>Number of clicks for this top entry, e.g. for this particular country or browser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual string Count {
            get {
                return this.count;
            }
            set {
                this.count = value;
            }
        }
        
        /// <summary>Label assigned to this top entry, e.g. &quot;US&quot; or &quot;Chrome&quot;.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }
    }
    
    public class Url : Google.Apis.Requests.IDirectResponseSchema {
        
        private AnalyticsSummary analytics;
        
        private string created;
        
        private string id;
        
        private string kind;
        
        private string longUrl;
        
        private string status;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        [Newtonsoft.Json.JsonPropertyAttribute("analytics")]
        public virtual AnalyticsSummary Analytics {
            get {
                return this.analytics;
            }
            set {
                this.analytics = value;
            }
        }
        
        /// <summary>Time the short URL was created; ISO 8601 representation using the yyyy-MM-dd&apos;T&apos;HH:mm:ss.SSSZZ format, e.g. &quot;2010-10-14T19:01:24.944+00:00&quot;.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("created")]
        public virtual string Created {
            get {
                return this.created;
            }
            set {
                this.created = value;
            }
        }
        
        /// <summary>Short URL, e.g. &quot;http://goo.gl/l6MS&quot;.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }
        
        /// <summary>The fixed string &quot;urlshortener#url&quot;.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        /// <summary>Long URL, e.g. &quot;http://www.google.com/&quot;. Might not be present if the status is &quot;REMOVED&quot;.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longUrl")]
        public virtual string LongUrl {
            get {
                return this.longUrl;
            }
            set {
                this.longUrl = value;
            }
        }
        
        /// <summary>Status of the target URL. Possible values: &quot;OK&quot;, &quot;MALWARE&quot;, &quot;PHISHING&quot;, or &quot;REMOVED&quot;. A URL might be marked &quot;REMOVED&quot; if it was flagged as spam, for example.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status {
            get {
                return this.status;
            }
            set {
                this.status = value;
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
    
    public class UrlHistory : Google.Apis.Requests.IDirectResponseSchema {
        
        private IList<Url> items;
        
        private long itemsPerPage;
        
        private string kind;
        
        private string nextPageToken;
        
        private long totalItems;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        /// <summary>A list of URL resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual IList<Url> Items {
            get {
                return this.items;
            }
            set {
                this.items = value;
            }
        }
        
        /// <summary>Number of items returned with each full &quot;page&quot; of results. Note that the last page could have fewer items than the &quot;itemsPerPage&quot; value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerPage")]
        public virtual long ItemsPerPage {
            get {
                return this.itemsPerPage;
            }
            set {
                this.itemsPerPage = value;
            }
        }
        
        /// <summary>The fixed string &quot;urlshortener#urlHistory&quot;.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        /// <summary>A token to provide to get the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken {
            get {
                return this.nextPageToken;
            }
            set {
                this.nextPageToken = value;
            }
        }
        
        /// <summary>Total number of short URLs associated with this user (may be approximate).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalItems")]
        public virtual long TotalItems {
            get {
                return this.totalItems;
            }
            set {
                this.totalItems = value;
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
namespace Google.Apis.Urlshortener.V1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public class UrlshortenerService : Google.Apis.Discovery.IRequestProvider {
        
        private Google.Apis.Discovery.IService genericService;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string Version = "v1";
        
        private const string Name = "urlshortener";
        
        private const string BaseUri = "https://www.googleapis.com/urlshortener/v1/";
        
        private const Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string developerKey;
        
        private UrlResource url;
        
        public UrlshortenerService(Google.Apis.Discovery.IService genericService, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.genericService = genericService;
            this.authenticator = authenticator;
            this.url = new UrlResource(this);
        }
        
        public UrlshortenerService() : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.CachedWebDiscoveryDevice(new System.Uri(string.Format("https://www.googleapis.com/discovery/v1/apis/{0}/{1}/rest", UrlshortenerService.Name, UrlshortenerService.Version)))).GetService(UrlshortenerService.Version, UrlshortenerService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameterV1_0(new System.Uri(UrlshortenerService.BaseUri))), Google.Apis.Authentication.AuthenticatorFactory.GetInstance().GetRegisteredAuthenticator()) {
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
        
        public virtual UrlResource Url {
            get {
                return this.url;
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
            
            /// <summary>Manage your goo.gl short URLs</summary>
            [Google.Apis.Util.StringValueAttribute("https://www.googleapis.com/auth/urlshortener")]
            Urlshortener,
        }
    }
    
    public class UrlResource {
        
        private Google.Apis.Discovery.IRequestProvider service;
        
        private const string Resource = "url";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(UrlResource));
        
        public UrlResource(UrlshortenerService service) {
            this.service = service;
        }
        
        /// <summary>Expands a short URL or gets creation time and analytics.</summary>
        /// <param name="shortUrl">Required - The short URL, including the protocol.</param>
        public virtual GetRequest Get(string shortUrl) {
            return new GetRequest(service, shortUrl);
        }
        
        /// <summary>Expands a short URL or gets creation time and analytics.</summary>
        /// <param name="shortUrl">Required - The short URL, including the protocol.</param>
        /// <param name="projection">Optional - Must be one of the following values [ANALYTICS_CLICKS, ANALYTICS_TOP_STRINGS, FULL] - Additional information to return.</param>
        public virtual GetRequest Get(string shortUrl, [System.Runtime.InteropServices.OptionalAttribute()] Projection? projection) {
            return new GetRequest(service, shortUrl, projection);
        }
        
        /// <summary>Creates a new short URL.</summary>
        public virtual InsertRequest Insert(Google.Apis.Urlshortener.V1.Data.Url body) {
            return new InsertRequest(service, body);
        }
        
        /// <summary>Retrieves a list of URLs shortened by a user.</summary>
        public virtual ListRequest List() {
            return new ListRequest(service);
        }
        
        /// <summary>Retrieves a list of URLs shortened by a user.</summary>
        /// <param name="projection">Optional - Must be one of the following values [ANALYTICS_CLICKS, FULL] - Additional information to return.</param>
        /// <param name="startToken">start-token - Optional - Token for requesting successive pages of results.</param>
        public virtual ListRequest List([System.Runtime.InteropServices.OptionalAttribute()] ProjectionEnum? projection, [System.Runtime.InteropServices.OptionalAttribute()] string startToken) {
            return new ListRequest(service, projection, startToken);
        }
        
        /// <summary>Additional information to return.</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Projection {
            
            /// <summary>Returns only click counts.</summary>
            [Google.Apis.Util.StringValueAttribute("ANALYTICS_CLICKS")]
            ANALYTICS_CLICKS,
            
            /// <summary>Returns only top string counts.</summary>
            [Google.Apis.Util.StringValueAttribute("ANALYTICS_TOP_STRINGS")]
            ANALYTICS_TOP_STRINGS,
            
            /// <summary>Returns the creation timestamp and all available analytics.</summary>
            [Google.Apis.Util.StringValueAttribute("FULL")]
            FULL,
        }
        
        /// <summary>Additional information to return.</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum ProjectionEnum {
            
            /// <summary>Returns short URL click counts.</summary>
            [Google.Apis.Util.StringValueAttribute("ANALYTICS_CLICKS")]
            ANALYTICS_CLICKS,
            
            /// <summary>Returns short URL click counts.</summary>
            [Google.Apis.Util.StringValueAttribute("FULL")]
            FULL,
        }
        
        public class GetRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Urlshortener.V1.Data.Url> {
            
            private Projection? projection;
            
            private string shortUrl;
            
            public GetRequest(Google.Apis.Discovery.IRequestProvider service, string shortUrl) : 
                    base(service) {
                this.shortUrl = shortUrl;
            }
            
            public GetRequest(Google.Apis.Discovery.IRequestProvider service, string shortUrl, [System.Runtime.InteropServices.OptionalAttribute()] Projection? projection) : 
                    base(service) {
                this.shortUrl = shortUrl;
                this.projection = projection;
            }
            
            /// <summary>Additional information to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection")]
            public virtual Projection? Projection {
                get {
                    return this.projection;
                }
                set {
                    this.projection = value;
                }
            }
            
            /// <summary>The short URL, including the protocol.</summary>
            [Google.Apis.Util.RequestParameterAttribute("shortUrl")]
            public virtual string ShortUrl {
                get {
                    return this.shortUrl;
                }
            }
            
            protected override string ResourceName {
                get {
                    return "url";
                }
            }
            
            protected override string MethodName {
                get {
                    return "get";
                }
            }
        }
        
        public class InsertRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Urlshortener.V1.Data.Url> {
            
            private Google.Apis.Urlshortener.V1.Data.Url bodyValue;
            
            public InsertRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Urlshortener.V1.Data.Url body) : 
                    base(service) {
                this.Body = body;
            }
            
            /// <summary>Gets/Sets the Body of this Request.</summary>
            public virtual Google.Apis.Urlshortener.V1.Data.Url Body {
                get {
                    return this.bodyValue;
                }
                set {
                    this.bodyValue = value;
                }
            }
            
            protected override string ResourceName {
                get {
                    return "url";
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
        
        public class ListRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Urlshortener.V1.Data.UrlHistory> {
            
            private ProjectionEnum? projection;
            
            private string startToken;
            
            public ListRequest(Google.Apis.Discovery.IRequestProvider service) : 
                    base(service) {
            }
            
            public ListRequest(Google.Apis.Discovery.IRequestProvider service, [System.Runtime.InteropServices.OptionalAttribute()] ProjectionEnum? projection, [System.Runtime.InteropServices.OptionalAttribute()] string startToken) : 
                    base(service) {
                this.projection = projection;
                this.startToken = startToken;
            }
            
            /// <summary>Additional information to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection")]
            public virtual ProjectionEnum? Projection {
                get {
                    return this.projection;
                }
                set {
                    this.projection = value;
                }
            }
            
            /// <summary>Token for requesting successive pages of results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("start-token")]
            public virtual string StartToken {
                get {
                    return this.startToken;
                }
                set {
                    this.startToken = value;
                }
            }
            
            protected override string ResourceName {
                get {
                    return "url";
                }
            }
            
            protected override string MethodName {
                get {
                    return "list";
                }
            }
        }
    }
}
