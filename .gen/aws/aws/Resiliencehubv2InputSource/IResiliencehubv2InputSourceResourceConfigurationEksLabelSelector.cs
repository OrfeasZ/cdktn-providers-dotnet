using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resiliencehubv2InputSource
{
    [JsiiInterface(nativeType: typeof(IResiliencehubv2InputSourceResourceConfigurationEksLabelSelector), fullyQualifiedName: "aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationEksLabelSelector")]
    public interface IResiliencehubv2InputSourceResourceConfigurationEksLabelSelector
    {
        /// <summary>match_expressions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/resiliencehubv2_input_source#match_expressions Resiliencehubv2InputSource#match_expressions}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationEksLabelSelectorMatchExpressions" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "matchExpressions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationEksLabelSelectorMatchExpressions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MatchExpressions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/resiliencehubv2_input_source#match_labels Resiliencehubv2InputSource#match_labels}.</summary>
        [JsiiProperty(name: "matchLabels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? MatchLabels
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IResiliencehubv2InputSourceResourceConfigurationEksLabelSelector), fullyQualifiedName: "aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationEksLabelSelector")]
        internal sealed class _Proxy : DeputyBase, aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationEksLabelSelector
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>match_expressions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/resiliencehubv2_input_source#match_expressions Resiliencehubv2InputSource#match_expressions}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationEksLabelSelectorMatchExpressions" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchExpressions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationEksLabelSelectorMatchExpressions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MatchExpressions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/resiliencehubv2_input_source#match_labels Resiliencehubv2InputSource#match_labels}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "matchLabels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? MatchLabels
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
