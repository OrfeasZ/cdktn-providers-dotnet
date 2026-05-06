using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    [JsiiInterface(nativeType: typeof(IWaasWaasPolicyWafConfigCachingRulesCriteria), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigCachingRulesCriteria")]
    public interface IWaasWaasPolicyWafConfigCachingRulesCriteria
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

        [JsiiTypeProxy(nativeType: typeof(IWaasWaasPolicyWafConfigCachingRulesCriteria), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigCachingRulesCriteria")]
        internal sealed class _Proxy : DeputyBase, oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCachingRulesCriteria
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
        }
    }
}
