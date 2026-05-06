using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreSecurityList
{
    [JsiiInterface(nativeType: typeof(ICoreSecurityListIngressSecurityRulesUdpOptions), fullyQualifiedName: "oci.coreSecurityList.CoreSecurityListIngressSecurityRulesUdpOptions")]
    public interface ICoreSecurityListIngressSecurityRulesUdpOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#max CoreSecurityList#max}.</summary>
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Max
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#min CoreSecurityList#min}.</summary>
        [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Min
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#source_port_range CoreSecurityList#source_port_range}
        /// </remarks>
        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListIngressSecurityRulesUdpOptionsSourcePortRange\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreSecurityList.ICoreSecurityListIngressSecurityRulesUdpOptionsSourcePortRange? SourcePortRange
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreSecurityListIngressSecurityRulesUdpOptions), fullyQualifiedName: "oci.coreSecurityList.CoreSecurityListIngressSecurityRulesUdpOptions")]
        internal sealed class _Proxy : DeputyBase, oci.CoreSecurityList.ICoreSecurityListIngressSecurityRulesUdpOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#max CoreSecurityList#max}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Max
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#min CoreSecurityList#min}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Min
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>source_port_range block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#source_port_range CoreSecurityList#source_port_range}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListIngressSecurityRulesUdpOptionsSourcePortRange\"}", isOptional: true)]
            public oci.CoreSecurityList.ICoreSecurityListIngressSecurityRulesUdpOptionsSourcePortRange? SourcePortRange
            {
                get => GetInstanceProperty<oci.CoreSecurityList.ICoreSecurityListIngressSecurityRulesUdpOptionsSourcePortRange?>();
            }
        }
    }
}
