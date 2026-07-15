using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppfabricIngestionDestination
{
    [JsiiInterface(nativeType: typeof(IAppfabricIngestionDestinationDestinationConfigurationAuditLogDestination), fullyQualifiedName: "aws.appfabricIngestionDestination.AppfabricIngestionDestinationDestinationConfigurationAuditLogDestination")]
    public interface IAppfabricIngestionDestinationDestinationConfigurationAuditLogDestination
    {
        /// <summary>firehose_stream block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/appfabric_ingestion_destination#firehose_stream AppfabricIngestionDestination#firehose_stream}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.AppfabricIngestionDestination.IAppfabricIngestionDestinationDestinationConfigurationAuditLogDestinationFirehoseStream" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "firehoseStream", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricIngestionDestination.AppfabricIngestionDestinationDestinationConfigurationAuditLogDestinationFirehoseStream\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FirehoseStream
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_bucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/appfabric_ingestion_destination#s3_bucket AppfabricIngestionDestination#s3_bucket}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.AppfabricIngestionDestination.IAppfabricIngestionDestinationDestinationConfigurationAuditLogDestinationS3Bucket" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "s3Bucket", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricIngestionDestination.AppfabricIngestionDestinationDestinationConfigurationAuditLogDestinationS3Bucket\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3Bucket
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppfabricIngestionDestinationDestinationConfigurationAuditLogDestination), fullyQualifiedName: "aws.appfabricIngestionDestination.AppfabricIngestionDestinationDestinationConfigurationAuditLogDestination")]
        internal sealed class _Proxy : DeputyBase, aws.AppfabricIngestionDestination.IAppfabricIngestionDestinationDestinationConfigurationAuditLogDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>firehose_stream block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/appfabric_ingestion_destination#firehose_stream AppfabricIngestionDestination#firehose_stream}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.AppfabricIngestionDestination.IAppfabricIngestionDestinationDestinationConfigurationAuditLogDestinationFirehoseStream" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "firehoseStream", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricIngestionDestination.AppfabricIngestionDestinationDestinationConfigurationAuditLogDestinationFirehoseStream\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FirehoseStream
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>s3_bucket block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/appfabric_ingestion_destination#s3_bucket AppfabricIngestionDestination#s3_bucket}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.AppfabricIngestionDestination.IAppfabricIngestionDestinationDestinationConfigurationAuditLogDestinationS3Bucket" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Bucket", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricIngestionDestination.AppfabricIngestionDestinationDestinationConfigurationAuditLogDestinationS3Bucket\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? S3Bucket
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
