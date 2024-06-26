using System.Net.Http.Headers;

namespace ACMESharp.Protocol
{
    public static class Constants
    {
        /// <summary>
        /// Date Time format used by ACME <c>notBefore</c> and <c>notAfter</c>
        /// fields, as defined by
        /// <see ref="https://tools.ietf.org/html/rfc3339">RFC3339</see> and
        /// <see ref="https://tools.ietf.org/html/rfc3339#ref-ISO8601">ISO 8601</see>.
        /// </summary>
        public const string Rfc3339DateTimeFormat = "yyyy-MM-dd'T'HH:mm:ssK"; 

        /// <summary>
        /// https://tools.ietf.org/html/draft-ietf-acme-acme-12#section-6.1
        /// </summary>
        public const string AcceptLanguageHeaderValue = "en-us";

        /// <summary>
        /// https://tools.ietf.org/html/draft-ietf-acme-acme-12#section-6.2
        /// </summary>
        public const string ContentTypeHeaderName = "Content-Type";
        /// <summary>
        /// https://tools.ietf.org/html/draft-ietf-acme-acme-12#section-6.2
        /// </summary>
        // public const string ContentTypeHeaderValue = "application/jose+json";
        public static readonly MediaTypeHeaderValue JsonContentTypeHeaderValue =
                MediaTypeHeaderValue.Parse("application/jose+json");
        public static readonly MediaTypeHeaderValue ProblemContentTypeHeaderValue =
                MediaTypeHeaderValue.Parse("application/problem+json");

        /// <summary>
        /// https://tools.ietf.org/html/draft-ietf-acme-acme-12#section-6.6
        /// </summary>
        public const string ErrorTypeNamespacePrefix = "urn:ietf:params:acme:error:";

        /// <summary>
        /// https://tools.ietf.org/html/draft-ietf-acme-acme-12#section-7.2
        /// </summary>
        public const string ReplayNonceHeaderName = "Replay-Nonce";

        /// <summary>
        /// The Link Header Relation key used to identify a URL to the Terms-Of-Service.
        /// </summary>
        public const string TosLinkHeaderRelationKey = "terms-of-service";
    }
}