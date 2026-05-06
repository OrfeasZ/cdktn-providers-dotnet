using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreInstance.CoreInstancePreemptibleInstanceConfig")]
    public class CoreInstancePreemptibleInstanceConfig : oci.CoreInstance.ICoreInstancePreemptibleInstanceConfig
    {
        /// <summary>preemption_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#preemption_action CoreInstance#preemption_action}
        /// </remarks>
        [JsiiProperty(name: "preemptionAction", typeJson: "{\"fqn\":\"oci.coreInstance.CoreInstancePreemptibleInstanceConfigPreemptionAction\"}")]
        public oci.CoreInstance.ICoreInstancePreemptibleInstanceConfigPreemptionAction PreemptionAction
        {
            get;
            set;
        }
    }
}
