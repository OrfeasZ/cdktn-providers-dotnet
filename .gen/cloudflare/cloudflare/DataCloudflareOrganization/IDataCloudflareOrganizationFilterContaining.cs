using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareOrganization
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareOrganizationFilterContaining), fullyQualifiedName: "cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterContaining")]
    public interface IDataCloudflareOrganizationFilterContaining
    {
        /// <summary>Filter the list of organizations to the ones that contain this particular account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/organization#account DataCloudflareOrganization#account}
        /// </remarks>
        [JsiiProperty(name: "account", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Account
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filter the list of organizations to the ones that contain this particular organization.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/organization#organization DataCloudflareOrganization#organization}
        /// </remarks>
        [JsiiProperty(name: "organization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Organization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filter the list of organizations to the ones that contain this particular user.</summary>
        /// <remarks>
        /// IMPORTANT: Just because an organization "contains" a user is not a
        /// representation of any authorization or privilege to manage any resources
        /// therein. An organization "containing" a user simply means the user is managed by
        /// that organization.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/organization#user DataCloudflareOrganization#user}
        /// </remarks>
        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? User
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareOrganizationFilterContaining), fullyQualifiedName: "cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterContaining")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterContaining
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Filter the list of organizations to the ones that contain this particular account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/organization#account DataCloudflareOrganization#account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "account", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Account
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter the list of organizations to the ones that contain this particular organization.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/organization#organization DataCloudflareOrganization#organization}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "organization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Organization
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter the list of organizations to the ones that contain this particular user.</summary>
            /// <remarks>
            /// IMPORTANT: Just because an organization "contains" a user is not a
            /// representation of any authorization or privilege to manage any resources
            /// therein. An organization "containing" a user simply means the user is managed by
            /// that organization.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/organization#user DataCloudflareOrganization#user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? User
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
