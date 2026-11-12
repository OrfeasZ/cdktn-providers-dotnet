using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareOrganizations
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareOrganizationsMember), fullyQualifiedName: "cloudflare.dataCloudflareOrganizations.DataCloudflareOrganizationsMember")]
    public interface IDataCloudflareOrganizationsMember
    {
        /// <summary>Filter organizations to those where the given user, by email, is an active member of that exact organization.</summary>
        /// <remarks>
        /// This does not include hierarchy-derived access.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/organizations#email DataCloudflareOrganizations#email}
        /// </remarks>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Email
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareOrganizationsMember), fullyQualifiedName: "cloudflare.dataCloudflareOrganizations.DataCloudflareOrganizationsMember")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareOrganizations.IDataCloudflareOrganizationsMember
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Filter organizations to those where the given user, by email, is an active member of that exact organization.</summary>
            /// <remarks>
            /// This does not include hierarchy-derived access.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/organizations#email DataCloudflareOrganizations#email}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Email
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
