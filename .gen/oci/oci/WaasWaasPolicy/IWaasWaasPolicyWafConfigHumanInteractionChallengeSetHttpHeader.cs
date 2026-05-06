using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    [JsiiInterface(nativeType: typeof(IWaasWaasPolicyWafConfigHumanInteractionChallengeSetHttpHeader), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigHumanInteractionChallengeSetHttpHeader")]
    public interface IWaasWaasPolicyWafConfigHumanInteractionChallengeSetHttpHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#name WaasWaasPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#value WaasWaasPolicy#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWaasWaasPolicyWafConfigHumanInteractionChallengeSetHttpHeader), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigHumanInteractionChallengeSetHttpHeader")]
        internal sealed class _Proxy : DeputyBase, oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigHumanInteractionChallengeSetHttpHeader
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#name WaasWaasPolicy#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
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
