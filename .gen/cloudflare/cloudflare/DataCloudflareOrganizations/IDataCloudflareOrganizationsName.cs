using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareOrganizations
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareOrganizationsName), fullyQualifiedName: "cloudflare.dataCloudflareOrganizations.DataCloudflareOrganizationsName")]
    public interface IDataCloudflareOrganizationsName
    {
        /// <summary>(case-insensitive) Filter the list of organizations to where the name contains a particular string.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/organizations#contains DataCloudflareOrganizations#contains}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/organizations#ends_with DataCloudflareOrganizations#ends_with}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/organizations#starts_with DataCloudflareOrganizations#starts_with}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareOrganizationsName), fullyQualifiedName: "cloudflare.dataCloudflareOrganizations.DataCloudflareOrganizationsName")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareOrganizations.IDataCloudflareOrganizationsName
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>(case-insensitive) Filter the list of organizations to where the name contains a particular string.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/organizations#contains DataCloudflareOrganizations#contains}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contains", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Contains
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(case-insensitive) Filter the list of organizations to where the name ends with a particular string.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/organizations#ends_with DataCloudflareOrganizations#ends_with}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endsWith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndsWith
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(case-insensitive) Filter the list of organizations to where the name starts with a particular string.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/organizations#starts_with DataCloudflareOrganizations#starts_with}
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
