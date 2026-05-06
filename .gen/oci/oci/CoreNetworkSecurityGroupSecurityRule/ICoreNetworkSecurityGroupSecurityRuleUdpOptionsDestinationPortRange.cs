using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreNetworkSecurityGroupSecurityRule
{
    [JsiiInterface(nativeType: typeof(ICoreNetworkSecurityGroupSecurityRuleUdpOptionsDestinationPortRange), fullyQualifiedName: "oci.coreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleUdpOptionsDestinationPortRange")]
    public interface ICoreNetworkSecurityGroupSecurityRuleUdpOptionsDestinationPortRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_network_security_group_security_rule#max CoreNetworkSecurityGroupSecurityRule#max}.</summary>
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}")]
        double Max
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_network_security_group_security_rule#min CoreNetworkSecurityGroupSecurityRule#min}.</summary>
        [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}")]
        double Min
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreNetworkSecurityGroupSecurityRuleUdpOptionsDestinationPortRange), fullyQualifiedName: "oci.coreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleUdpOptionsDestinationPortRange")]
        internal sealed class _Proxy : DeputyBase, oci.CoreNetworkSecurityGroupSecurityRule.ICoreNetworkSecurityGroupSecurityRuleUdpOptionsDestinationPortRange
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_network_security_group_security_rule#max CoreNetworkSecurityGroupSecurityRule#max}.</summary>
            [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}")]
            public double Max
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_network_security_group_security_rule#min CoreNetworkSecurityGroupSecurityRule#min}.</summary>
            [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}")]
            public double Min
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
