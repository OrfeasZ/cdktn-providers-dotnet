using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace tailscale.LogstreamConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "tailscale.logstreamConfiguration.LogstreamConfigurationConfig")]
    public class LogstreamConfigurationConfig : tailscale.LogstreamConfiguration.ILogstreamConfigurationConfig
    {
        /// <summary>The type of SIEM platform to stream to.</summary>
        /// <remarks>
        /// Valid values are <c>axiom</c>, <c>cribl</c>, <c>datadog</c>, <c>elastic</c>, <c>gcs</c>, <c>panther</c>, <c>splunk</c>, and <c>s3</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/logstream_configuration#destination_type LogstreamConfiguration#destination_type}
        /// </remarks>
        [JsiiProperty(name: "destinationType", typeJson: "{\"primitive\":\"string\"}")]
        public string DestinationType
        {
            get;
            set;
        }

        /// <summary>The type of logs to stream. Valid values are `configuration` (configuration audit logs) and `network` (network flow logs).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/logstream_configuration#log_type LogstreamConfiguration#log_type}
        /// </remarks>
        [JsiiProperty(name: "logType", typeJson: "{\"primitive\":\"string\"}")]
        public string LogType
        {
            get;
            set;
        }

        /// <summary>The compression algorithm used for logs. Valid values are `none`, `zstd` or `gzip`. Defaults to `none`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/logstream_configuration#compression_format LogstreamConfiguration#compression_format}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "compressionFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompressionFormat
        {
            get;
            set;
        }

        /// <summary>The name of the GCS bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/logstream_configuration#gcs_bucket LogstreamConfiguration#gcs_bucket}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gcsBucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GcsBucket
        {
            get;
            set;
        }

        /// <summary>The encoded string of JSON that is used to authenticate for workload identity in GCS.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/logstream_configuration#gcs_credentials LogstreamConfiguration#gcs_credentials}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gcsCredentials", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GcsCredentials
        {
            get;
            set;
        }

        /// <summary>The GCS key prefix for the bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/logstream_configuration#gcs_key_prefix LogstreamConfiguration#gcs_key_prefix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gcsKeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GcsKeyPrefix
        {
            get;
            set;
        }

        /// <summary>The GCS scopes needed to be able to write in the bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/logstream_configuration#gcs_scopes LogstreamConfiguration#gcs_scopes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gcsScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? GcsScopes
        {
            get;
            set;
        }

        /// <summary>The S3 access key ID. Required if destination_type is s3 and s3_authentication_type is 'accesskey'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/logstream_configuration#s3_access_key_id LogstreamConfiguration#s3_access_key_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3AccessKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3AccessKeyId
        {
            get;
            set;
        }

        /// <summary>The type of authentication to use for S3.</summary>
        /// <remarks>
        /// Required if destination_type is <c>s3</c>. Valid values are <c>accesskey</c> and <c>rolearn</c>. Tailscale recommends using <c>rolearn</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/logstream_configuration#s3_authentication_type LogstreamConfiguration#s3_authentication_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3AuthenticationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3AuthenticationType
        {
            get;
            set;
        }

        /// <summary>The S3 bucket name. Required if destination_type is 's3'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/logstream_configuration#s3_bucket LogstreamConfiguration#s3_bucket}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3Bucket
        {
            get;
            set;
        }

        /// <summary>The AWS External ID that Tailscale supplies when authenticating using role-based authentication.</summary>
        /// <remarks>
        /// Required if destination_type is 's3' and s3_authentication_type is 'rolearn'. This can be obtained via the tailscale_aws_external_id resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/logstream_configuration#s3_external_id LogstreamConfiguration#s3_external_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3ExternalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3ExternalId
        {
            get;
            set;
        }

        /// <summary>An optional S3 key prefix to prepend to the auto-generated S3 key name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/logstream_configuration#s3_key_prefix LogstreamConfiguration#s3_key_prefix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3KeyPrefix
        {
            get;
            set;
        }

        /// <summary>The region in which the S3 bucket is located. Required if destination_type is 's3'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/logstream_configuration#s3_region LogstreamConfiguration#s3_region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3Region
        {
            get;
            set;
        }

        /// <summary>ARN of the AWS IAM role that Tailscale should assume when using role-based authentication.</summary>
        /// <remarks>
        /// Required if destination_type is 's3' and s3_authentication_type is 'rolearn'.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/logstream_configuration#s3_role_arn LogstreamConfiguration#s3_role_arn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3RoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3RoleArn
        {
            get;
            set;
        }

        /// <summary>The S3 secret access key. Required if destination_type is 's3' and s3_authentication_type is 'accesskey'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/logstream_configuration#s3_secret_access_key LogstreamConfiguration#s3_secret_access_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3SecretAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3SecretAccessKey
        {
            get;
            set;
        }

        /// <summary>The token/password with which log streams to this endpoint should be authenticated, required unless destination_type is 's3'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/logstream_configuration#token LogstreamConfiguration#token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Token
        {
            get;
            set;
        }

        /// <summary>An optional number of minutes to wait in between uploading new logs.</summary>
        /// <remarks>
        /// If the quantity of logs does not fit within a single upload, multiple uploads will be made.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/logstream_configuration#upload_period_minutes LogstreamConfiguration#upload_period_minutes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uploadPeriodMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UploadPeriodMinutes
        {
            get;
            set;
        }

        /// <summary>The URL to which log streams are being posted.</summary>
        /// <remarks>
        /// If destination_type is 's3' and you want to use the official Amazon S3 endpoint, leave this empty.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/logstream_configuration#url LogstreamConfiguration#url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Url
        {
            get;
            set;
        }

        /// <summary>The username with which log streams to this endpoint are authenticated.</summary>
        /// <remarks>
        /// Only required if destination_type is 'elastic', defaults to 'user' if not set.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/logstream_configuration#user LogstreamConfiguration#user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? User
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
