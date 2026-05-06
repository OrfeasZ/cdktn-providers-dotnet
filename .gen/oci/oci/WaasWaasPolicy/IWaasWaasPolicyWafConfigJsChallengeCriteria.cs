using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    [JsiiInterface(nativeType: typeof(IWaasWaasPolicyWafConfigJsChallengeCriteria), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigJsChallengeCriteria")]
    public interface IWaasWaasPolicyWafConfigJsChallengeCriteria
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#condition WaasWaasPolicy#condition}.</summary>
        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}")]
        string Condition
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#value WaasWaasPolicy#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_case_sensitive WaasWaasPolicy#is_case_sensitive}.</summary>
        [JsiiProperty(name: "isCaseSensitive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsCaseSensitive
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWaasWaasPolicyWafConfigJsChallengeCriteria), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigJsChallengeCriteria")]
        internal sealed class _Proxy : DeputyBase, oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigJsChallengeCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#condition WaasWaasPolicy#condition}.</summary>
            [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}")]
            public string Condition
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#value WaasWaasPolicy#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_case_sensitive WaasWaasPolicy#is_case_sensitive}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isCaseSensitive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsCaseSensitive
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
