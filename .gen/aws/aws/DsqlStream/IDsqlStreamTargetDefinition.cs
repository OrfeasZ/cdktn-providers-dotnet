using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DsqlStream
{
    [JsiiInterface(nativeType: typeof(IDsqlStreamTargetDefinition), fullyQualifiedName: "aws.dsqlStream.DsqlStreamTargetDefinition")]
    public interface IDsqlStreamTargetDefinition
    {
        /// <summary>kinesis block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/dsql_stream#kinesis DsqlStream#kinesis}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DsqlStream.IDsqlStreamTargetDefinitionKinesis" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "kinesis", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dsqlStream.DsqlStreamTargetDefinitionKinesis\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Kinesis
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDsqlStreamTargetDefinition), fullyQualifiedName: "aws.dsqlStream.DsqlStreamTargetDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.DsqlStream.IDsqlStreamTargetDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>kinesis block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/dsql_stream#kinesis DsqlStream#kinesis}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DsqlStream.IDsqlStreamTargetDefinitionKinesis" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesis", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dsqlStream.DsqlStreamTargetDefinitionKinesis\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Kinesis
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
