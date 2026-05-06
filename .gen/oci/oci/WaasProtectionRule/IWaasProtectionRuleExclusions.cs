using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasProtectionRule
{
    [JsiiInterface(nativeType: typeof(IWaasProtectionRuleExclusions), fullyQualifiedName: "oci.waasProtectionRule.WaasProtectionRuleExclusions")]
    public interface IWaasProtectionRuleExclusions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_protection_rule#exclusions WaasProtectionRule#exclusions}.</summary>
        [JsiiProperty(name: "exclusions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Exclusions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_protection_rule#target WaasProtectionRule#target}.</summary>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Target
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWaasProtectionRuleExclusions), fullyQualifiedName: "oci.waasProtectionRule.WaasProtectionRuleExclusions")]
        internal sealed class _Proxy : DeputyBase, oci.WaasProtectionRule.IWaasProtectionRuleExclusions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_protection_rule#exclusions WaasProtectionRule#exclusions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "exclusions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Exclusions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_protection_rule#target WaasProtectionRule#target}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Target
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
