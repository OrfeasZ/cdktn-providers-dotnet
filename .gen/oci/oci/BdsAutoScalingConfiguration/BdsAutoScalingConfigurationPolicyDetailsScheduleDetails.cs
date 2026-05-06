using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsAutoScalingConfiguration
{
    [JsiiByValue(fqn: "oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScheduleDetails")]
    public class BdsAutoScalingConfigurationPolicyDetailsScheduleDetails : oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScheduleDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#schedule_type BdsAutoScalingConfiguration#schedule_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scheduleType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScheduleType
        {
            get;
            set;
        }

        private object? _timeAndHorizontalScalingConfig;

        /// <summary>time_and_horizontal_scaling_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#time_and_horizontal_scaling_config BdsAutoScalingConfiguration#time_and_horizontal_scaling_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeAndHorizontalScalingConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScheduleDetailsTimeAndHorizontalScalingConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TimeAndHorizontalScalingConfig
        {
            get => _timeAndHorizontalScalingConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScheduleDetailsTimeAndHorizontalScalingConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScheduleDetailsTimeAndHorizontalScalingConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _timeAndHorizontalScalingConfig = value;
            }
        }

        private object? _timeAndVerticalScalingConfig;

        /// <summary>time_and_vertical_scaling_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#time_and_vertical_scaling_config BdsAutoScalingConfiguration#time_and_vertical_scaling_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeAndVerticalScalingConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScheduleDetailsTimeAndVerticalScalingConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TimeAndVerticalScalingConfig
        {
            get => _timeAndVerticalScalingConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScheduleDetailsTimeAndVerticalScalingConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScheduleDetailsTimeAndVerticalScalingConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _timeAndVerticalScalingConfig = value;
            }
        }
    }
}
