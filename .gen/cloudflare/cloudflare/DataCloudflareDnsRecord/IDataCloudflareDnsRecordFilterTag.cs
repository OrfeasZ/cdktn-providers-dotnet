using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareDnsRecord
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareDnsRecordFilterTag), fullyQualifiedName: "cloudflare.dataCloudflareDnsRecord.DataCloudflareDnsRecordFilterTag")]
    public interface IDataCloudflareDnsRecordFilterTag
    {
        /// <summary>Name of a tag which must *not* be present on the DNS record. Tag filters are case-insensitive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#absent DataCloudflareDnsRecord#absent}
        /// </remarks>
        [JsiiProperty(name: "absent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Absent
        {
            get
            {
                return null;
            }
        }

        /// <summary>A tag and value, of the form `&lt;tag-name&gt;:&lt;tag-value&gt;`.</summary>
        /// <remarks>
        /// The API will only return DNS records that have a tag named <c>&lt;tag-name&gt;</c> whose value contains <c>&lt;tag-value&gt;</c>. Tag filters are case-insensitive.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#contains DataCloudflareDnsRecord#contains}
        /// </remarks>
        [JsiiProperty(name: "contains", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Contains
        {
            get
            {
                return null;
            }
        }

        /// <summary>A tag and value, of the form `&lt;tag-name&gt;:&lt;tag-value&gt;`.</summary>
        /// <remarks>
        /// The API will only return DNS records that have a tag named <c>&lt;tag-name&gt;</c> whose value ends with <c>&lt;tag-value&gt;</c>. Tag filters are case-insensitive.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#endswith DataCloudflareDnsRecord#endswith}
        /// </remarks>
        [JsiiProperty(name: "endswith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Endswith
        {
            get
            {
                return null;
            }
        }

        /// <summary>A tag and value, of the form `&lt;tag-name&gt;:&lt;tag-value&gt;`.</summary>
        /// <remarks>
        /// The API will only return DNS records that have a tag named <c>&lt;tag-name&gt;</c> whose value is <c>&lt;tag-value&gt;</c>. Tag filters are case-insensitive.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#exact DataCloudflareDnsRecord#exact}
        /// </remarks>
        [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Exact
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of a tag which must be present on the DNS record. Tag filters are case-insensitive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#present DataCloudflareDnsRecord#present}
        /// </remarks>
        [JsiiProperty(name: "present", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Present
        {
            get
            {
                return null;
            }
        }

        /// <summary>A tag and value, of the form `&lt;tag-name&gt;:&lt;tag-value&gt;`.</summary>
        /// <remarks>
        /// The API will only return DNS records that have a tag named <c>&lt;tag-name&gt;</c> whose value starts with <c>&lt;tag-value&gt;</c>. Tag filters are case-insensitive.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#startswith DataCloudflareDnsRecord#startswith}
        /// </remarks>
        [JsiiProperty(name: "startswith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Startswith
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareDnsRecordFilterTag), fullyQualifiedName: "cloudflare.dataCloudflareDnsRecord.DataCloudflareDnsRecordFilterTag")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareDnsRecord.IDataCloudflareDnsRecordFilterTag
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name of a tag which must *not* be present on the DNS record. Tag filters are case-insensitive.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#absent DataCloudflareDnsRecord#absent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "absent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Absent
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A tag and value, of the form `&lt;tag-name&gt;:&lt;tag-value&gt;`.</summary>
            /// <remarks>
            /// The API will only return DNS records that have a tag named <c>&lt;tag-name&gt;</c> whose value contains <c>&lt;tag-value&gt;</c>. Tag filters are case-insensitive.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#contains DataCloudflareDnsRecord#contains}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contains", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Contains
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A tag and value, of the form `&lt;tag-name&gt;:&lt;tag-value&gt;`.</summary>
            /// <remarks>
            /// The API will only return DNS records that have a tag named <c>&lt;tag-name&gt;</c> whose value ends with <c>&lt;tag-value&gt;</c>. Tag filters are case-insensitive.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#endswith DataCloudflareDnsRecord#endswith}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endswith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Endswith
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A tag and value, of the form `&lt;tag-name&gt;:&lt;tag-value&gt;`.</summary>
            /// <remarks>
            /// The API will only return DNS records that have a tag named <c>&lt;tag-name&gt;</c> whose value is <c>&lt;tag-value&gt;</c>. Tag filters are case-insensitive.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#exact DataCloudflareDnsRecord#exact}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Exact
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of a tag which must be present on the DNS record. Tag filters are case-insensitive.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#present DataCloudflareDnsRecord#present}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "present", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Present
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A tag and value, of the form `&lt;tag-name&gt;:&lt;tag-value&gt;`.</summary>
            /// <remarks>
            /// The API will only return DNS records that have a tag named <c>&lt;tag-name&gt;</c> whose value starts with <c>&lt;tag-value&gt;</c>. Tag filters are case-insensitive.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/dns_record#startswith DataCloudflareDnsRecord#startswith}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startswith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Startswith
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
