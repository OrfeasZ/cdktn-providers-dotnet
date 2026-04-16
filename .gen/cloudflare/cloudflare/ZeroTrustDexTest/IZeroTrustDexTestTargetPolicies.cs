using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDexTest
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDexTestTargetPolicies), fullyQualifiedName: "cloudflare.zeroTrustDexTest.ZeroTrustDexTestTargetPolicies")]
    public interface IZeroTrustDexTestTargetPolicies
    {
        /// <summary>The id of the DEX rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dex_test#id ZeroTrustDexTest#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDexTestTargetPolicies), fullyQualifiedName: "cloudflare.zeroTrustDexTest.ZeroTrustDexTestTargetPolicies")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDexTest.IZeroTrustDexTestTargetPolicies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The id of the DEX rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dex_test#id ZeroTrustDexTest#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
