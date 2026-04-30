using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DmsEndpoint
{
    [JsiiInterface(nativeType: typeof(IDmsEndpointMysqlSettings), fullyQualifiedName: "aws.dmsEndpoint.DmsEndpointMysqlSettings")]
    public interface IDmsEndpointMysqlSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#after_connect_script DmsEndpoint#after_connect_script}.</summary>
        [JsiiProperty(name: "afterConnectScript", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AfterConnectScript
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#authentication_method DmsEndpoint#authentication_method}.</summary>
        [JsiiProperty(name: "authenticationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthenticationMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#clean_source_metadata_on_mismatch DmsEndpoint#clean_source_metadata_on_mismatch}.</summary>
        [JsiiProperty(name: "cleanSourceMetadataOnMismatch", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CleanSourceMetadataOnMismatch
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#events_poll_interval DmsEndpoint#events_poll_interval}.</summary>
        [JsiiProperty(name: "eventsPollInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? EventsPollInterval
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#execute_timeout DmsEndpoint#execute_timeout}.</summary>
        [JsiiProperty(name: "executeTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExecuteTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#max_file_size DmsEndpoint#max_file_size}.</summary>
        [JsiiProperty(name: "maxFileSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxFileSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#parallel_load_threads DmsEndpoint#parallel_load_threads}.</summary>
        [JsiiProperty(name: "parallelLoadThreads", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ParallelLoadThreads
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#server_timezone DmsEndpoint#server_timezone}.</summary>
        [JsiiProperty(name: "serverTimezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServerTimezone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#service_access_role_arn DmsEndpoint#service_access_role_arn}.</summary>
        [JsiiProperty(name: "serviceAccessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceAccessRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#target_db_type DmsEndpoint#target_db_type}.</summary>
        [JsiiProperty(name: "targetDbType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetDbType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDmsEndpointMysqlSettings), fullyQualifiedName: "aws.dmsEndpoint.DmsEndpointMysqlSettings")]
        internal sealed class _Proxy : DeputyBase, aws.DmsEndpoint.IDmsEndpointMysqlSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#after_connect_script DmsEndpoint#after_connect_script}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "afterConnectScript", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AfterConnectScript
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#authentication_method DmsEndpoint#authentication_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authenticationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthenticationMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#clean_source_metadata_on_mismatch DmsEndpoint#clean_source_metadata_on_mismatch}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cleanSourceMetadataOnMismatch", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CleanSourceMetadataOnMismatch
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#events_poll_interval DmsEndpoint#events_poll_interval}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eventsPollInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? EventsPollInterval
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#execute_timeout DmsEndpoint#execute_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "executeTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExecuteTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#max_file_size DmsEndpoint#max_file_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxFileSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxFileSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#parallel_load_threads DmsEndpoint#parallel_load_threads}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parallelLoadThreads", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ParallelLoadThreads
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#server_timezone DmsEndpoint#server_timezone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serverTimezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServerTimezone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#service_access_role_arn DmsEndpoint#service_access_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceAccessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceAccessRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#target_db_type DmsEndpoint#target_db_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetDbType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetDbType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
