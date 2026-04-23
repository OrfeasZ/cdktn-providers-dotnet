using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlStorageLensConfiguration
{
    [JsiiClass(nativeType: typeof(aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportOutputReference), fullyQualifiedName: "aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putS3BucketDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportS3BucketDestination\"}}]")]
        public virtual void PutS3BucketDestination(aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportS3BucketDestination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportS3BucketDestination)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageLensTableDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestination\"}}]")]
        public virtual void PutStorageLensTableDestination(aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestination)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetS3BucketDestination")]
        public virtual void ResetS3BucketDestination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageLensTableDestination")]
        public virtual void ResetStorageLensTableDestination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "s3BucketDestination", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportS3BucketDestinationOutputReference\"}")]
        public virtual aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportS3BucketDestinationOutputReference S3BucketDestination
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportS3BucketDestinationOutputReference>()!;
        }

        [JsiiProperty(name: "storageLensTableDestination", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationOutputReference\"}")]
        public virtual aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationOutputReference StorageLensTableDestination
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3BucketDestinationInput", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportS3BucketDestination\"}", isOptional: true)]
        public virtual aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportS3BucketDestination? S3BucketDestinationInput
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportS3BucketDestination?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageLensTableDestinationInput", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestination\"}", isOptional: true)]
        public virtual aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestination? StorageLensTableDestinationInput
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestination?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExport\"}", isOptional: true)]
        public virtual aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExport? InternalValue
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExport?>();
            set => SetInstanceProperty(value);
        }
    }
}
