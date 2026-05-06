using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    [JsiiInterface(nativeType: typeof(IWaasWaasPolicyOriginGroups), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyOriginGroups")]
    public interface IWaasWaasPolicyOriginGroups
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#label WaasWaasPolicy#label}.</summary>
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}")]
        string Label
        {
            get;
        }

        /// <summary>origin_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#origin_group WaasWaasPolicy#origin_group}
        /// </remarks>
        [JsiiProperty(name: "originGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyOriginGroupsOriginGroup\"},\"kind\":\"array\"}}]}}")]
        object OriginGroup
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWaasWaasPolicyOriginGroups), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyOriginGroups")]
        internal sealed class _Proxy : DeputyBase, oci.WaasWaasPolicy.IWaasWaasPolicyOriginGroups
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#label WaasWaasPolicy#label}.</summary>
            [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}")]
            public string Label
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>origin_group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#origin_group WaasWaasPolicy#origin_group}
            /// </remarks>
            [JsiiProperty(name: "originGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyOriginGroupsOriginGroup\"},\"kind\":\"array\"}}]}}")]
            public object OriginGroup
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
