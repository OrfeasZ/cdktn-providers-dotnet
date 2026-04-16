using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2BucketCors
{
    [JsiiInterface(nativeType: typeof(IR2BucketCorsRulesAllowed), fullyQualifiedName: "cloudflare.r2BucketCors.R2BucketCorsRulesAllowed")]
    public interface IR2BucketCorsRulesAllowed
    {
        /// <summary>Specifies the value for the Access-Control-Allow-Methods header R2 sets when requesting objects in a bucket from a browser.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_cors#methods R2BucketCors#methods}
        /// </remarks>
        [JsiiProperty(name: "methods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Methods
        {
            get;
        }

        /// <summary>Specifies the value for the Access-Control-Allow-Origin header R2 sets when requesting objects in a bucket from a browser.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_cors#origins R2BucketCors#origins}
        /// </remarks>
        [JsiiProperty(name: "origins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Origins
        {
            get;
        }

        /// <summary>Specifies the value for the Access-Control-Allow-Headers header R2 sets when requesting objects in this bucket from a browser.</summary>
        /// <remarks>
        /// Cross-origin requests that include custom headers (e.g. x-user-id) should specify these headers as AllowedHeaders.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_cors#headers R2BucketCors#headers}
        /// </remarks>
        [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Headers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IR2BucketCorsRulesAllowed), fullyQualifiedName: "cloudflare.r2BucketCors.R2BucketCorsRulesAllowed")]
        internal sealed class _Proxy : DeputyBase, cloudflare.R2BucketCors.IR2BucketCorsRulesAllowed
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the value for the Access-Control-Allow-Methods header R2 sets when requesting objects in a bucket from a browser.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_cors#methods R2BucketCors#methods}
            /// </remarks>
            [JsiiProperty(name: "methods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Methods
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Specifies the value for the Access-Control-Allow-Origin header R2 sets when requesting objects in a bucket from a browser.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_cors#origins R2BucketCors#origins}
            /// </remarks>
            [JsiiProperty(name: "origins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Origins
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Specifies the value for the Access-Control-Allow-Headers header R2 sets when requesting objects in this bucket from a browser.</summary>
            /// <remarks>
            /// Cross-origin requests that include custom headers (e.g. x-user-id) should specify these headers as AllowedHeaders.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_cors#headers R2BucketCors#headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Headers
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
