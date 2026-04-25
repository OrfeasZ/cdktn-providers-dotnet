using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.TokenValidationRules
{
    [JsiiInterface(nativeType: typeof(ITokenValidationRulesSelectorInclude), fullyQualifiedName: "cloudflare.tokenValidationRules.TokenValidationRulesSelectorInclude")]
    public interface ITokenValidationRulesSelectorInclude
    {
        /// <summary>Included hostnames.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/token_validation_rules#host TokenValidationRules#host}
        /// </remarks>
        [JsiiProperty(name: "host", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Host
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITokenValidationRulesSelectorInclude), fullyQualifiedName: "cloudflare.tokenValidationRules.TokenValidationRulesSelectorInclude")]
        internal sealed class _Proxy : DeputyBase, cloudflare.TokenValidationRules.ITokenValidationRulesSelectorInclude
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Included hostnames.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/token_validation_rules#host TokenValidationRules#host}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "host", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Host
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
