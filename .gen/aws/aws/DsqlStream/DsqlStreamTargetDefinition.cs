using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DsqlStream
{
    [JsiiByValue(fqn: "aws.dsqlStream.DsqlStreamTargetDefinition")]
    public class DsqlStreamTargetDefinition : aws.DsqlStream.IDsqlStreamTargetDefinition
    {
        private object? _kinesis;

        /// <summary>kinesis block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/dsql_stream#kinesis DsqlStream#kinesis}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DsqlStream.IDsqlStreamTargetDefinitionKinesis" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kinesis", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dsqlStream.DsqlStreamTargetDefinitionKinesis\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Kinesis
        {
            get => _kinesis;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DsqlStream.IDsqlStreamTargetDefinitionKinesis[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DsqlStream.IDsqlStreamTargetDefinitionKinesis).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _kinesis = value;
            }
        }
    }
}
