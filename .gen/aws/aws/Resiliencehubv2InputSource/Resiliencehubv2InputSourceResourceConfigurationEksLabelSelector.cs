using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resiliencehubv2InputSource
{
    [JsiiByValue(fqn: "aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationEksLabelSelector")]
    public class Resiliencehubv2InputSourceResourceConfigurationEksLabelSelector : aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationEksLabelSelector
    {
        private object? _matchExpressions;

        /// <summary>match_expressions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/resiliencehubv2_input_source#match_expressions Resiliencehubv2InputSource#match_expressions}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationEksLabelSelectorMatchExpressions" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "matchExpressions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationEksLabelSelectorMatchExpressions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MatchExpressions
        {
            get => _matchExpressions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationEksLabelSelectorMatchExpressions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationEksLabelSelectorMatchExpressions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _matchExpressions = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/resiliencehubv2_input_source#match_labels Resiliencehubv2InputSource#match_labels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "matchLabels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? MatchLabels
        {
            get;
            set;
        }
    }
}
