using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlStorageLensConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestination")]
    public class S3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestination : aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestination
    {
        private object _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3control_storage_lens_configuration#enabled S3ControlStorageLensConfiguration#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object Enabled
        {
            get => _enabled;
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
                _enabled = value;
            }
        }

        /// <summary>encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3control_storage_lens_configuration#encryption S3ControlStorageLensConfiguration#encryption}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryption\"}", isOptional: true)]
        public aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryption? Encryption
        {
            get;
            set;
        }
    }
}
