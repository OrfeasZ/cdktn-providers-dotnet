using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsAutoScalingConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyRulesMetricThreshold")]
    public class BdsAutoScalingConfigurationPolicyRulesMetricThreshold : oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyRulesMetricThreshold
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#duration_in_minutes BdsAutoScalingConfiguration#duration_in_minutes}.</summary>
        [JsiiProperty(name: "durationInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public double DurationInMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#operator BdsAutoScalingConfiguration#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        public string Operator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#value BdsAutoScalingConfiguration#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        public double Value
        {
            get;
            set;
        }
    }
}
