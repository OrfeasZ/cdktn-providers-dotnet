using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlStorageLensConfiguration
{
    [JsiiClass(nativeType: typeof(aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryptionOutputReference), fullyQualifiedName: "aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryptionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryptionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryptionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryptionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryptionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSseKms", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryptionSseKms\"}}]")]
        public virtual void PutSseKms(aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryptionSseKms @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryptionSseKms)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSseS3", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryptionSseS3\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSseS3(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryptionSseS3[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryptionSseS3).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryptionSseS3).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSseKms")]
        public virtual void ResetSseKms()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSseS3")]
        public virtual void ResetSseS3()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "sseKms", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryptionSseKmsOutputReference\"}")]
        public virtual aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryptionSseKmsOutputReference SseKms
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryptionSseKmsOutputReference>()!;
        }

        [JsiiProperty(name: "sseS3", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryptionSseS3List\"}")]
        public virtual aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryptionSseS3List SseS3
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryptionSseS3List>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sseKmsInput", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryptionSseKms\"}", isOptional: true)]
        public virtual aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryptionSseKms? SseKmsInput
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryptionSseKms?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sseS3Input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryptionSseS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SseS3Input
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryption\"}", isOptional: true)]
        public virtual aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryption? InternalValue
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestinationEncryption?>();
            set => SetInstanceProperty(value);
        }
    }
}
