using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreComputeHostGroup
{
    [JsiiInterface(nativeType: typeof(ICoreComputeHostGroupConfigurationsQuickRecycleSettings), fullyQualifiedName: "oci.coreComputeHostGroup.CoreComputeHostGroupConfigurationsQuickRecycleSettings")]
    public interface ICoreComputeHostGroupConfigurationsQuickRecycleSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/core_compute_host_group#nvme_wipe CoreComputeHostGroup#nvme_wipe}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "nvmeWipe", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NvmeWipe
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreComputeHostGroupConfigurationsQuickRecycleSettings), fullyQualifiedName: "oci.coreComputeHostGroup.CoreComputeHostGroupConfigurationsQuickRecycleSettings")]
        internal sealed class _Proxy : DeputyBase, oci.CoreComputeHostGroup.ICoreComputeHostGroupConfigurationsQuickRecycleSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/core_compute_host_group#nvme_wipe CoreComputeHostGroup#nvme_wipe}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nvmeWipe", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? NvmeWipe
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
