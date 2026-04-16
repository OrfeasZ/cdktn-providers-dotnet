using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchLogTransformer
{
    [JsiiInterface(nativeType: typeof(ICloudwatchLogTransformerTransformerConfig), fullyQualifiedName: "aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfig")]
    public interface ICloudwatchLogTransformerTransformerConfig
    {
        /// <summary>add_keys block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#add_keys CloudwatchLogTransformer#add_keys}
        /// </remarks>
        [JsiiProperty(name: "addKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigAddKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AddKeys
        {
            get
            {
                return null;
            }
        }

        /// <summary>copy_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#copy_value CloudwatchLogTransformer#copy_value}
        /// </remarks>
        [JsiiProperty(name: "copyValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigCopyValue\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CopyValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>csv block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#csv CloudwatchLogTransformer#csv}
        /// </remarks>
        [JsiiProperty(name: "csv", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigCsv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Csv
        {
            get
            {
                return null;
            }
        }

        /// <summary>date_time_converter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#date_time_converter CloudwatchLogTransformer#date_time_converter}
        /// </remarks>
        [JsiiProperty(name: "dateTimeConverter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigDateTimeConverter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DateTimeConverter
        {
            get
            {
                return null;
            }
        }

        /// <summary>delete_keys block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#delete_keys CloudwatchLogTransformer#delete_keys}
        /// </remarks>
        [JsiiProperty(name: "deleteKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigDeleteKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeleteKeys
        {
            get
            {
                return null;
            }
        }

        /// <summary>grok block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#grok CloudwatchLogTransformer#grok}
        /// </remarks>
        [JsiiProperty(name: "grok", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigGrok\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Grok
        {
            get
            {
                return null;
            }
        }

        /// <summary>list_to_map block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#list_to_map CloudwatchLogTransformer#list_to_map}
        /// </remarks>
        [JsiiProperty(name: "listToMap", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigListToMap\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ListToMap
        {
            get
            {
                return null;
            }
        }

        /// <summary>lower_case_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#lower_case_string CloudwatchLogTransformer#lower_case_string}
        /// </remarks>
        [JsiiProperty(name: "lowerCaseString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigLowerCaseString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LowerCaseString
        {
            get
            {
                return null;
            }
        }

        /// <summary>move_keys block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#move_keys CloudwatchLogTransformer#move_keys}
        /// </remarks>
        [JsiiProperty(name: "moveKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigMoveKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MoveKeys
        {
            get
            {
                return null;
            }
        }

        /// <summary>parse_cloudfront block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#parse_cloudfront CloudwatchLogTransformer#parse_cloudfront}
        /// </remarks>
        [JsiiProperty(name: "parseCloudfront", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParseCloudfront\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ParseCloudfront
        {
            get
            {
                return null;
            }
        }

        /// <summary>parse_json block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#parse_json CloudwatchLogTransformer#parse_json}
        /// </remarks>
        [JsiiProperty(name: "parseJson", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParseJson\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ParseJson
        {
            get
            {
                return null;
            }
        }

        /// <summary>parse_key_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#parse_key_value CloudwatchLogTransformer#parse_key_value}
        /// </remarks>
        [JsiiProperty(name: "parseKeyValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParseKeyValue\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ParseKeyValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>parse_postgres block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#parse_postgres CloudwatchLogTransformer#parse_postgres}
        /// </remarks>
        [JsiiProperty(name: "parsePostgres", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParsePostgres\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ParsePostgres
        {
            get
            {
                return null;
            }
        }

        /// <summary>parse_route53 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#parse_route53 CloudwatchLogTransformer#parse_route53}
        /// </remarks>
        [JsiiProperty(name: "parseRoute53", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParseRoute53\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ParseRoute53
        {
            get
            {
                return null;
            }
        }

        /// <summary>parse_to_ocsf block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#parse_to_ocsf CloudwatchLogTransformer#parse_to_ocsf}
        /// </remarks>
        [JsiiProperty(name: "parseToOcsf", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParseToOcsf\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ParseToOcsf
        {
            get
            {
                return null;
            }
        }

        /// <summary>parse_vpc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#parse_vpc CloudwatchLogTransformer#parse_vpc}
        /// </remarks>
        [JsiiProperty(name: "parseVpc", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParseVpc\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ParseVpc
        {
            get
            {
                return null;
            }
        }

        /// <summary>parse_waf block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#parse_waf CloudwatchLogTransformer#parse_waf}
        /// </remarks>
        [JsiiProperty(name: "parseWaf", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParseWaf\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ParseWaf
        {
            get
            {
                return null;
            }
        }

        /// <summary>rename_keys block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#rename_keys CloudwatchLogTransformer#rename_keys}
        /// </remarks>
        [JsiiProperty(name: "renameKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigRenameKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RenameKeys
        {
            get
            {
                return null;
            }
        }

        /// <summary>split_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#split_string CloudwatchLogTransformer#split_string}
        /// </remarks>
        [JsiiProperty(name: "splitString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigSplitString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SplitString
        {
            get
            {
                return null;
            }
        }

        /// <summary>substitute_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#substitute_string CloudwatchLogTransformer#substitute_string}
        /// </remarks>
        [JsiiProperty(name: "substituteString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigSubstituteString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SubstituteString
        {
            get
            {
                return null;
            }
        }

        /// <summary>trim_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#trim_string CloudwatchLogTransformer#trim_string}
        /// </remarks>
        [JsiiProperty(name: "trimString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigTrimString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TrimString
        {
            get
            {
                return null;
            }
        }

        /// <summary>type_converter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#type_converter CloudwatchLogTransformer#type_converter}
        /// </remarks>
        [JsiiProperty(name: "typeConverter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigTypeConverter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TypeConverter
        {
            get
            {
                return null;
            }
        }

        /// <summary>upper_case_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#upper_case_string CloudwatchLogTransformer#upper_case_string}
        /// </remarks>
        [JsiiProperty(name: "upperCaseString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigUpperCaseString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UpperCaseString
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchLogTransformerTransformerConfig), fullyQualifiedName: "aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>add_keys block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#add_keys CloudwatchLogTransformer#add_keys}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "addKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigAddKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AddKeys
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>copy_value block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#copy_value CloudwatchLogTransformer#copy_value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "copyValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigCopyValue\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CopyValue
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>csv block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#csv CloudwatchLogTransformer#csv}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "csv", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigCsv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Csv
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>date_time_converter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#date_time_converter CloudwatchLogTransformer#date_time_converter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dateTimeConverter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigDateTimeConverter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DateTimeConverter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>delete_keys block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#delete_keys CloudwatchLogTransformer#delete_keys}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deleteKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigDeleteKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DeleteKeys
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>grok block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#grok CloudwatchLogTransformer#grok}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grok", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigGrok\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Grok
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>list_to_map block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#list_to_map CloudwatchLogTransformer#list_to_map}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "listToMap", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigListToMap\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ListToMap
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>lower_case_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#lower_case_string CloudwatchLogTransformer#lower_case_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lowerCaseString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigLowerCaseString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LowerCaseString
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>move_keys block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#move_keys CloudwatchLogTransformer#move_keys}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "moveKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigMoveKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MoveKeys
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>parse_cloudfront block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#parse_cloudfront CloudwatchLogTransformer#parse_cloudfront}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parseCloudfront", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParseCloudfront\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ParseCloudfront
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>parse_json block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#parse_json CloudwatchLogTransformer#parse_json}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parseJson", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParseJson\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ParseJson
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>parse_key_value block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#parse_key_value CloudwatchLogTransformer#parse_key_value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parseKeyValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParseKeyValue\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ParseKeyValue
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>parse_postgres block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#parse_postgres CloudwatchLogTransformer#parse_postgres}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parsePostgres", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParsePostgres\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ParsePostgres
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>parse_route53 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#parse_route53 CloudwatchLogTransformer#parse_route53}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parseRoute53", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParseRoute53\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ParseRoute53
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>parse_to_ocsf block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#parse_to_ocsf CloudwatchLogTransformer#parse_to_ocsf}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parseToOcsf", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParseToOcsf\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ParseToOcsf
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>parse_vpc block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#parse_vpc CloudwatchLogTransformer#parse_vpc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parseVpc", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParseVpc\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ParseVpc
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>parse_waf block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#parse_waf CloudwatchLogTransformer#parse_waf}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parseWaf", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParseWaf\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ParseWaf
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>rename_keys block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#rename_keys CloudwatchLogTransformer#rename_keys}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "renameKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigRenameKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RenameKeys
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>split_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#split_string CloudwatchLogTransformer#split_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "splitString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigSplitString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SplitString
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>substitute_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#substitute_string CloudwatchLogTransformer#substitute_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "substituteString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigSubstituteString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SubstituteString
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>trim_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#trim_string CloudwatchLogTransformer#trim_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trimString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigTrimString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TrimString
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>type_converter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#type_converter CloudwatchLogTransformer#type_converter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "typeConverter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigTypeConverter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TypeConverter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>upper_case_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#upper_case_string CloudwatchLogTransformer#upper_case_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "upperCaseString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigUpperCaseString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UpperCaseString
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
