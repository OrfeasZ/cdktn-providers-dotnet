using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessApplicationTargetCriteriaRequire), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationTargetCriteriaRequire")]
    public interface IZeroTrustAccessApplicationTargetCriteriaRequire
    {
        /// <summary>Map of target tag keys to values. Values within a key are OR'd.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.1/docs/resources/zero_trust_access_application#tags ZeroTrustAccessApplication#tags}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, (string)[]&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Hostname selector map. Only the hostname key is supported.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.1/docs/resources/zero_trust_access_application#target_attributes ZeroTrustAccessApplication#target_attributes}
        /// </remarks>
        [JsiiProperty(name: "targetAttributes", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationTargetCriteriaRequireTargetAttributes\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationTargetCriteriaRequireTargetAttributes? TargetAttributes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessApplicationTargetCriteriaRequire), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationTargetCriteriaRequire")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationTargetCriteriaRequire
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Map of target tag keys to values. Values within a key are OR'd.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.1/docs/resources/zero_trust_access_application#tags ZeroTrustAccessApplication#tags}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, (string)[]&gt;</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Tags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Hostname selector map. Only the hostname key is supported.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.1/docs/resources/zero_trust_access_application#target_attributes ZeroTrustAccessApplication#target_attributes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetAttributes", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationTargetCriteriaRequireTargetAttributes\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationTargetCriteriaRequireTargetAttributes? TargetAttributes
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationTargetCriteriaRequireTargetAttributes?>();
            }
        }
    }
}
