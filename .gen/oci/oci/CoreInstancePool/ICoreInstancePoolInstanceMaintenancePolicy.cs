using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiInterface(nativeType: typeof(ICoreInstancePoolInstanceMaintenancePolicy), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolInstanceMaintenancePolicy")]
    public interface ICoreInstancePoolInstanceMaintenancePolicy
    {
        /// <summary>launch_before_terminating block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/core_instance_pool#launch_before_terminating CoreInstancePool#launch_before_terminating}
        /// </remarks>
        [JsiiProperty(name: "launchBeforeTerminating", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminating\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreInstancePool.ICoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminating? LaunchBeforeTerminating
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstancePoolInstanceMaintenancePolicy), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolInstanceMaintenancePolicy")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstancePool.ICoreInstancePoolInstanceMaintenancePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>launch_before_terminating block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/core_instance_pool#launch_before_terminating CoreInstancePool#launch_before_terminating}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "launchBeforeTerminating", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminating\"}", isOptional: true)]
            public oci.CoreInstancePool.ICoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminating? LaunchBeforeTerminating
            {
                get => GetInstanceProperty<oci.CoreInstancePool.ICoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminating?>();
            }
        }
    }
}
