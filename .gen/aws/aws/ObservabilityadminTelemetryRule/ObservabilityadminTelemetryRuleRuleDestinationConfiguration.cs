using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminTelemetryRule
{
    [JsiiByValue(fqn: "aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfiguration")]
    public class ObservabilityadminTelemetryRuleRuleDestinationConfiguration : aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfiguration
    {
        private object? _cloudtrailParameters;

        /// <summary>cloudtrail_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/observabilityadmin_telemetry_rule#cloudtrail_parameters ObservabilityadminTelemetryRule#cloudtrail_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudtrailParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationCloudtrailParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CloudtrailParameters
        {
            get => _cloudtrailParameters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationCloudtrailParameters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationCloudtrailParameters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cloudtrailParameters = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/observabilityadmin_telemetry_rule#destination_pattern ObservabilityadminTelemetryRule#destination_pattern}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationPattern
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/observabilityadmin_telemetry_rule#destination_type ObservabilityadminTelemetryRule#destination_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationType
        {
            get;
            set;
        }

        private object? _elbLoadBalancerLoggingParameters;

        /// <summary>elb_load_balancer_logging_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/observabilityadmin_telemetry_rule#elb_load_balancer_logging_parameters ObservabilityadminTelemetryRule#elb_load_balancer_logging_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "elbLoadBalancerLoggingParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationElbLoadBalancerLoggingParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ElbLoadBalancerLoggingParameters
        {
            get => _elbLoadBalancerLoggingParameters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationElbLoadBalancerLoggingParameters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationElbLoadBalancerLoggingParameters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _elbLoadBalancerLoggingParameters = value;
            }
        }

        private object? _logDeliveryParameters;

        /// <summary>log_delivery_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/observabilityadmin_telemetry_rule#log_delivery_parameters ObservabilityadminTelemetryRule#log_delivery_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logDeliveryParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationLogDeliveryParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LogDeliveryParameters
        {
            get => _logDeliveryParameters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationLogDeliveryParameters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationLogDeliveryParameters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _logDeliveryParameters = value;
            }
        }

        private object? _mskMonitoringParameters;

        /// <summary>msk_monitoring_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/observabilityadmin_telemetry_rule#msk_monitoring_parameters ObservabilityadminTelemetryRule#msk_monitoring_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mskMonitoringParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationMskMonitoringParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MskMonitoringParameters
        {
            get => _mskMonitoringParameters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationMskMonitoringParameters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationMskMonitoringParameters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _mskMonitoringParameters = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/observabilityadmin_telemetry_rule#retention_in_days ObservabilityadminTelemetryRule#retention_in_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetentionInDays
        {
            get;
            set;
        }

        private object? _vpcFlowLogParameters;

        /// <summary>vpc_flow_log_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/observabilityadmin_telemetry_rule#vpc_flow_log_parameters ObservabilityadminTelemetryRule#vpc_flow_log_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpcFlowLogParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationVpcFlowLogParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VpcFlowLogParameters
        {
            get => _vpcFlowLogParameters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationVpcFlowLogParameters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationVpcFlowLogParameters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vpcFlowLogParameters = value;
            }
        }

        private object? _wafLoggingParameters;

        /// <summary>waf_logging_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/observabilityadmin_telemetry_rule#waf_logging_parameters ObservabilityadminTelemetryRule#waf_logging_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "wafLoggingParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.observabilityadminTelemetryRule.ObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? WafLoggingParameters
        {
            get => _wafLoggingParameters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParameters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ObservabilityadminTelemetryRule.IObservabilityadminTelemetryRuleRuleDestinationConfigurationWafLoggingParameters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _wafLoggingParameters = value;
            }
        }
    }
}
