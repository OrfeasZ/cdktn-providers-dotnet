using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstanceConfiguration
{
    [JsiiByValue(fqn: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsPreemptibleInstanceConfig")]
    public class CoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsPreemptibleInstanceConfig : oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsPreemptibleInstanceConfig
    {
        /// <summary>preemption_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#preemption_action CoreInstanceConfiguration#preemption_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preemptionAction", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsPreemptibleInstanceConfigPreemptionAction\"}", isOptional: true)]
        public oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsPreemptibleInstanceConfigPreemptionAction? PreemptionAction
        {
            get;
            set;
        }
    }
}
