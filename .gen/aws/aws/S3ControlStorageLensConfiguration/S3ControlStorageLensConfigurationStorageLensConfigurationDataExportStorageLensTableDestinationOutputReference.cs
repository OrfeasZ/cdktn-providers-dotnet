using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlStorageLensConfiguration
{
    [JsiiClass(nativeType: typeof(aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationOutputReference), fullyQualifiedName: "aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected S3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryption\"}}]")]
        public virtual void PutEncryption(aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEncryption")]
        public virtual void ResetEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryptionOutputReference\"}")]
        public virtual aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryptionOutputReference Encryption
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryptionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionInput", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryption\"}", isOptional: true)]
        public virtual aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryption? EncryptionInput
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryption?>();
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Enabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestination\"}", isOptional: true)]
        public virtual aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestination? InternalValue
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestination?>();
            set => SetInstanceProperty(value);
        }
    }
}
