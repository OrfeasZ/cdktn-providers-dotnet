using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDisasterRecoveryAutomaticDrConfigurations
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/disaster_recovery_automatic_dr_configurations oci_disaster_recovery_automatic_dr_configurations}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDisasterRecoveryAutomaticDrConfigurations.DataOciDisasterRecoveryAutomaticDrConfigurations), fullyQualifiedName: "oci.dataOciDisasterRecoveryAutomaticDrConfigurations.DataOciDisasterRecoveryAutomaticDrConfigurations", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDisasterRecoveryAutomaticDrConfigurations.DataOciDisasterRecoveryAutomaticDrConfigurationsConfig\"}}]")]
    public class DataOciDisasterRecoveryAutomaticDrConfigurations : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/disaster_recovery_automatic_dr_configurations oci_disaster_recovery_automatic_dr_configurations} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDisasterRecoveryAutomaticDrConfigurations(Constructs.Construct scope, string id, oci.DataOciDisasterRecoveryAutomaticDrConfigurations.IDataOciDisasterRecoveryAutomaticDrConfigurationsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDisasterRecoveryAutomaticDrConfigurations.IDataOciDisasterRecoveryAutomaticDrConfigurationsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDisasterRecoveryAutomaticDrConfigurations(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDisasterRecoveryAutomaticDrConfigurations(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDisasterRecoveryAutomaticDrConfigurations resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDisasterRecoveryAutomaticDrConfigurations to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDisasterRecoveryAutomaticDrConfigurations that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDisasterRecoveryAutomaticDrConfigurations to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDisasterRecoveryAutomaticDrConfigurations to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/disaster_recovery_automatic_dr_configurations#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDisasterRecoveryAutomaticDrConfigurations that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDisasterRecoveryAutomaticDrConfigurations to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDisasterRecoveryAutomaticDrConfigurations.DataOciDisasterRecoveryAutomaticDrConfigurations), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciDisasterRecoveryAutomaticDrConfigurations.IDataOciDisasterRecoveryAutomaticDrConfigurationsFilter" />)[]</param>
        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDisasterRecoveryAutomaticDrConfigurations.DataOciDisasterRecoveryAutomaticDrConfigurationsFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciDisasterRecoveryAutomaticDrConfigurations.IDataOciDisasterRecoveryAutomaticDrConfigurationsFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciDisasterRecoveryAutomaticDrConfigurations.IDataOciDisasterRecoveryAutomaticDrConfigurationsFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciDisasterRecoveryAutomaticDrConfigurations.IDataOciDisasterRecoveryAutomaticDrConfigurationsFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutomaticDrConfigurationId")]
        public virtual void ResetAutomaticDrConfigurationId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLifecycleStateNotEqualTo")]
        public virtual void ResetLifecycleStateNotEqualTo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetState")]
        public virtual void ResetState()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDisasterRecoveryAutomaticDrConfigurations.DataOciDisasterRecoveryAutomaticDrConfigurations))!;

        [JsiiProperty(name: "automaticDrConfigurationCollection", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryAutomaticDrConfigurations.DataOciDisasterRecoveryAutomaticDrConfigurationsAutomaticDrConfigurationCollectionList\"}")]
        public virtual oci.DataOciDisasterRecoveryAutomaticDrConfigurations.DataOciDisasterRecoveryAutomaticDrConfigurationsAutomaticDrConfigurationCollectionList AutomaticDrConfigurationCollection
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryAutomaticDrConfigurations.DataOciDisasterRecoveryAutomaticDrConfigurationsAutomaticDrConfigurationCollectionList>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryAutomaticDrConfigurations.DataOciDisasterRecoveryAutomaticDrConfigurationsFilterList\"}")]
        public virtual oci.DataOciDisasterRecoveryAutomaticDrConfigurations.DataOciDisasterRecoveryAutomaticDrConfigurationsFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryAutomaticDrConfigurations.DataOciDisasterRecoveryAutomaticDrConfigurationsFilterList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticDrConfigurationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutomaticDrConfigurationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "drProtectionGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DrProtectionGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciDisasterRecoveryAutomaticDrConfigurations.IDataOciDisasterRecoveryAutomaticDrConfigurationsFilter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDisasterRecoveryAutomaticDrConfigurations.DataOciDisasterRecoveryAutomaticDrConfigurationsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lifecycleStateNotEqualToInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LifecycleStateNotEqualToInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "automaticDrConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutomaticDrConfigurationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "drProtectionGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DrProtectionGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lifecycleStateNotEqualTo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleStateNotEqualTo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
