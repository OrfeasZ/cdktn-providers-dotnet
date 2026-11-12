using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareOrganization
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareOrganizationFilterMember), fullyQualifiedName: "cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterMember")]
    public interface IDataCloudflareOrganizationFilterMember
    {
        /// <summary>Filter organizations to those where the given user, by email, is an active member of that exact organization.</summary>
        /// <remarks>
        /// This does not include hierarchy-derived access.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/organization#email DataCloudflareOrganization#email}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareOrganizationFilterMember), fullyQualifiedName: "cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterMember")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterMember
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Filter organizations to those where the given user, by email, is an active member of that exact organization.</summary>
            /// <remarks>
            /// This does not include hierarchy-derived access.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/organization#email DataCloudflareOrganization#email}
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
