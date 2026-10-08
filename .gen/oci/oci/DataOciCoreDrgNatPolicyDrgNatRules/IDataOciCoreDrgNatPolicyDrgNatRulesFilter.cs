using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreDrgNatPolicyDrgNatRules
{
    [JsiiInterface(nativeType: typeof(IDataOciCoreDrgNatPolicyDrgNatRulesFilter), fullyQualifiedName: "oci.dataOciCoreDrgNatPolicyDrgNatRules.DataOciCoreDrgNatPolicyDrgNatRulesFilter")]
    public interface IDataOciCoreDrgNatPolicyDrgNatRulesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/core_drg_nat_policy_drg_nat_rules#name DataOciCoreDrgNatPolicyDrgNatRules#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/core_drg_nat_policy_drg_nat_rules#values DataOciCoreDrgNatPolicyDrgNatRules#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/core_drg_nat_policy_drg_nat_rules#regex DataOciCoreDrgNatPolicyDrgNatRules#regex}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciCoreDrgNatPolicyDrgNatRulesFilter), fullyQualifiedName: "oci.dataOciCoreDrgNatPolicyDrgNatRules.DataOciCoreDrgNatPolicyDrgNatRulesFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciCoreDrgNatPolicyDrgNatRules.IDataOciCoreDrgNatPolicyDrgNatRulesFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/core_drg_nat_policy_drg_nat_rules#name DataOciCoreDrgNatPolicyDrgNatRules#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/core_drg_nat_policy_drg_nat_rules#values DataOciCoreDrgNatPolicyDrgNatRules#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/core_drg_nat_policy_drg_nat_rules#regex DataOciCoreDrgNatPolicyDrgNatRules#regex}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
