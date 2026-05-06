using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudMigrationsTargetAsset
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset oci_cloud_migrations_target_asset}.</summary>
    [JsiiClass(nativeType: typeof(oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAsset), fullyQualifiedName: "oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAsset", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetConfig\"}}]")]
    public class CloudMigrationsTargetAsset : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset oci_cloud_migrations_target_asset} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudMigrationsTargetAsset(Constructs.Construct scope, string id, oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudMigrationsTargetAsset(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudMigrationsTargetAsset(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a CloudMigrationsTargetAsset resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CloudMigrationsTargetAsset to import.</param>
        /// <param name="importFromId">The id of the existing CloudMigrationsTargetAsset that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CloudMigrationsTargetAsset to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CloudMigrationsTargetAsset to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CloudMigrationsTargetAsset that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CloudMigrationsTargetAsset to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAsset), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUserSpec", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpec\"}}]")]
        public virtual void PutUserSpec(oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpec @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpec)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBlockVolumesPerformance")]
        public virtual void ResetBlockVolumesPerformance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMsLicense")]
        public virtual void ResetMsLicense()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAsset))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compatibilityMessages", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetCompatibilityMessagesList\"}")]
        public virtual oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetCompatibilityMessagesList CompatibilityMessages
        {
            get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetCompatibilityMessagesList>()!;
        }

        [JsiiProperty(name: "createdResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "estimatedCost", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetEstimatedCostList\"}")]
        public virtual oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetEstimatedCostList EstimatedCost
        {
            get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetEstimatedCostList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "migrationAsset", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetMigrationAssetList\"}")]
        public virtual oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetMigrationAssetList MigrationAsset
        {
            get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetMigrationAssetList>()!;
        }

        [JsiiProperty(name: "recommendedSpec", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetRecommendedSpecList\"}")]
        public virtual oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetRecommendedSpecList RecommendedSpec
        {
            get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetRecommendedSpecList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "testSpec", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetTestSpecList\"}")]
        public virtual oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetTestSpecList TestSpec
        {
            get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetTestSpecList>()!;
        }

        [JsiiProperty(name: "timeAssessed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAssessed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetTimeoutsOutputReference\"}")]
        public virtual oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userSpec", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecOutputReference\"}")]
        public virtual oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecOutputReference UserSpec
        {
            get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockVolumesPerformanceInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BlockVolumesPerformanceInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isExcludedFromExecutionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsExcludedFromExecutionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "migrationPlanIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MigrationPlanIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "msLicenseInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MsLicenseInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preferredShapeTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreferredShapeTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userSpecInput", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpec\"}", isOptional: true)]
        public virtual oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpec? UserSpecInput
        {
            get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpec?>();
        }

        [JsiiProperty(name: "blockVolumesPerformance", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BlockVolumesPerformance
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isExcludedFromExecution", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsExcludedFromExecution
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "migrationPlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MigrationPlanId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "msLicense", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MsLicense
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preferredShapeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreferredShapeType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
