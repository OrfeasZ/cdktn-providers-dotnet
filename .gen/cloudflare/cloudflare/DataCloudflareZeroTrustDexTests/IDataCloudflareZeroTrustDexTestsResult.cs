using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDexTests
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareZeroTrustDexTestsResult), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustDexTests.DataCloudflareZeroTrustDexTestsResult")]
    public interface IDataCloudflareZeroTrustDexTestsResult
    {
        /// <summary>DEX rules targeted by this test.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_dex_tests#target_policies DataCloudflareZeroTrustDexTests#target_policies}
        /// </remarks>
        [JsiiProperty(name: "targetPolicies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDexTests.DataCloudflareZeroTrustDexTestsResultTargetPolicies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TargetPolicies
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareZeroTrustDexTestsResult), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustDexTests.DataCloudflareZeroTrustDexTestsResult")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareZeroTrustDexTests.IDataCloudflareZeroTrustDexTestsResult
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>DEX rules targeted by this test.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_dex_tests#target_policies DataCloudflareZeroTrustDexTests#target_policies}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetPolicies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDexTests.DataCloudflareZeroTrustDexTestsResultTargetPolicies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TargetPolicies
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
