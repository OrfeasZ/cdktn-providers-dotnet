using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resiliencehubv2InputSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationEks")]
    public class Resiliencehubv2InputSourceResourceConfigurationEks : aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationEks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/resiliencehubv2_input_source#cluster_arn Resiliencehubv2InputSource#cluster_arn}.</summary>
        [JsiiProperty(name: "clusterArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/resiliencehubv2_input_source#namespaces Resiliencehubv2InputSource#namespaces}.</summary>
        [JsiiProperty(name: "namespaces", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Namespaces
        {
            get;
            set;
        }

        private object? _labelSelector;

        /// <summary>label_selector block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/resiliencehubv2_input_source#label_selector Resiliencehubv2InputSource#label_selector}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationEksLabelSelector" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "labelSelector", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationEksLabelSelector\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LabelSelector
        {
            get => _labelSelector;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationEksLabelSelector[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationEksLabelSelector).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _labelSelector = value;
            }
        }
    }
}
