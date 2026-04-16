using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace neon.Project
{
    [JsiiInterface(nativeType: typeof(IProjectConfig), fullyQualifiedName: "neon.project.ProjectConfig")]
    public interface IProjectConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>A list of IP addresses that are allowed to connect to the endpoints.</summary>
        /// <remarks>
        /// Note that the feature is available to the Neon Scale plans only. Details: https://neon.tech/docs/manage/projects#configure-ip-allow
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#allowed_ips Project#allowed_ips}
        /// </remarks>
        [JsiiProperty(name: "allowedIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedIps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set to 'yes' to activate, 'no' to deactivate explicitly, and omit to keep the default value.</summary>
        /// <remarks>
        /// Apply the allow-list to the protected branches only.
        /// Note that the feature is available to the Neon Scale plans only.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#allowed_ips_protected_branches_only Project#allowed_ips_protected_branches_only}
        /// </remarks>
        [JsiiProperty(name: "allowedIpsProtectedBranchesOnly", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AllowedIpsProtectedBranchesOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set to 'yes' to activate, 'no' to deactivate explicitly, and omit to keep the default value.</summary>
        /// <remarks>
        /// Block connections from public internet. This supersedes the AllowedIPs list.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#block_public_connections Project#block_public_connections}
        /// </remarks>
        [JsiiProperty(name: "blockPublicConnections", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BlockPublicConnections
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set to 'yes' to activate, 'no' to deactivate explicitly, and omit to keep the default value.</summary>
        /// <remarks>
        /// Block connections that use VPC endpoints.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#block_vpc_connections Project#block_vpc_connections}
        /// </remarks>
        [JsiiProperty(name: "blockVpcConnections", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BlockVpcConnections
        {
            get
            {
                return null;
            }
        }

        /// <summary>branch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#branch Project#branch}
        /// </remarks>
        [JsiiProperty(name: "branch", typeJson: "{\"fqn\":\"neon.project.ProjectBranch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        neon.Project.IProjectBranch? Branch
        {
            get
            {
                return null;
            }
        }

        /// <summary>Provisioner The Neon compute provisioner. Specify the k8s-neonvm provisioner to create a compute endpoint that supports Autoscaling.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#compute_provisioner Project#compute_provisioner}
        /// </remarks>
        [JsiiProperty(name: "computeProvisioner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComputeProvisioner
        {
            get
            {
                return null;
            }
        }

        /// <summary>default_endpoint_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#default_endpoint_settings Project#default_endpoint_settings}
        /// </remarks>
        [JsiiProperty(name: "defaultEndpointSettings", typeJson: "{\"fqn\":\"neon.project.ProjectDefaultEndpointSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        neon.Project.IProjectDefaultEndpointSettings? DefaultEndpointSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set to 'yes' to activate, 'no' to deactivate explicitly, and omit to keep the default value.</summary>
        /// <remarks>
        /// Sets wal_level=logical for all compute endpoints in this project.
        /// All active endpoints will be suspended. Once enabled, logical replication cannot be disabled.
        /// See details: https://neon.tech/docs/introduction/logical-replication
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#enable_logical_replication Project#enable_logical_replication}
        /// </remarks>
        [JsiiProperty(name: "enableLogicalReplication", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EnableLogicalReplication
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of seconds to retain the point-in-time restore (PITR) backup history for this project. Default: 1 day, see https://neon.tech/docs/reference/glossary#point-in-time-restore.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#history_retention_seconds Project#history_retention_seconds}
        /// </remarks>
        [JsiiProperty(name: "historyRetentionSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HistoryRetentionSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>maintenance_window block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#maintenance_window Project#maintenance_window}
        /// </remarks>
        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"neon.project.ProjectMaintenanceWindow\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        neon.Project.IProjectMaintenanceWindow? MaintenanceWindow
        {
            get
            {
                return null;
            }
        }

        /// <summary>Project name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#name Project#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Identifier of the organisation to which this project belongs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#org_id Project#org_id}
        /// </remarks>
        [JsiiProperty(name: "orgId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OrgId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Postgres version.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#pg_version Project#pg_version}
        /// </remarks>
        [JsiiProperty(name: "pgVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PgVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>quota block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#quota Project#quota}
        /// </remarks>
        [JsiiProperty(name: "quota", typeJson: "{\"fqn\":\"neon.project.ProjectQuota\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        neon.Project.IProjectQuota? Quota
        {
            get
            {
                return null;
            }
        }

        /// <summary>Deployment region: https://neon.tech/docs/introduction/regions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#region_id Project#region_id}
        /// </remarks>
        [JsiiProperty(name: "regionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RegionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set to 'yes' to activate, 'no' to deactivate explicitly, and omit to keep the default value.</summary>
        /// <remarks>
        /// Whether or not passwords are stored for roles in the Neon project.
        /// Storing passwords facilitates access to Neon features that require authorization.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#store_password Project#store_password}
        /// </remarks>
        [JsiiProperty(name: "storePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorePassword
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IProjectConfig), fullyQualifiedName: "neon.project.ProjectConfig")]
        internal sealed class _Proxy : DeputyBase, neon.Project.IProjectConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<string[]?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>branch block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#branch Project#branch}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "branch", typeJson: "{\"fqn\":\"neon.project.ProjectBranch\"}", isOptional: true)]
            public neon.Project.IProjectBranch? Branch
            {
                get => GetInstanceProperty<neon.Project.IProjectBranch?>();
            }

            /// <summary>Provisioner The Neon compute provisioner. Specify the k8s-neonvm provisioner to create a compute endpoint that supports Autoscaling.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#compute_provisioner Project#compute_provisioner}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "computeProvisioner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputeProvisioner
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>default_endpoint_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#default_endpoint_settings Project#default_endpoint_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultEndpointSettings", typeJson: "{\"fqn\":\"neon.project.ProjectDefaultEndpointSettings\"}", isOptional: true)]
            public neon.Project.IProjectDefaultEndpointSettings? DefaultEndpointSettings
            {
                get => GetInstanceProperty<neon.Project.IProjectDefaultEndpointSettings?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The number of seconds to retain the point-in-time restore (PITR) backup history for this project. Default: 1 day, see https://neon.tech/docs/reference/glossary#point-in-time-restore.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#history_retention_seconds Project#history_retention_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "historyRetentionSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HistoryRetentionSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>maintenance_window block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#maintenance_window Project#maintenance_window}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"neon.project.ProjectMaintenanceWindow\"}", isOptional: true)]
            public neon.Project.IProjectMaintenanceWindow? MaintenanceWindow
            {
                get => GetInstanceProperty<neon.Project.IProjectMaintenanceWindow?>();
            }

            /// <summary>Project name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#name Project#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Identifier of the organisation to which this project belongs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#org_id Project#org_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "orgId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrgId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Postgres version.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#pg_version Project#pg_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pgVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PgVersion
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>quota block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#quota Project#quota}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "quota", typeJson: "{\"fqn\":\"neon.project.ProjectQuota\"}", isOptional: true)]
            public neon.Project.IProjectQuota? Quota
            {
                get => GetInstanceProperty<neon.Project.IProjectQuota?>();
            }

            /// <summary>Deployment region: https://neon.tech/docs/introduction/regions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#region_id Project#region_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RegionId
            {
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
