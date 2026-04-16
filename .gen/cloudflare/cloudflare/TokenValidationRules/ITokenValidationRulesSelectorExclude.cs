using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.TokenValidationRules
{
    [JsiiInterface(nativeType: typeof(ITokenValidationRulesSelectorExclude), fullyQualifiedName: "cloudflare.tokenValidationRules.TokenValidationRulesSelectorExclude")]
    public interface ITokenValidationRulesSelectorExclude
    {
        /// <summary>Excluded operation IDs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#operation_ids TokenValidationRules#operation_ids}
        /// </remarks>
        [JsiiProperty(name: "operationIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OperationIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITokenValidationRulesSelectorExclude), fullyQualifiedName: "cloudflare.tokenValidationRules.TokenValidationRulesSelectorExclude")]
        internal sealed class _Proxy : DeputyBase, cloudflare.TokenValidationRules.ITokenValidationRulesSelectorExclude
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Excluded operation IDs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#operation_ids TokenValidationRules#operation_ids}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "operationIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OperationIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
