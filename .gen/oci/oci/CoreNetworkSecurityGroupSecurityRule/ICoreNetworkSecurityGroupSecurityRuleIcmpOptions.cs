using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreNetworkSecurityGroupSecurityRule
{
    [JsiiInterface(nativeType: typeof(ICoreNetworkSecurityGroupSecurityRuleIcmpOptions), fullyQualifiedName: "oci.coreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleIcmpOptions")]
    public interface ICoreNetworkSecurityGroupSecurityRuleIcmpOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_network_security_group_security_rule#type CoreNetworkSecurityGroupSecurityRule#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"number\"}")]
        double Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_network_security_group_security_rule#code CoreNetworkSecurityGroupSecurityRule#code}.</summary>
        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Code
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreNetworkSecurityGroupSecurityRuleIcmpOptions), fullyQualifiedName: "oci.coreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleIcmpOptions")]
        internal sealed class _Proxy : DeputyBase, oci.CoreNetworkSecurityGroupSecurityRule.ICoreNetworkSecurityGroupSecurityRuleIcmpOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_network_security_group_security_rule#type CoreNetworkSecurityGroupSecurityRule#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"number\"}")]
            public double Type
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_network_security_group_security_rule#code CoreNetworkSecurityGroupSecurityRule#code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Code
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
