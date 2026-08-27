using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiInterface(nativeType: typeof(ICoreInstancePoolLifecycleManagement), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolLifecycleManagement")]
    public interface ICoreInstancePoolLifecycleManagement
    {
        /// <summary>lifecycle_actions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/core_instance_pool#lifecycle_actions CoreInstancePool#lifecycle_actions}
        /// </remarks>
        [JsiiProperty(name: "lifecycleActions", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActions\"}")]
        oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActions LifecycleActions
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstancePoolLifecycleManagement), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolLifecycleManagement")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstancePool.ICoreInstancePoolLifecycleManagement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>lifecycle_actions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/core_instance_pool#lifecycle_actions CoreInstancePool#lifecycle_actions}
            /// </remarks>
            [JsiiProperty(name: "lifecycleActions", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActions\"}")]
            public oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActions LifecycleActions
            {
                get => GetInstanceProperty<oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActions>()!;
            }
        }
    }
}
