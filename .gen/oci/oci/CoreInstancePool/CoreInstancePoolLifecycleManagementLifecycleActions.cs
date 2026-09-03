using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiByValue(fqn: "oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActions")]
    public class CoreInstancePoolLifecycleManagementLifecycleActions : oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActions
    {
        /// <summary>pre_termination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_instance_pool#pre_termination CoreInstancePool#pre_termination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preTermination", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTermination\"}", isOptional: true)]
        public oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActionsPreTermination? PreTermination
        {
            get;
            set;
        }
    }
}
