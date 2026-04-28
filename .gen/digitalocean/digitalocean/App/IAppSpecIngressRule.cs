using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecIngressRule), fullyQualifiedName: "digitalocean.app.AppSpecIngressRule")]
    public interface IAppSpecIngressRule
    {
        /// <summary>component block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#component App#component}
        /// </remarks>
        [JsiiProperty(name: "component", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleComponent\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecIngressRuleComponent? Component
        {
            get
            {
                return null;
            }
        }

        /// <summary>cors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#cors App#cors}
        /// </remarks>
        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleCors\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecIngressRuleCors? Cors
        {
            get
            {
                return null;
            }
        }

        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#match App#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleMatch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecIngressRuleMatch? Match
        {
            get
            {
                return null;
            }
        }

        /// <summary>redirect block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#redirect App#redirect}
        /// </remarks>
        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleRedirect\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecIngressRuleRedirect? Redirect
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecIngressRule), fullyQualifiedName: "digitalocean.app.AppSpecIngressRule")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecIngressRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>component block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#component App#component}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "component", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleComponent\"}", isOptional: true)]
            public digitalocean.App.IAppSpecIngressRuleComponent? Component
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecIngressRuleComponent?>();
            }

            /// <summary>cors block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#cors App#cors}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleCors\"}", isOptional: true)]
            public digitalocean.App.IAppSpecIngressRuleCors? Cors
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecIngressRuleCors?>();
            }

            /// <summary>match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#match App#match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleMatch\"}", isOptional: true)]
            public digitalocean.App.IAppSpecIngressRuleMatch? Match
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecIngressRuleMatch?>();
            }

            /// <summary>redirect block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#redirect App#redirect}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleRedirect\"}", isOptional: true)]
            public digitalocean.App.IAppSpecIngressRuleRedirect? Redirect
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecIngressRuleRedirect?>();
            }
        }
    }
}
