using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstance
{
    [JsiiInterface(nativeType: typeof(ICoreInstancePlacementConstraintDetails), fullyQualifiedName: "oci.coreInstance.CoreInstancePlacementConstraintDetails")]
    public interface ICoreInstancePlacementConstraintDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#type CoreInstance#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#compute_bare_metal_host_id CoreInstance#compute_bare_metal_host_id}.</summary>
        [JsiiProperty(name: "computeBareMetalHostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComputeBareMetalHostId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#compute_host_group_id CoreInstance#compute_host_group_id}.</summary>
        [JsiiProperty(name: "computeHostGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComputeHostGroupId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstancePlacementConstraintDetails), fullyQualifiedName: "oci.coreInstance.CoreInstancePlacementConstraintDetails")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstance.ICoreInstancePlacementConstraintDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#type CoreInstance#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#compute_bare_metal_host_id CoreInstance#compute_bare_metal_host_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computeBareMetalHostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputeBareMetalHostId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#compute_host_group_id CoreInstance#compute_host_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computeHostGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputeHostGroupId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
