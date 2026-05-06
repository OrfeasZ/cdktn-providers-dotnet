using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreSecurityList
{
    [JsiiInterface(nativeType: typeof(ICoreSecurityListEgressSecurityRulesTcpOptionsSourcePortRange), fullyQualifiedName: "oci.coreSecurityList.CoreSecurityListEgressSecurityRulesTcpOptionsSourcePortRange")]
    public interface ICoreSecurityListEgressSecurityRulesTcpOptionsSourcePortRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#max CoreSecurityList#max}.</summary>
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}")]
        double Max
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#min CoreSecurityList#min}.</summary>
        [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}")]
        double Min
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreSecurityListEgressSecurityRulesTcpOptionsSourcePortRange), fullyQualifiedName: "oci.coreSecurityList.CoreSecurityListEgressSecurityRulesTcpOptionsSourcePortRange")]
        internal sealed class _Proxy : DeputyBase, oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesTcpOptionsSourcePortRange
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#max CoreSecurityList#max}.</summary>
            [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}")]
            public double Max
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#min CoreSecurityList#min}.</summary>
            [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}")]
            public double Min
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
