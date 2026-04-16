using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DmsEndpoint
{
    [JsiiByValue(fqn: "aws.dmsEndpoint.DmsEndpointMysqlSettings")]
    public class DmsEndpointMysqlSettings : aws.DmsEndpoint.IDmsEndpointMysqlSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dms_endpoint#after_connect_script DmsEndpoint#after_connect_script}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "afterConnectScript", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AfterConnectScript
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dms_endpoint#authentication_method DmsEndpoint#authentication_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthenticationMethod
        {
            get;
            set;
        }

        private object? _cleanSourceMetadataOnMismatch;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dms_endpoint#clean_source_metadata_on_mismatch DmsEndpoint#clean_source_metadata_on_mismatch}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cleanSourceMetadataOnMismatch", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? CleanSourceMetadataOnMismatch
        {
            get => _cleanSourceMetadataOnMismatch;
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
                _cleanSourceMetadataOnMismatch = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dms_endpoint#events_poll_interval DmsEndpoint#events_poll_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eventsPollInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? EventsPollInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dms_endpoint#execute_timeout DmsEndpoint#execute_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "executeTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExecuteTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dms_endpoint#max_file_size DmsEndpoint#max_file_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxFileSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxFileSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dms_endpoint#parallel_load_threads DmsEndpoint#parallel_load_threads}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parallelLoadThreads", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ParallelLoadThreads
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dms_endpoint#server_timezone DmsEndpoint#server_timezone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverTimezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServerTimezone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dms_endpoint#service_access_role_arn DmsEndpoint#service_access_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceAccessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceAccessRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dms_endpoint#target_db_type DmsEndpoint#target_db_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetDbType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetDbType
        {
            get;
            set;
        }
    }
}
