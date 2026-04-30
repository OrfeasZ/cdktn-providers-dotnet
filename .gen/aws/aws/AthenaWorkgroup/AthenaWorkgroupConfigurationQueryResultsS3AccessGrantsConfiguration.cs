using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AthenaWorkgroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.athenaWorkgroup.AthenaWorkgroupConfigurationQueryResultsS3AccessGrantsConfiguration")]
    public class AthenaWorkgroupConfigurationQueryResultsS3AccessGrantsConfiguration : aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationQueryResultsS3AccessGrantsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#authentication_type AthenaWorkgroup#authentication_type}.</summary>
        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
        public string AuthenticationType
        {
            get;
            set;
        }

        private object _enableS3AccessGrants;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#enable_s3_access_grants AthenaWorkgroup#enable_s3_access_grants}.</summary>
        [JsiiProperty(name: "enableS3AccessGrants", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object EnableS3AccessGrants
        {
            get => _enableS3AccessGrants;
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
                _enableS3AccessGrants = value;
            }
        }

        private object? _createUserLevelPrefix;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#create_user_level_prefix AthenaWorkgroup#create_user_level_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "createUserLevelPrefix", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? CreateUserLevelPrefix
        {
            get => _createUserLevelPrefix;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _createUserLevelPrefix = value;
            }
        }
    }
}
