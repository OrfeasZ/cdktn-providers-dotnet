using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightDataSet.QuicksightDataSetConfig")]
    public class QuicksightDataSetConfig : aws.QuicksightDataSet.IQuicksightDataSetConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/quicksight_data_set#data_set_id QuicksightDataSet#data_set_id}.</summary>
        [JsiiProperty(name: "dataSetId", typeJson: "{\"primitive\":\"string\"}")]
        public string DataSetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/quicksight_data_set#import_mode QuicksightDataSet#import_mode}.</summary>
        [JsiiProperty(name: "importMode", typeJson: "{\"primitive\":\"string\"}")]
        public string ImportMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/quicksight_data_set#name QuicksightDataSet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/quicksight_data_set#aws_account_id QuicksightDataSet#aws_account_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "awsAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AwsAccountId
        {
            get;
            set;
        }

        private object? _columnGroups;

        /// <summary>column_groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/quicksight_data_set#column_groups QuicksightDataSet#column_groups}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "columnGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetColumnGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ColumnGroups
        {
            get => _columnGroups;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.QuicksightDataSet.IQuicksightDataSetColumnGroups[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetColumnGroups).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _columnGroups = value;
            }
        }

        private object? _columnLevelPermissionRules;

        /// <summary>column_level_permission_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/quicksight_data_set#column_level_permission_rules QuicksightDataSet#column_level_permission_rules}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "columnLevelPermissionRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetColumnLevelPermissionRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ColumnLevelPermissionRules
        {
            get => _columnLevelPermissionRules;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.QuicksightDataSet.IQuicksightDataSetColumnLevelPermissionRules[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetColumnLevelPermissionRules).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _columnLevelPermissionRules = value;
            }
        }

        /// <summary>data_set_usage_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/quicksight_data_set#data_set_usage_configuration QuicksightDataSet#data_set_usage_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataSetUsageConfiguration", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetDataSetUsageConfiguration\"}", isOptional: true)]
        public aws.QuicksightDataSet.IQuicksightDataSetDataSetUsageConfiguration? DataSetUsageConfiguration
        {
            get;
            set;
        }

        private object? _fieldFolders;

        /// <summary>field_folders block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/quicksight_data_set#field_folders QuicksightDataSet#field_folders}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fieldFolders", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetFieldFolders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FieldFolders
        {
            get => _fieldFolders;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.QuicksightDataSet.IQuicksightDataSetFieldFolders[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetFieldFolders).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fieldFolders = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/quicksight_data_set#id QuicksightDataSet#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        private object? _logicalTableMap;

        /// <summary>logical_table_map block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/quicksight_data_set#logical_table_map QuicksightDataSet#logical_table_map}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logicalTableMap", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMap\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LogicalTableMap
        {
            get => _logicalTableMap;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMap[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMap).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _logicalTableMap = value;
            }
        }

        private object? _permissions;

        /// <summary>permissions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/quicksight_data_set#permissions QuicksightDataSet#permissions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "permissions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPermissions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Permissions
        {
            get => _permissions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.QuicksightDataSet.IQuicksightDataSetPermissions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetPermissions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _permissions = value;
            }
        }

        private object? _physicalTableMap;

        /// <summary>physical_table_map block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/quicksight_data_set#physical_table_map QuicksightDataSet#physical_table_map}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "physicalTableMap", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMap\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PhysicalTableMap
        {
            get => _physicalTableMap;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMap[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMap).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _physicalTableMap = value;
            }
        }

        /// <summary>refresh_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/quicksight_data_set#refresh_properties QuicksightDataSet#refresh_properties}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "refreshProperties", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRefreshProperties\"}", isOptional: true)]
        public aws.QuicksightDataSet.IQuicksightDataSetRefreshProperties? RefreshProperties
        {
            get;
            set;
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/quicksight_data_set#region QuicksightDataSet#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>row_level_permission_data_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/quicksight_data_set#row_level_permission_data_set QuicksightDataSet#row_level_permission_data_set}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rowLevelPermissionDataSet", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRowLevelPermissionDataSet\"}", isOptional: true)]
        public aws.QuicksightDataSet.IQuicksightDataSetRowLevelPermissionDataSet? RowLevelPermissionDataSet
        {
            get;
            set;
        }

        /// <summary>row_level_permission_tag_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/quicksight_data_set#row_level_permission_tag_configuration QuicksightDataSet#row_level_permission_tag_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rowLevelPermissionTagConfiguration", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRowLevelPermissionTagConfiguration\"}", isOptional: true)]
        public aws.QuicksightDataSet.IQuicksightDataSetRowLevelPermissionTagConfiguration? RowLevelPermissionTagConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/quicksight_data_set#tags QuicksightDataSet#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/quicksight_data_set#tags_all QuicksightDataSet#tags_all}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/quicksight_data_set#use_as QuicksightDataSet#use_as}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useAs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UseAs
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
