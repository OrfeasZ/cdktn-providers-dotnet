using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudMigrationsTargetAsset
{
    [JsiiInterface(nativeType: typeof(ICloudMigrationsTargetAssetConfig), fullyQualifiedName: "oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetConfig")]
    public interface ICloudMigrationsTargetAssetConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_migrations_target_asset#is_excluded_from_execution CloudMigrationsTargetAsset#is_excluded_from_execution}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isExcludedFromExecution", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsExcludedFromExecution
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_migrations_target_asset#migration_plan_id CloudMigrationsTargetAsset#migration_plan_id}.</summary>
        [JsiiProperty(name: "migrationPlanId", typeJson: "{\"primitive\":\"string\"}")]
        string MigrationPlanId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_migrations_target_asset#type CloudMigrationsTargetAsset#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_migrations_target_asset#block_volumes_performance CloudMigrationsTargetAsset#block_volumes_performance}.</summary>
        [JsiiProperty(name: "blockVolumesPerformance", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BlockVolumesPerformance
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_migrations_target_asset#id CloudMigrationsTargetAsset#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_migrations_target_asset#ms_license CloudMigrationsTargetAsset#ms_license}.</summary>
        [JsiiProperty(name: "msLicense", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MsLicense
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_migrations_target_asset#preferred_shape_type CloudMigrationsTargetAsset#preferred_shape_type}.</summary>
        [JsiiProperty(name: "preferredShapeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreferredShapeType
        {
            get
            {
                return null;
            }
        }

        /// <summary>recommended_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_migrations_target_asset#recommended_spec CloudMigrationsTargetAsset#recommended_spec}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetRecommendedSpec" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "recommendedSpec", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetRecommendedSpec\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RecommendedSpec
        {
            get
            {
                return null;
            }
        }

        /// <summary>test_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_migrations_target_asset#test_spec CloudMigrationsTargetAsset#test_spec}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetTestSpec" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "testSpec", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetTestSpec\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TestSpec
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_migrations_target_asset#timeouts CloudMigrationsTargetAsset#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>user_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_migrations_target_asset#user_spec CloudMigrationsTargetAsset#user_spec}
        /// </remarks>
        [JsiiProperty(name: "userSpec", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpec? UserSpec
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudMigrationsTargetAssetConfig), fullyQualifiedName: "oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetConfig")]
        internal sealed class _Proxy : DeputyBase, oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_migrations_target_asset#is_excluded_from_execution CloudMigrationsTargetAsset#is_excluded_from_execution}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "isExcludedFromExecution", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsExcludedFromExecution
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_migrations_target_asset#migration_plan_id CloudMigrationsTargetAsset#migration_plan_id}.</summary>
            [JsiiProperty(name: "migrationPlanId", typeJson: "{\"primitive\":\"string\"}")]
            public string MigrationPlanId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_migrations_target_asset#type CloudMigrationsTargetAsset#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_migrations_target_asset#block_volumes_performance CloudMigrationsTargetAsset#block_volumes_performance}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blockVolumesPerformance", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BlockVolumesPerformance
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_migrations_target_asset#id CloudMigrationsTargetAsset#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_migrations_target_asset#ms_license CloudMigrationsTargetAsset#ms_license}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "msLicense", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MsLicense
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_migrations_target_asset#preferred_shape_type CloudMigrationsTargetAsset#preferred_shape_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preferredShapeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredShapeType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>recommended_spec block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_migrations_target_asset#recommended_spec CloudMigrationsTargetAsset#recommended_spec}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetRecommendedSpec" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recommendedSpec", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetRecommendedSpec\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RecommendedSpec
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>test_spec block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_migrations_target_asset#test_spec CloudMigrationsTargetAsset#test_spec}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetTestSpec" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "testSpec", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetTestSpec\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TestSpec
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_migrations_target_asset#timeouts CloudMigrationsTargetAsset#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetTimeouts\"}", isOptional: true)]
            public oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetTimeouts?>();
            }

            /// <summary>user_spec block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_migrations_target_asset#user_spec CloudMigrationsTargetAsset#user_spec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userSpec", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpec\"}", isOptional: true)]
            public oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpec? UserSpec
            {
                get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpec?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
