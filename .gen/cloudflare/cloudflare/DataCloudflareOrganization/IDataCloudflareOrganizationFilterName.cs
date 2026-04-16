using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareOrganization
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareOrganizationFilterName), fullyQualifiedName: "cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterName")]
    public interface IDataCloudflareOrganizationFilterName
    {
        /// <summary>(case-insensitive) Filter the list of organizations to where the name contains a particular string.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/organization#contains DataCloudflareOrganization#contains}
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

        /// <summary>(case-insensitive) Filter the list of organizations to where the name ends with a particular string.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/organization#ends_with DataCloudflareOrganization#ends_with}
        /// </remarks>
        [JsiiProperty(name: "endsWith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndsWith
        {
            get
            {
                return null;
            }
        }

        /// <summary>(case-insensitive) Filter the list of organizations to where the name starts with a particular string.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/organization#starts_with DataCloudflareOrganization#starts_with}
        /// </remarks>
        [JsiiProperty(name: "startsWith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartsWith
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareOrganizationFilterName), fullyQualifiedName: "cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterName")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterName
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>(case-insensitive) Filter the list of organizations to where the name contains a particular string.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/organization#contains DataCloudflareOrganization#contains}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contains", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Contains
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(case-insensitive) Filter the list of organizations to where the name ends with a particular string.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/organization#ends_with DataCloudflareOrganization#ends_with}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endsWith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndsWith
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(case-insensitive) Filter the list of organizations to where the name starts with a particular string.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/organization#starts_with DataCloudflareOrganization#starts_with}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startsWith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartsWith
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
