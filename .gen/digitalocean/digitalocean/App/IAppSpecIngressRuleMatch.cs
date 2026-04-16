using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecIngressRuleMatch), fullyQualifiedName: "digitalocean.app.AppSpecIngressRuleMatch")]
    public interface IAppSpecIngressRuleMatch
    {
        /// <summary>authority block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#authority App#authority}
        /// </remarks>
        [JsiiProperty(name: "authority", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleMatchAuthority\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecIngressRuleMatchAuthority? Authority
        {
            get
            {
                return null;
            }
        }

        /// <summary>path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#path App#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleMatchPath\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecIngressRuleMatchPath? Path
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecIngressRuleMatch), fullyQualifiedName: "digitalocean.app.AppSpecIngressRuleMatch")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecIngressRuleMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>authority block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#authority App#authority}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authority", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleMatchAuthority\"}", isOptional: true)]
            public digitalocean.App.IAppSpecIngressRuleMatchAuthority? Authority
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecIngressRuleMatchAuthority?>();
            }

            /// <summary>path block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#path App#path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleMatchPath\"}", isOptional: true)]
            public digitalocean.App.IAppSpecIngressRuleMatchPath? Path
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecIngressRuleMatchPath?>();
            }
        }
    }
}
