using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDexTest
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareZeroTrustDexTestFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustDexTest.DataCloudflareZeroTrustDexTestFilter")]
    public interface IDataCloudflareZeroTrustDexTestFilter
    {
        /// <summary>Filter by test type Available values: "http", "traceroute".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zero_trust_dex_test#kind DataCloudflareZeroTrustDexTest#kind}
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Kind
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filter by test name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zero_trust_dex_test#test_name DataCloudflareZeroTrustDexTest#test_name}
        /// </remarks>
        [JsiiProperty(name: "testName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TestName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareZeroTrustDexTestFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustDexTest.DataCloudflareZeroTrustDexTestFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareZeroTrustDexTest.IDataCloudflareZeroTrustDexTestFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Filter by test type Available values: "http", "traceroute".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zero_trust_dex_test#kind DataCloudflareZeroTrustDexTest#kind}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Kind
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter by test name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zero_trust_dex_test#test_name DataCloudflareZeroTrustDexTest#test_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "testName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TestName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
