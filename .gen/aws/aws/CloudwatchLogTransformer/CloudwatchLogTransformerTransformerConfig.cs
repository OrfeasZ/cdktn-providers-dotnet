using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchLogTransformer
{
    [JsiiByValue(fqn: "aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfig")]
    public class CloudwatchLogTransformerTransformerConfig : aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfig
    {
        private object? _addKeys;

        /// <summary>add_keys block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#add_keys CloudwatchLogTransformer#add_keys}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigAddKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AddKeys
        {
            get => _addKeys;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigAddKeys[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigAddKeys).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _addKeys = value;
            }
        }

        private object? _copyValue;

        /// <summary>copy_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#copy_value CloudwatchLogTransformer#copy_value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "copyValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigCopyValue\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CopyValue
        {
            get => _copyValue;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigCopyValue[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigCopyValue).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _copyValue = value;
            }
        }

        private object? _csv;

        /// <summary>csv block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#csv CloudwatchLogTransformer#csv}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "csv", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigCsv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Csv
        {
            get => _csv;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigCsv[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigCsv).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _csv = value;
            }
        }

        private object? _dateTimeConverter;

        /// <summary>date_time_converter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#date_time_converter CloudwatchLogTransformer#date_time_converter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dateTimeConverter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigDateTimeConverter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DateTimeConverter
        {
            get => _dateTimeConverter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigDateTimeConverter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigDateTimeConverter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dateTimeConverter = value;
            }
        }

        private object? _deleteKeys;

        /// <summary>delete_keys block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#delete_keys CloudwatchLogTransformer#delete_keys}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deleteKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigDeleteKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DeleteKeys
        {
            get => _deleteKeys;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigDeleteKeys[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigDeleteKeys).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _deleteKeys = value;
            }
        }

        private object? _grok;

        /// <summary>grok block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#grok CloudwatchLogTransformer#grok}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grok", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigGrok\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Grok
        {
            get => _grok;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigGrok[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigGrok).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _grok = value;
            }
        }

        private object? _listToMap;

        /// <summary>list_to_map block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#list_to_map CloudwatchLogTransformer#list_to_map}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "listToMap", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigListToMap\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ListToMap
        {
            get => _listToMap;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigListToMap[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigListToMap).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _listToMap = value;
            }
        }

        private object? _lowerCaseString;

        /// <summary>lower_case_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#lower_case_string CloudwatchLogTransformer#lower_case_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lowerCaseString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigLowerCaseString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LowerCaseString
        {
            get => _lowerCaseString;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigLowerCaseString[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigLowerCaseString).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lowerCaseString = value;
            }
        }

        private object? _moveKeys;

        /// <summary>move_keys block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#move_keys CloudwatchLogTransformer#move_keys}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "moveKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigMoveKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MoveKeys
        {
            get => _moveKeys;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigMoveKeys[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigMoveKeys).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _moveKeys = value;
            }
        }

        private object? _parseCloudfront;

        /// <summary>parse_cloudfront block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#parse_cloudfront CloudwatchLogTransformer#parse_cloudfront}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parseCloudfront", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParseCloudfront\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ParseCloudfront
        {
            get => _parseCloudfront;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigParseCloudfront[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigParseCloudfront).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _parseCloudfront = value;
            }
        }

        private object? _parseJson;

        /// <summary>parse_json block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#parse_json CloudwatchLogTransformer#parse_json}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parseJson", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParseJson\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ParseJson
        {
            get => _parseJson;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigParseJson[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigParseJson).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _parseJson = value;
            }
        }

        private object? _parseKeyValue;

        /// <summary>parse_key_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#parse_key_value CloudwatchLogTransformer#parse_key_value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parseKeyValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParseKeyValue\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ParseKeyValue
        {
            get => _parseKeyValue;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigParseKeyValue[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigParseKeyValue).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _parseKeyValue = value;
            }
        }

        private object? _parsePostgres;

        /// <summary>parse_postgres block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#parse_postgres CloudwatchLogTransformer#parse_postgres}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parsePostgres", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParsePostgres\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ParsePostgres
        {
            get => _parsePostgres;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigParsePostgres[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigParsePostgres).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _parsePostgres = value;
            }
        }

        private object? _parseRoute53;

        /// <summary>parse_route53 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#parse_route53 CloudwatchLogTransformer#parse_route53}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parseRoute53", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParseRoute53\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ParseRoute53
        {
            get => _parseRoute53;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigParseRoute53[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigParseRoute53).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _parseRoute53 = value;
            }
        }

        private object? _parseToOcsf;

        /// <summary>parse_to_ocsf block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#parse_to_ocsf CloudwatchLogTransformer#parse_to_ocsf}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parseToOcsf", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParseToOcsf\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ParseToOcsf
        {
            get => _parseToOcsf;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigParseToOcsf[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigParseToOcsf).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _parseToOcsf = value;
            }
        }

        private object? _parseVpc;

        /// <summary>parse_vpc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#parse_vpc CloudwatchLogTransformer#parse_vpc}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parseVpc", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParseVpc\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ParseVpc
        {
            get => _parseVpc;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigParseVpc[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigParseVpc).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _parseVpc = value;
            }
        }

        private object? _parseWaf;

        /// <summary>parse_waf block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#parse_waf CloudwatchLogTransformer#parse_waf}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parseWaf", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParseWaf\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ParseWaf
        {
            get => _parseWaf;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigParseWaf[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigParseWaf).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _parseWaf = value;
            }
        }

        private object? _renameKeys;

        /// <summary>rename_keys block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#rename_keys CloudwatchLogTransformer#rename_keys}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "renameKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigRenameKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RenameKeys
        {
            get => _renameKeys;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigRenameKeys[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigRenameKeys).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _renameKeys = value;
            }
        }

        private object? _splitString;

        /// <summary>split_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#split_string CloudwatchLogTransformer#split_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "splitString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigSplitString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SplitString
        {
            get => _splitString;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigSplitString[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigSplitString).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _splitString = value;
            }
        }

        private object? _substituteString;

        /// <summary>substitute_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#substitute_string CloudwatchLogTransformer#substitute_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "substituteString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigSubstituteString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SubstituteString
        {
            get => _substituteString;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigSubstituteString[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigSubstituteString).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _substituteString = value;
            }
        }

        private object? _trimString;

        /// <summary>trim_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#trim_string CloudwatchLogTransformer#trim_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trimString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigTrimString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TrimString
        {
            get => _trimString;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigTrimString[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigTrimString).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _trimString = value;
            }
        }

        private object? _typeConverter;

        /// <summary>type_converter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#type_converter CloudwatchLogTransformer#type_converter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "typeConverter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigTypeConverter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TypeConverter
        {
            get => _typeConverter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigTypeConverter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigTypeConverter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _typeConverter = value;
            }
        }

        private object? _upperCaseString;

        /// <summary>upper_case_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#upper_case_string CloudwatchLogTransformer#upper_case_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "upperCaseString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigUpperCaseString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UpperCaseString
        {
            get => _upperCaseString;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigUpperCaseString[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigUpperCaseString).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _upperCaseString = value;
            }
        }
    }
}
