using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    [JsiiInterface(nativeType: typeof(IWaasWaasPolicyOriginGroupsOriginGroup), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyOriginGroupsOriginGroup")]
    public interface IWaasWaasPolicyOriginGroupsOriginGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#origin WaasWaasPolicy#origin}.</summary>
        [JsiiProperty(name: "origin", typeJson: "{\"primitive\":\"string\"}")]
        string Origin
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#weight WaasWaasPolicy#weight}.</summary>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Weight
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWaasWaasPolicyOriginGroupsOriginGroup), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyOriginGroupsOriginGroup")]
        internal sealed class _Proxy : DeputyBase, oci.WaasWaasPolicy.IWaasWaasPolicyOriginGroupsOriginGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#origin WaasWaasPolicy#origin}.</summary>
            [JsiiProperty(name: "origin", typeJson: "{\"primitive\":\"string\"}")]
            public string Origin
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#weight WaasWaasPolicy#weight}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Weight
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
