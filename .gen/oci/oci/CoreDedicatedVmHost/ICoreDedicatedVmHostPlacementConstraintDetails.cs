using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDedicatedVmHost
{
    [JsiiInterface(nativeType: typeof(ICoreDedicatedVmHostPlacementConstraintDetails), fullyQualifiedName: "oci.coreDedicatedVmHost.CoreDedicatedVmHostPlacementConstraintDetails")]
    public interface ICoreDedicatedVmHostPlacementConstraintDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_dedicated_vm_host#type CoreDedicatedVmHost#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_dedicated_vm_host#compute_bare_metal_host_id CoreDedicatedVmHost#compute_bare_metal_host_id}.</summary>
        [JsiiProperty(name: "computeBareMetalHostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComputeBareMetalHostId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreDedicatedVmHostPlacementConstraintDetails), fullyQualifiedName: "oci.coreDedicatedVmHost.CoreDedicatedVmHostPlacementConstraintDetails")]
        internal sealed class _Proxy : DeputyBase, oci.CoreDedicatedVmHost.ICoreDedicatedVmHostPlacementConstraintDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_dedicated_vm_host#type CoreDedicatedVmHost#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_dedicated_vm_host#compute_bare_metal_host_id CoreDedicatedVmHost#compute_bare_metal_host_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computeBareMetalHostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputeBareMetalHostId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
