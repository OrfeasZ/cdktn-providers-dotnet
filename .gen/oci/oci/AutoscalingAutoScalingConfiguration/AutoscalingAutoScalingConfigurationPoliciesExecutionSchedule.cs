using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AutoscalingAutoScalingConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesExecutionSchedule")]
    public class AutoscalingAutoScalingConfigurationPoliciesExecutionSchedule : oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesExecutionSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/autoscaling_auto_scaling_configuration#expression AutoscalingAutoScalingConfiguration#expression}.</summary>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
        public string Expression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/autoscaling_auto_scaling_configuration#timezone AutoscalingAutoScalingConfiguration#timezone}.</summary>
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        public string Timezone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/autoscaling_auto_scaling_configuration#type AutoscalingAutoScalingConfiguration#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
