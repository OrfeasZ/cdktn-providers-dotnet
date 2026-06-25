using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryAutomaticDrConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/disaster_recovery_automatic_dr_configuration oci_disaster_recovery_automatic_dr_configuration}.</summary>
    [JsiiClass(nativeType: typeof(oci.DisasterRecoveryAutomaticDrConfiguration.DisasterRecoveryAutomaticDrConfiguration), fullyQualifiedName: "oci.disasterRecoveryAutomaticDrConfiguration.DisasterRecoveryAutomaticDrConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.disasterRecoveryAutomaticDrConfiguration.DisasterRecoveryAutomaticDrConfigurationConfig\"}}]")]
    public class DisasterRecoveryAutomaticDrConfiguration : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/disaster_recovery_automatic_dr_configuration oci_disaster_recovery_automatic_dr_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DisasterRecoveryAutomaticDrConfiguration(Constructs.Construct scope, string id, oci.DisasterRecoveryAutomaticDrConfiguration.IDisasterRecoveryAutomaticDrConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DisasterRecoveryAutomaticDrConfiguration.IDisasterRecoveryAutomaticDrConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DisasterRecoveryAutomaticDrConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DisasterRecoveryAutomaticDrConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DisasterRecoveryAutomaticDrConfiguration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DisasterRecoveryAutomaticDrConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing DisasterRecoveryAutomaticDrConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DisasterRecoveryAutomaticDrConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DisasterRecoveryAutomaticDrConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/disaster_recovery_automatic_dr_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DisasterRecoveryAutomaticDrConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DisasterRecoveryAutomaticDrConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DisasterRecoveryAutomaticDrConfiguration.DisasterRecoveryAutomaticDrConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DisasterRecoveryAutomaticDrConfiguration.IDisasterRecoveryAutomaticDrConfigurationMembers" />)[]</param>
        [JsiiMethod(name: "putMembers", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryAutomaticDrConfiguration.DisasterRecoveryAutomaticDrConfigurationMembers\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMembers(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DisasterRecoveryAutomaticDrConfiguration.IDisasterRecoveryAutomaticDrConfigurationMembers[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DisasterRecoveryAutomaticDrConfiguration.IDisasterRecoveryAutomaticDrConfigurationMembers).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DisasterRecoveryAutomaticDrConfiguration.IDisasterRecoveryAutomaticDrConfigurationMembers).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.disasterRecoveryAutomaticDrConfiguration.DisasterRecoveryAutomaticDrConfigurationTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DisasterRecoveryAutomaticDrConfiguration.IDisasterRecoveryAutomaticDrConfigurationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DisasterRecoveryAutomaticDrConfiguration.IDisasterRecoveryAutomaticDrConfigurationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefaultFailoverDrPlanId")]
        public virtual void ResetDefaultFailoverDrPlanId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultSwitchoverDrPlanId")]
        public virtual void ResetDefaultSwitchoverDrPlanId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(oci.DisasterRecoveryAutomaticDrConfiguration.DisasterRecoveryAutomaticDrConfiguration))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastAutomaticDrExecutionSubmitDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastAutomaticDrExecutionSubmitDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastAutomaticDrExecutionSubmitStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastAutomaticDrExecutionSubmitStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "members", typeJson: "{\"fqn\":\"oci.disasterRecoveryAutomaticDrConfiguration.DisasterRecoveryAutomaticDrConfigurationMembersList\"}")]
        public virtual oci.DisasterRecoveryAutomaticDrConfiguration.DisasterRecoveryAutomaticDrConfigurationMembersList Members
        {
            get => GetInstanceProperty<oci.DisasterRecoveryAutomaticDrConfiguration.DisasterRecoveryAutomaticDrConfigurationMembersList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastAutomaticDrExecutionSubmitAttempt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastAutomaticDrExecutionSubmitAttempt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.disasterRecoveryAutomaticDrConfiguration.DisasterRecoveryAutomaticDrConfigurationTimeoutsOutputReference\"}")]
        public virtual oci.DisasterRecoveryAutomaticDrConfiguration.DisasterRecoveryAutomaticDrConfigurationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DisasterRecoveryAutomaticDrConfiguration.DisasterRecoveryAutomaticDrConfigurationTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultFailoverDrPlanIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultFailoverDrPlanIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultSwitchoverDrPlanIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultSwitchoverDrPlanIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DisasterRecoveryAutomaticDrConfiguration.IDisasterRecoveryAutomaticDrConfigurationMembers" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "membersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.disasterRecoveryAutomaticDrConfiguration.DisasterRecoveryAutomaticDrConfigurationMembers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MembersInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DisasterRecoveryAutomaticDrConfiguration.IDisasterRecoveryAutomaticDrConfigurationTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.disasterRecoveryAutomaticDrConfiguration.DisasterRecoveryAutomaticDrConfigurationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "defaultFailoverDrPlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultFailoverDrPlanId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultSwitchoverDrPlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultSwitchoverDrPlanId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
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

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
