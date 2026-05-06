using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDefaultSecurityList
{
    [JsiiInterface(nativeType: typeof(ICoreDefaultSecurityListIngressSecurityRulesIcmpOptions), fullyQualifiedName: "oci.coreDefaultSecurityList.CoreDefaultSecurityListIngressSecurityRulesIcmpOptions")]
    public interface ICoreDefaultSecurityListIngressSecurityRulesIcmpOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#type CoreDefaultSecurityList#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"number\"}")]
        double Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#code CoreDefaultSecurityList#code}.</summary>
        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Code
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreDefaultSecurityListIngressSecurityRulesIcmpOptions), fullyQualifiedName: "oci.coreDefaultSecurityList.CoreDefaultSecurityListIngressSecurityRulesIcmpOptions")]
        internal sealed class _Proxy : DeputyBase, oci.CoreDefaultSecurityList.ICoreDefaultSecurityListIngressSecurityRulesIcmpOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#type CoreDefaultSecurityList#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"number\"}")]
            public double Type
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#code CoreDefaultSecurityList#code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Code
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
