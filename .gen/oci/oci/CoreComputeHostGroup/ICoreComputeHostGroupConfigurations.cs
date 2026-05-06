using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreComputeHostGroup
{
    [JsiiInterface(nativeType: typeof(ICoreComputeHostGroupConfigurations), fullyQualifiedName: "oci.coreComputeHostGroup.CoreComputeHostGroupConfigurations")]
    public interface ICoreComputeHostGroupConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_host_group#firmware_bundle_id CoreComputeHostGroup#firmware_bundle_id}.</summary>
        [JsiiProperty(name: "firmwareBundleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FirmwareBundleId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_host_group#recycle_level CoreComputeHostGroup#recycle_level}.</summary>
        [JsiiProperty(name: "recycleLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecycleLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_host_group#target CoreComputeHostGroup#target}.</summary>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Target
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreComputeHostGroupConfigurations), fullyQualifiedName: "oci.coreComputeHostGroup.CoreComputeHostGroupConfigurations")]
        internal sealed class _Proxy : DeputyBase, oci.CoreComputeHostGroup.ICoreComputeHostGroupConfigurations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_host_group#firmware_bundle_id CoreComputeHostGroup#firmware_bundle_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "firmwareBundleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FirmwareBundleId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_host_group#recycle_level CoreComputeHostGroup#recycle_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recycleLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecycleLevel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_compute_host_group#target CoreComputeHostGroup#target}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Target
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
