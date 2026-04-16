using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecIngressRuleMatchAuthority), fullyQualifiedName: "digitalocean.app.AppSpecIngressRuleMatchAuthority")]
    public interface IAppSpecIngressRuleMatchAuthority
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#exact App#exact}.</summary>
        [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Exact
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecIngressRuleMatchAuthority), fullyQualifiedName: "digitalocean.app.AppSpecIngressRuleMatchAuthority")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecIngressRuleMatchAuthority
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#exact App#exact}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Exact
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
