using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2BucketCors
{
    [JsiiInterface(nativeType: typeof(IR2BucketCorsRules), fullyQualifiedName: "cloudflare.r2BucketCors.R2BucketCorsRules")]
    public interface IR2BucketCorsRules
    {
        /// <summary>Object specifying allowed origins, methods and headers for this CORS rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_cors#allowed R2BucketCors#allowed}
        /// </remarks>
        [JsiiProperty(name: "allowed", typeJson: "{\"fqn\":\"cloudflare.r2BucketCors.R2BucketCorsRulesAllowed\"}")]
        cloudflare.R2BucketCors.IR2BucketCorsRulesAllowed Allowed
        {
            get;
        }

        /// <summary>Specifies the headers that can be exposed back, and accessed by, the JavaScript making the cross-origin request.</summary>
        /// <remarks>
        /// If you need to access headers beyond the safelisted response headers, such as Content-Encoding or cf-cache-status, you must specify it here.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_cors#expose_headers R2BucketCors#expose_headers}
        /// </remarks>
        [JsiiProperty(name: "exposeHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExposeHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>Identifier for this rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_cors#id R2BucketCors#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the amount of time (in seconds) browsers are allowed to cache CORS preflight responses.</summary>
        /// <remarks>
        /// Browsers may limit this to 2 hours or less, even if the maximum value (86400) is specified.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_cors#max_age_seconds R2BucketCors#max_age_seconds}
        /// </remarks>
        [JsiiProperty(name: "maxAgeSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxAgeSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IR2BucketCorsRules), fullyQualifiedName: "cloudflare.r2BucketCors.R2BucketCorsRules")]
        internal sealed class _Proxy : DeputyBase, cloudflare.R2BucketCors.IR2BucketCorsRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Object specifying allowed origins, methods and headers for this CORS rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_cors#allowed R2BucketCors#allowed}
            /// </remarks>
            [JsiiProperty(name: "allowed", typeJson: "{\"fqn\":\"cloudflare.r2BucketCors.R2BucketCorsRulesAllowed\"}")]
            public cloudflare.R2BucketCors.IR2BucketCorsRulesAllowed Allowed
            {
                get => GetInstanceProperty<cloudflare.R2BucketCors.IR2BucketCorsRulesAllowed>()!;
            }

            /// <summary>Specifies the headers that can be exposed back, and accessed by, the JavaScript making the cross-origin request.</summary>
            /// <remarks>
            /// If you need to access headers beyond the safelisted response headers, such as Content-Encoding or cf-cache-status, you must specify it here.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_cors#expose_headers R2BucketCors#expose_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exposeHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExposeHeaders
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Identifier for this rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_cors#id R2BucketCors#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies the amount of time (in seconds) browsers are allowed to cache CORS preflight responses.</summary>
            /// <remarks>
            /// Browsers may limit this to 2 hours or less, even if the maximum value (86400) is specified.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_cors#max_age_seconds R2BucketCors#max_age_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxAgeSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxAgeSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
