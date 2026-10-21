using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessApplicationTargetCriteriaIncludeTargetAttributes), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationTargetCriteriaIncludeTargetAttributes")]
    public interface IZeroTrustAccessApplicationTargetCriteriaIncludeTargetAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.1/docs/resources/zero_trust_access_application#hostname ZeroTrustAccessApplication#hostname}.</summary>
        [JsiiProperty(name: "hostname", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Hostname
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessApplicationTargetCriteriaIncludeTargetAttributes), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationTargetCriteriaIncludeTargetAttributes")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationTargetCriteriaIncludeTargetAttributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.1/docs/resources/zero_trust_access_application#hostname ZeroTrustAccessApplication#hostname}.</summary>
            [JsiiProperty(name: "hostname", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Hostname
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
