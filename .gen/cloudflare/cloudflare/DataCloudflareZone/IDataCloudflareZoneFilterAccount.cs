using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZone
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareZoneFilterAccount), fullyQualifiedName: "cloudflare.dataCloudflareZone.DataCloudflareZoneFilterAccount")]
    public interface IDataCloudflareZoneFilterAccount
    {
        /// <summary>Filter by an account ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone#id DataCloudflareZone#id}
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

        /// <summary>An account Name.</summary>
        /// <remarks>
        /// Optional filter operators can be provided to extend refine the search:
        ///
        /// <list type="bullet">
        /// <description><c>equal</c> (default)</description>
        /// <description><c>not_equal</c></description>
        /// <description><c>starts_with</c></description>
        /// <description><c>ends_with</c></description>
        /// <description><c>contains</c></description>
        /// <description><c>starts_with_case_sensitive</c></description>
        /// <description><c>ends_with_case_sensitive</c></description>
        /// <description><c>contains_case_sensitive</c></description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone#name DataCloudflareZone#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareZoneFilterAccount), fullyQualifiedName: "cloudflare.dataCloudflareZone.DataCloudflareZoneFilterAccount")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareZone.IDataCloudflareZoneFilterAccount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Filter by an account ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone#id DataCloudflareZone#id}
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

            /// <summary>An account Name.</summary>
            /// <remarks>
            /// Optional filter operators can be provided to extend refine the search:
            ///
            /// <list type="bullet">
            /// <description><c>equal</c> (default)</description>
            /// <description><c>not_equal</c></description>
            /// <description><c>starts_with</c></description>
            /// <description><c>ends_with</c></description>
            /// <description><c>contains</c></description>
            /// <description><c>starts_with_case_sensitive</c></description>
            /// <description><c>ends_with_case_sensitive</c></description>
            /// <description><c>contains_case_sensitive</c></description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone#name DataCloudflareZone#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
