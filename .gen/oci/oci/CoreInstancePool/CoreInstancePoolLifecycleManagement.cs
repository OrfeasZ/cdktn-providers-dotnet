using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreInstancePool.CoreInstancePoolLifecycleManagement")]
    public class CoreInstancePoolLifecycleManagement : oci.CoreInstancePool.ICoreInstancePoolLifecycleManagement
    {
        /// <summary>lifecycle_actions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/core_instance_pool#lifecycle_actions CoreInstancePool#lifecycle_actions}
        /// </remarks>
        [JsiiProperty(name: "lifecycleActions", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActions\"}")]
        public oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActions LifecycleActions
        {
            get;
            set;
        }
    }
}
