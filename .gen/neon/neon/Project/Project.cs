using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace neon.Project
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project neon_project}.</summary>
    [JsiiClass(nativeType: typeof(neon.Project.Project), fullyQualifiedName: "neon.project.Project", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"neon.project.ProjectConfig\"}}]")]
    public class Project : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project neon_project} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Project(Constructs.Construct scope, string id, neon.Project.IProjectConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, neon.Project.IProjectConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Project(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Project(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a Project resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Project to import.</param>
        /// <param name="importFromId">The id of the existing Project that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Project to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Project to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Project that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Project to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(neon.Project.Project), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBranch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"neon.project.ProjectBranch\"}}]")]
        public virtual void PutBranch(neon.Project.IProjectBranch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(neon.Project.IProjectBranch)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDefaultEndpointSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"neon.project.ProjectDefaultEndpointSettings\"}}]")]
        public virtual void PutDefaultEndpointSettings(neon.Project.IProjectDefaultEndpointSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(neon.Project.IProjectDefaultEndpointSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMaintenanceWindow", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"neon.project.ProjectMaintenanceWindow\"}}]")]
        public virtual void PutMaintenanceWindow(neon.Project.IProjectMaintenanceWindow @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(neon.Project.IProjectMaintenanceWindow)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQuota", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"neon.project.ProjectQuota\"}}]")]
        public virtual void PutQuota(neon.Project.IProjectQuota @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(neon.Project.IProjectQuota)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllowedIps")]
        public virtual void ResetAllowedIps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowedIpsProtectedBranchesOnly")]
        public virtual void ResetAllowedIpsProtectedBranchesOnly()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlockPublicConnections")]
        public virtual void ResetBlockPublicConnections()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlockVpcConnections")]
        public virtual void ResetBlockVpcConnections()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBranch")]
        public virtual void ResetBranch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComputeProvisioner")]
        public virtual void ResetComputeProvisioner()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultEndpointSettings")]
        public virtual void ResetDefaultEndpointSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableLogicalReplication")]
        public virtual void ResetEnableLogicalReplication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHistoryRetentionSeconds")]
        public virtual void ResetHistoryRetentionSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenanceWindow")]
        public virtual void ResetMaintenanceWindow()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrgId")]
        public virtual void ResetOrgId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPgVersion")]
        public virtual void ResetPgVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQuota")]
        public virtual void ResetQuota()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegionId")]
        public virtual void ResetRegionId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorePassword")]
        public virtual void ResetStorePassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(neon.Project.Project))!;

        [JsiiProperty(name: "branch", typeJson: "{\"fqn\":\"neon.project.ProjectBranchOutputReference\"}")]
        public virtual neon.Project.ProjectBranchOutputReference Branch
        {
            get => GetInstanceProperty<neon.Project.ProjectBranchOutputReference>()!;
        }

        [JsiiProperty(name: "connectionUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionUriPooler", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionUriPooler
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseHostPooler", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseHostPooler
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databasePassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabasePassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseUser", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseUser
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultBranchId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultBranchId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultEndpointId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultEndpointSettings", typeJson: "{\"fqn\":\"neon.project.ProjectDefaultEndpointSettingsOutputReference\"}")]
        public virtual neon.Project.ProjectDefaultEndpointSettingsOutputReference DefaultEndpointSettings
        {
            get => GetInstanceProperty<neon.Project.ProjectDefaultEndpointSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"neon.project.ProjectMaintenanceWindowOutputReference\"}")]
        public virtual neon.Project.ProjectMaintenanceWindowOutputReference MaintenanceWindow
        {
            get => GetInstanceProperty<neon.Project.ProjectMaintenanceWindowOutputReference>()!;
        }

        [JsiiProperty(name: "quota", typeJson: "{\"fqn\":\"neon.project.ProjectQuotaOutputReference\"}")]
        public virtual neon.Project.ProjectQuotaOutputReference Quota
        {
            get => GetInstanceProperty<neon.Project.ProjectQuotaOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedIpsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AllowedIpsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedIpsProtectedBranchesOnlyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AllowedIpsProtectedBranchesOnlyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockPublicConnectionsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BlockPublicConnectionsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockVpcConnectionsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BlockVpcConnectionsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "branchInput", typeJson: "{\"fqn\":\"neon.project.ProjectBranch\"}", isOptional: true)]
        public virtual neon.Project.IProjectBranch? BranchInput
        {
            get => GetInstanceProperty<neon.Project.IProjectBranch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeProvisionerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeProvisionerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultEndpointSettingsInput", typeJson: "{\"fqn\":\"neon.project.ProjectDefaultEndpointSettings\"}", isOptional: true)]
        public virtual neon.Project.IProjectDefaultEndpointSettings? DefaultEndpointSettingsInput
        {
            get => GetInstanceProperty<neon.Project.IProjectDefaultEndpointSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableLogicalReplicationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EnableLogicalReplicationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "historyRetentionSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HistoryRetentionSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowInput", typeJson: "{\"fqn\":\"neon.project.ProjectMaintenanceWindow\"}", isOptional: true)]
        public virtual neon.Project.IProjectMaintenanceWindow? MaintenanceWindowInput
        {
            get => GetInstanceProperty<neon.Project.IProjectMaintenanceWindow?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orgIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OrgIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pgVersionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PgVersionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "quotaInput", typeJson: "{\"fqn\":\"neon.project.ProjectQuota\"}", isOptional: true)]
        public virtual neon.Project.IProjectQuota? QuotaInput
        {
            get => GetInstanceProperty<neon.Project.IProjectQuota?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storePasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorePasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "allowedIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedIps
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "allowedIpsProtectedBranchesOnly", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AllowedIpsProtectedBranchesOnly
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "blockPublicConnections", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockPublicConnections
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "blockVpcConnections", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockVpcConnections
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computeProvisioner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeProvisioner
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableLogicalReplication", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnableLogicalReplication
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "historyRetentionSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HistoryRetentionSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "orgId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrgId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pgVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PgVersion
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "regionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storePassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorePassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
