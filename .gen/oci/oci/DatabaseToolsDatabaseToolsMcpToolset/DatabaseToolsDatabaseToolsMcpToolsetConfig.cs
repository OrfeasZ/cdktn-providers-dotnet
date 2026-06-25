using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsMcpToolset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseToolsDatabaseToolsMcpToolset.DatabaseToolsDatabaseToolsMcpToolsetConfig")]
    public class DatabaseToolsDatabaseToolsMcpToolsetConfig : oci.DatabaseToolsDatabaseToolsMcpToolset.IDatabaseToolsDatabaseToolsMcpToolsetConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_mcp_toolset#compartment_id DatabaseToolsDatabaseToolsMcpToolset#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public string CompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_mcp_toolset#database_tools_mcp_server_id DatabaseToolsDatabaseToolsMcpToolset#database_tools_mcp_server_id}.</summary>
        [JsiiProperty(name: "databaseToolsMcpServerId", typeJson: "{\"primitive\":\"string\"}")]
        public string DatabaseToolsMcpServerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_mcp_toolset#display_name DatabaseToolsDatabaseToolsMcpToolset#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_mcp_toolset#type DatabaseToolsDatabaseToolsMcpToolset#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_mcp_toolset#version DatabaseToolsDatabaseToolsMcpToolset#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
        public double Version
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_mcp_toolset#allowed_roles DatabaseToolsDatabaseToolsMcpToolset#allowed_roles}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedRoles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedRoles
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_mcp_toolset#default_execution_type DatabaseToolsDatabaseToolsMcpToolset#default_execution_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultExecutionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultExecutionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_mcp_toolset#defined_tags DatabaseToolsDatabaseToolsMcpToolset#defined_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_mcp_toolset#description DatabaseToolsDatabaseToolsMcpToolset#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_mcp_toolset#freeform_tags DatabaseToolsDatabaseToolsMcpToolset#freeform_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_mcp_toolset#generative_ai_semantic_store_id DatabaseToolsDatabaseToolsMcpToolset#generative_ai_semantic_store_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "generativeAiSemanticStoreId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GenerativeAiSemanticStoreId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_mcp_toolset#id DatabaseToolsDatabaseToolsMcpToolset#id}.</summary>
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

        private object? _locks;

        /// <summary>locks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_mcp_toolset#locks DatabaseToolsDatabaseToolsMcpToolset#locks}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseToolsDatabaseToolsMcpToolset.IDatabaseToolsDatabaseToolsMcpToolsetLocks" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "locks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseToolsDatabaseToolsMcpToolset.DatabaseToolsDatabaseToolsMcpToolsetLocks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Locks
        {
            get => _locks;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatabaseToolsDatabaseToolsMcpToolset.IDatabaseToolsDatabaseToolsMcpToolsetLocks[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseToolsDatabaseToolsMcpToolset.IDatabaseToolsDatabaseToolsMcpToolsetLocks).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _locks = value;
            }
        }

        private object? _reports;

        /// <summary>reports block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_mcp_toolset#reports DatabaseToolsDatabaseToolsMcpToolset#reports}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseToolsDatabaseToolsMcpToolset.IDatabaseToolsDatabaseToolsMcpToolsetReports" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reports", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseToolsDatabaseToolsMcpToolset.DatabaseToolsDatabaseToolsMcpToolsetReports\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Reports
        {
            get => _reports;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatabaseToolsDatabaseToolsMcpToolset.IDatabaseToolsDatabaseToolsMcpToolsetReports[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseToolsDatabaseToolsMcpToolset.IDatabaseToolsDatabaseToolsMcpToolsetReports).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _reports = value;
            }
        }

        /// <summary>source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_mcp_toolset#source DatabaseToolsDatabaseToolsMcpToolset#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsMcpToolset.DatabaseToolsDatabaseToolsMcpToolsetSource\"}", isOptional: true)]
        public oci.DatabaseToolsDatabaseToolsMcpToolset.IDatabaseToolsDatabaseToolsMcpToolsetSource? Source
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_mcp_toolset#timeouts DatabaseToolsDatabaseToolsMcpToolset#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsMcpToolset.DatabaseToolsDatabaseToolsMcpToolsetTimeouts\"}", isOptional: true)]
        public oci.DatabaseToolsDatabaseToolsMcpToolset.IDatabaseToolsDatabaseToolsMcpToolsetTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_mcp_toolset#tool_description DatabaseToolsDatabaseToolsMcpToolset#tool_description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "toolDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ToolDescription
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_mcp_toolset#tool_name DatabaseToolsDatabaseToolsMcpToolset#tool_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "toolName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ToolName
        {
            get;
            set;
        }

        private object? _tools;

        /// <summary>tools block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_mcp_toolset#tools DatabaseToolsDatabaseToolsMcpToolset#tools}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseToolsDatabaseToolsMcpToolset.IDatabaseToolsDatabaseToolsMcpToolsetTools" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tools", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseToolsDatabaseToolsMcpToolset.DatabaseToolsDatabaseToolsMcpToolsetTools\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Tools
        {
            get => _tools;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatabaseToolsDatabaseToolsMcpToolset.IDatabaseToolsDatabaseToolsMcpToolsetTools[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseToolsDatabaseToolsMcpToolset.IDatabaseToolsDatabaseToolsMcpToolsetTools).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tools = value;
            }
        }

        private object? _variables;

        /// <summary>variables block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_mcp_toolset#variables DatabaseToolsDatabaseToolsMcpToolset#variables}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseToolsDatabaseToolsMcpToolset.IDatabaseToolsDatabaseToolsMcpToolsetVariables" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "variables", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseToolsDatabaseToolsMcpToolset.DatabaseToolsDatabaseToolsMcpToolsetVariables\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Variables
        {
            get => _variables;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatabaseToolsDatabaseToolsMcpToolset.IDatabaseToolsDatabaseToolsMcpToolsetVariables[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseToolsDatabaseToolsMcpToolset.IDatabaseToolsDatabaseToolsMcpToolsetVariables).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _variables = value;
            }
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
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
        /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
        /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
