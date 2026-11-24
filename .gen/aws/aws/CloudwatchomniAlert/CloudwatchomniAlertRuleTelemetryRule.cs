using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAlert
{
    [JsiiByValue(fqn: "aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRule")]
    public class CloudwatchomniAlertRuleTelemetryRule : aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRule
    {
        private object? _condition;

        /// <summary>condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#condition CloudwatchomniAlert#condition}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleCondition" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "condition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Condition
        {
            get => _condition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _condition = value;
            }
        }

        private object? _evaluation;

        /// <summary>evaluation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#evaluation CloudwatchomniAlert#evaluation}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleEvaluation" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "evaluation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleEvaluation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Evaluation
        {
            get => _evaluation;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleEvaluation[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleEvaluation).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _evaluation = value;
            }
        }

        private object? _noData;

        /// <summary>no_data block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#no_data CloudwatchomniAlert#no_data}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleNoData" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "noData", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleNoData\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NoData
        {
            get => _noData;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleNoData[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleNoData).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _noData = value;
            }
        }

        private object? _query;

        /// <summary>query block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#query CloudwatchomniAlert#query}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleQuery" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "query", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleQuery\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Query
        {
            get => _query;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleQuery[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleQuery).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _query = value;
            }
        }
    }
}
