using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareOrganization
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareOrganizationFilterParent), fullyQualifiedName: "cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterParent")]
    public interface IDataCloudflareOrganizationFilterParent
    {
        /// <summary>Filter the list of organizations to the ones that are a sub-organization of the specified organization.</summary>
        /// <remarks>
        /// "null" is a valid value to provide for this parameter. It means "where
        /// an organization has no parent (i.e. it is a 'root' organization)."
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/organization#id DataCloudflareOrganization#id}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareOrganizationFilterParent), fullyQualifiedName: "cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterParent")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterParent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Filter the list of organizations to the ones that are a sub-organization of the specified organization.</summary>
            /// <remarks>
            /// "null" is a valid value to provide for this parameter. It means "where
            /// an organization has no parent (i.e. it is a 'root' organization)."
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/organization#id DataCloudflareOrganization#id}
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
        }
    }
}
