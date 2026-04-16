using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace neon.Project
{
    [JsiiByValue(fqn: "neon.project.ProjectConfig")]
    public class ProjectConfig : neon.Project.IProjectConfig
    {
        /// <summary>A list of IP addresses that are allowed to connect to the endpoints.</summary>
        /// <remarks>
        /// Note that the feature is available to the Neon Scale plans only. Details: https://neon.tech/docs/manage/projects#configure-ip-allow
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#allowed_ips Project#allowed_ips}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedIps
        {
            get;
            set;
        }

        /// <summary>Set to 'yes' to activate, 'no' to deactivate explicitly, and omit to keep the default value.</summary>
        /// <remarks>
        /// Apply the allow-list to the protected branches only.
        /// Note that the feature is available to the Neon Scale plans only.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#allowed_ips_protected_branches_only Project#allowed_ips_protected_branches_only}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedIpsProtectedBranchesOnly", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AllowedIpsProtectedBranchesOnly
        {
            get;
            set;
        }

        /// <summary>Set to 'yes' to activate, 'no' to deactivate explicitly, and omit to keep the default value.</summary>
        /// <remarks>
        /// Block connections from public internet. This supersedes the AllowedIPs list.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#block_public_connections Project#block_public_connections}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blockPublicConnections", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BlockPublicConnections
        {
            get;
            set;
        }

        /// <summary>Set to 'yes' to activate, 'no' to deactivate explicitly, and omit to keep the default value.</summary>
        /// <remarks>
        /// Block connections that use VPC endpoints.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#block_vpc_connections Project#block_vpc_connections}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blockVpcConnections", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BlockVpcConnections
        {
            get;
            set;
        }

        /// <summary>branch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#branch Project#branch}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "branch", typeJson: "{\"fqn\":\"neon.project.ProjectBranch\"}", isOptional: true)]
        public neon.Project.IProjectBranch? Branch
        {
            get;
            set;
        }

        /// <summary>Provisioner The Neon compute provisioner. Specify the k8s-neonvm provisioner to create a compute endpoint that supports Autoscaling.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#compute_provisioner Project#compute_provisioner}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "computeProvisioner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ComputeProvisioner
        {
            get;
            set;
        }

        /// <summary>default_endpoint_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#default_endpoint_settings Project#default_endpoint_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultEndpointSettings", typeJson: "{\"fqn\":\"neon.project.ProjectDefaultEndpointSettings\"}", isOptional: true)]
        public neon.Project.IProjectDefaultEndpointSettings? DefaultEndpointSettings
        {
            get;
            set;
        }

        /// <summary>Set to 'yes' to activate, 'no' to deactivate explicitly, and omit to keep the default value.</summary>
        /// <remarks>
        /// Sets wal_level=logical for all compute endpoints in this project.
        /// All active endpoints will be suspended. Once enabled, logical replication cannot be disabled.
        /// See details: https://neon.tech/docs/introduction/logical-replication
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#enable_logical_replication Project#enable_logical_replication}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enableLogicalReplication", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EnableLogicalReplication
        {
            get;
            set;
        }

        /// <summary>The number of seconds to retain the point-in-time restore (PITR) backup history for this project. Default: 1 day, see https://neon.tech/docs/reference/glossary#point-in-time-restore.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#history_retention_seconds Project#history_retention_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "historyRetentionSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HistoryRetentionSeconds
        {
            get;
            set;
        }

        /// <summary>maintenance_window block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#maintenance_window Project#maintenance_window}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"neon.project.ProjectMaintenanceWindow\"}", isOptional: true)]
        public neon.Project.IProjectMaintenanceWindow? MaintenanceWindow
        {
            get;
            set;
        }

        /// <summary>Project name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#name Project#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Identifier of the organisation to which this project belongs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#org_id Project#org_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "orgId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OrgId
        {
            get;
            set;
        }

        /// <summary>Postgres version.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#pg_version Project#pg_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pgVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PgVersion
        {
            get;
            set;
        }

        /// <summary>quota block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#quota Project#quota}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "quota", typeJson: "{\"fqn\":\"neon.project.ProjectQuota\"}", isOptional: true)]
        public neon.Project.IProjectQuota? Quota
        {
            get;
            set;
        }

        /// <summary>Deployment region: https://neon.tech/docs/introduction/regions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#region_id Project#region_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "regionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegionId
        {
            get;
            set;
        }

        /// <summary>Set to 'yes' to activate, 'no' to deactivate explicitly, and omit to keep the default value.</summary>
        /// <remarks>
        /// Whether or not passwords are stored for roles in the Neon project.
        /// Storing passwords facilitates access to Neon features that require authorization.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#store_password Project#store_password}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorePassword
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
