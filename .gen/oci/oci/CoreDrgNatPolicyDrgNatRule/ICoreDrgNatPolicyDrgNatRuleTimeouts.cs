using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDrgNatPolicyDrgNatRule
{
    [JsiiInterface(nativeType: typeof(ICoreDrgNatPolicyDrgNatRuleTimeouts), fullyQualifiedName: "oci.coreDrgNatPolicyDrgNatRule.CoreDrgNatPolicyDrgNatRuleTimeouts")]
    public interface ICoreDrgNatPolicyDrgNatRuleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule#create CoreDrgNatPolicyDrgNatRule#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule#delete CoreDrgNatPolicyDrgNatRule#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule#update CoreDrgNatPolicyDrgNatRule#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreDrgNatPolicyDrgNatRuleTimeouts), fullyQualifiedName: "oci.coreDrgNatPolicyDrgNatRule.CoreDrgNatPolicyDrgNatRuleTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.CoreDrgNatPolicyDrgNatRule.ICoreDrgNatPolicyDrgNatRuleTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule#create CoreDrgNatPolicyDrgNatRule#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule#delete CoreDrgNatPolicyDrgNatRule#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule#update CoreDrgNatPolicyDrgNatRule#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
