using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.SpacesBucket
{
    [JsiiInterface(nativeType: typeof(ISpacesBucketCorsRule), fullyQualifiedName: "digitalocean.spacesBucket.SpacesBucketCorsRule")]
    public interface ISpacesBucketCorsRule
    {
        /// <summary>A list of HTTP methods (e.g. GET) which are allowed from the specified origin.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/spaces_bucket#allowed_methods SpacesBucket#allowed_methods}
        /// </remarks>
        [JsiiProperty(name: "allowedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AllowedMethods
        {
            get;
        }

        /// <summary>A list of hosts from which requests using the specified methods are allowed.</summary>
        /// <remarks>
        /// A host may contain one wildcard (e.g. http://*.example.com).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/spaces_bucket#allowed_origins SpacesBucket#allowed_origins}
        /// </remarks>
        [JsiiProperty(name: "allowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AllowedOrigins
        {
            get;
        }

        /// <summary>A list of headers that will be included in the CORS preflight request's Access-Control-Request-Headers.</summary>
        /// <remarks>
        /// A header may contain one wildcard (e.g. x-amz-*).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/spaces_bucket#allowed_headers SpacesBucket#allowed_headers}
        /// </remarks>
        [JsiiProperty(name: "allowedHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/spaces_bucket#max_age_seconds SpacesBucket#max_age_seconds}.</summary>
        [JsiiProperty(name: "maxAgeSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxAgeSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpacesBucketCorsRule), fullyQualifiedName: "digitalocean.spacesBucket.SpacesBucketCorsRule")]
        internal sealed class _Proxy : DeputyBase, digitalocean.SpacesBucket.ISpacesBucketCorsRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A list of HTTP methods (e.g. GET) which are allowed from the specified origin.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/spaces_bucket#allowed_methods SpacesBucket#allowed_methods}
            /// </remarks>
            [JsiiProperty(name: "allowedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AllowedMethods
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>A list of hosts from which requests using the specified methods are allowed.</summary>
            /// <remarks>
            /// A host may contain one wildcard (e.g. http://*.example.com).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/spaces_bucket#allowed_origins SpacesBucket#allowed_origins}
            /// </remarks>
            [JsiiProperty(name: "allowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AllowedOrigins
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>A list of headers that will be included in the CORS preflight request's Access-Control-Request-Headers.</summary>
            /// <remarks>
            /// A header may contain one wildcard (e.g. x-amz-*).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/spaces_bucket#allowed_headers SpacesBucket#allowed_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedHeaders
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/spaces_bucket#max_age_seconds SpacesBucket#max_age_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxAgeSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxAgeSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
