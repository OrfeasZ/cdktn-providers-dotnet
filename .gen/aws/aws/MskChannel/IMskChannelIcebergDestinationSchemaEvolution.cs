using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskChannel
{
    [JsiiInterface(nativeType: typeof(IMskChannelIcebergDestinationSchemaEvolution), fullyQualifiedName: "aws.mskChannel.MskChannelIcebergDestinationSchemaEvolution")]
    public interface IMskChannelIcebergDestinationSchemaEvolution
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#enable_schema_evolution MskChannel#enable_schema_evolution}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enableSchemaEvolution", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableSchemaEvolution
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskChannelIcebergDestinationSchemaEvolution), fullyQualifiedName: "aws.mskChannel.MskChannelIcebergDestinationSchemaEvolution")]
        internal sealed class _Proxy : DeputyBase, aws.MskChannel.IMskChannelIcebergDestinationSchemaEvolution
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#enable_schema_evolution MskChannel#enable_schema_evolution}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enableSchemaEvolution", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableSchemaEvolution
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
