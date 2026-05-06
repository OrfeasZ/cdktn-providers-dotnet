using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AutoscalingAutoScalingConfiguration
{
    [JsiiByValue(fqn: "oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesCapacity")]
    public class AutoscalingAutoScalingConfigurationPoliciesCapacity : oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/autoscaling_auto_scaling_configuration#initial AutoscalingAutoScalingConfiguration#initial}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "initial", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Initial
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/autoscaling_auto_scaling_configuration#max AutoscalingAutoScalingConfiguration#max}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Max
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/autoscaling_auto_scaling_configuration#min AutoscalingAutoScalingConfiguration#min}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Min
        {
            get;
            set;
        }
    }
}
