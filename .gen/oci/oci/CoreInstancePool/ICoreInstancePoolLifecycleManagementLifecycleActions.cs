using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiInterface(nativeType: typeof(ICoreInstancePoolLifecycleManagementLifecycleActions), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActions")]
    public interface ICoreInstancePoolLifecycleManagementLifecycleActions
    {
        /// <summary>pre_termination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/core_instance_pool#pre_termination CoreInstancePool#pre_termination}
        /// </remarks>
        [JsiiProperty(name: "preTermination", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTermination\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActionsPreTermination? PreTermination
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstancePoolLifecycleManagementLifecycleActions), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActions")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>pre_termination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/core_instance_pool#pre_termination CoreInstancePool#pre_termination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preTermination", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTermination\"}", isOptional: true)]
            public oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActionsPreTermination? PreTermination
            {
                get => GetInstanceProperty<oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActionsPreTermination?>();
            }
        }
    }
}
