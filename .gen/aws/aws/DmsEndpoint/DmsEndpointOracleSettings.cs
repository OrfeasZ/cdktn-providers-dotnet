using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DmsEndpoint
{
    [JsiiByValue(fqn: "aws.dmsEndpoint.DmsEndpointOracleSettings")]
    public class DmsEndpointOracleSettings : aws.DmsEndpoint.IDmsEndpointOracleSettings
    {
        private object? _accessAlternateDirectly;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#access_alternate_directly DmsEndpoint#access_alternate_directly}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessAlternateDirectly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AccessAlternateDirectly
        {
            get => _accessAlternateDirectly;
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
                _accessAlternateDirectly = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#additional_archived_log_dest_id DmsEndpoint#additional_archived_log_dest_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "additionalArchivedLogDestId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AdditionalArchivedLogDestId
        {
            get;
            set;
        }

        private object? _addSupplementalLogging;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#add_supplemental_logging DmsEndpoint#add_supplemental_logging}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "addSupplementalLogging", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AddSupplementalLogging
        {
            get => _addSupplementalLogging;
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
                _addSupplementalLogging = value;
            }
        }

        private object? _allowSelectedNestedTables;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#allow_selected_nested_tables DmsEndpoint#allow_selected_nested_tables}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowSelectedNestedTables", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AllowSelectedNestedTables
        {
            get => _allowSelectedNestedTables;
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
                _allowSelectedNestedTables = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#archived_log_dest_id DmsEndpoint#archived_log_dest_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "archivedLogDestId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ArchivedLogDestId
        {
            get;
            set;
        }

        private object? _archivedLogsOnly;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#archived_logs_only DmsEndpoint#archived_logs_only}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "archivedLogsOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ArchivedLogsOnly
        {
            get => _archivedLogsOnly;
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
                _archivedLogsOnly = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#asm_password DmsEndpoint#asm_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "asmPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AsmPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#asm_server DmsEndpoint#asm_server}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "asmServer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AsmServer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#asm_user DmsEndpoint#asm_user}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "asmUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AsmUser
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#authentication_method DmsEndpoint#authentication_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthenticationMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#char_length_semantics DmsEndpoint#char_length_semantics}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "charLengthSemantics", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CharLengthSemantics
        {
            get;
            set;
        }

        private object? _convertTimestampWithZoneToUtc;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#convert_timestamp_with_zone_to_utc DmsEndpoint#convert_timestamp_with_zone_to_utc}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "convertTimestampWithZoneToUtc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ConvertTimestampWithZoneToUtc
        {
            get => _convertTimestampWithZoneToUtc;
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
                _convertTimestampWithZoneToUtc = value;
            }
        }

        private object? _directPathNoLog;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#direct_path_no_log DmsEndpoint#direct_path_no_log}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "directPathNoLog", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DirectPathNoLog
        {
            get => _directPathNoLog;
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
                _directPathNoLog = value;
            }
        }

        private object? _directPathParallelLoad;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#direct_path_parallel_load DmsEndpoint#direct_path_parallel_load}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "directPathParallelLoad", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DirectPathParallelLoad
        {
            get => _directPathParallelLoad;
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
                _directPathParallelLoad = value;
            }
        }

        private object? _enableHomogenousTablespace;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#enable_homogenous_tablespace DmsEndpoint#enable_homogenous_tablespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableHomogenousTablespace", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnableHomogenousTablespace
        {
            get => _enableHomogenousTablespace;
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
                _enableHomogenousTablespace = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#extra_archived_log_dest_ids DmsEndpoint#extra_archived_log_dest_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "extraArchivedLogDestIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public double[]? ExtraArchivedLogDestIds
        {
            get;
            set;
        }

        private object? _failTaskOnLobTruncation;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#fail_task_on_lob_truncation DmsEndpoint#fail_task_on_lob_truncation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failTaskOnLobTruncation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? FailTaskOnLobTruncation
        {
            get => _failTaskOnLobTruncation;
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
                _failTaskOnLobTruncation = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#number_datatype_scale DmsEndpoint#number_datatype_scale}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numberDatatypeScale", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NumberDatatypeScale
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#open_transaction_window DmsEndpoint#open_transaction_window}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "openTransactionWindow", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? OpenTransactionWindow
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#oracle_path_prefix DmsEndpoint#oracle_path_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "oraclePathPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OraclePathPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#parallel_asm_read_threads DmsEndpoint#parallel_asm_read_threads}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parallelAsmReadThreads", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ParallelAsmReadThreads
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#read_ahead_blocks DmsEndpoint#read_ahead_blocks}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readAheadBlocks", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReadAheadBlocks
        {
            get;
            set;
        }

        private object? _readTableSpaceName;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#read_table_space_name DmsEndpoint#read_table_space_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readTableSpaceName", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ReadTableSpaceName
        {
            get => _readTableSpaceName;
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
                _readTableSpaceName = value;
            }
        }

        private object? _replacePathPrefix;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#replace_path_prefix DmsEndpoint#replace_path_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replacePathPrefix", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ReplacePathPrefix
        {
            get => _replacePathPrefix;
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
                _replacePathPrefix = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#retry_interval DmsEndpoint#retry_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retryInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetryInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#secrets_manager_oracle_asm_access_role_arn DmsEndpoint#secrets_manager_oracle_asm_access_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretsManagerOracleAsmAccessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretsManagerOracleAsmAccessRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#secrets_manager_oracle_asm_secret_id DmsEndpoint#secrets_manager_oracle_asm_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretsManagerOracleAsmSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretsManagerOracleAsmSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#security_db_encryption DmsEndpoint#security_db_encryption}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityDbEncryption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecurityDbEncryption
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#security_db_encryption_name DmsEndpoint#security_db_encryption_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityDbEncryptionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecurityDbEncryptionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#spatial_data_option_to_geo_json_function_name DmsEndpoint#spatial_data_option_to_geo_json_function_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "spatialDataOptionToGeoJsonFunctionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SpatialDataOptionToGeoJsonFunctionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#standby_delay_time DmsEndpoint#standby_delay_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "standbyDelayTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StandbyDelayTime
        {
            get;
            set;
        }

        private object? _trimSpaceInChar;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#trim_space_in_char DmsEndpoint#trim_space_in_char}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trimSpaceInChar", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? TrimSpaceInChar
        {
            get => _trimSpaceInChar;
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
                _trimSpaceInChar = value;
            }
        }

        private object? _useAlternateFolderForOnline;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#use_alternate_folder_for_online DmsEndpoint#use_alternate_folder_for_online}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useAlternateFolderForOnline", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? UseAlternateFolderForOnline
        {
            get => _useAlternateFolderForOnline;
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
                _useAlternateFolderForOnline = value;
            }
        }

        private object? _useBfile;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#use_bfile DmsEndpoint#use_bfile}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useBfile", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? UseBfile
        {
            get => _useBfile;
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
                _useBfile = value;
            }
        }

        private object? _useDirectPathFullLoad;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#use_direct_path_full_load DmsEndpoint#use_direct_path_full_load}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useDirectPathFullLoad", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? UseDirectPathFullLoad
        {
            get => _useDirectPathFullLoad;
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
                _useDirectPathFullLoad = value;
            }
        }

        private object? _useLogminerReader;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#use_logminer_reader DmsEndpoint#use_logminer_reader}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useLogminerReader", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? UseLogminerReader
        {
            get => _useLogminerReader;
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
                _useLogminerReader = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_endpoint#use_path_prefix DmsEndpoint#use_path_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "usePathPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UsePathPrefix
        {
            get;
            set;
        }
    }
}
