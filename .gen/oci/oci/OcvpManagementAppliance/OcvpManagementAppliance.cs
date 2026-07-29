using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpManagementAppliance
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/ocvp_management_appliance oci_ocvp_management_appliance}.</summary>
    [JsiiClass(nativeType: typeof(oci.OcvpManagementAppliance.OcvpManagementAppliance), fullyQualifiedName: "oci.ocvpManagementAppliance.OcvpManagementAppliance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.ocvpManagementAppliance.OcvpManagementApplianceConfig\"}}]")]
    public class OcvpManagementAppliance : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/ocvp_management_appliance oci_ocvp_management_appliance} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OcvpManagementAppliance(Constructs.Construct scope, string id, oci.OcvpManagementAppliance.IOcvpManagementApplianceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.OcvpManagementAppliance.IOcvpManagementApplianceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OcvpManagementAppliance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OcvpManagementAppliance(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a OcvpManagementAppliance resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OcvpManagementAppliance to import.</param>
        /// <param name="importFromId">The id of the existing OcvpManagementAppliance that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OcvpManagementAppliance to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OcvpManagementAppliance to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/ocvp_management_appliance#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OcvpManagementAppliance that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OcvpManagementAppliance to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.OcvpManagementAppliance.OcvpManagementAppliance), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.ocvpManagementAppliance.OcvpManagementApplianceConfiguration\"}}]")]
        public virtual void PutConfiguration(oci.OcvpManagementAppliance.IOcvpManagementApplianceConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OcvpManagementAppliance.IOcvpManagementApplianceConfiguration)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OcvpManagementAppliance.IOcvpManagementApplianceConnections" />)[]</param>
        [JsiiMethod(name: "putConnections", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ocvpManagementAppliance.OcvpManagementApplianceConnections\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutConnections(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.OcvpManagementAppliance.IOcvpManagementApplianceConnections[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OcvpManagementAppliance.IOcvpManagementApplianceConnections).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OcvpManagementAppliance.IOcvpManagementApplianceConnections).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.ocvpManagementAppliance.OcvpManagementApplianceTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.OcvpManagementAppliance.IOcvpManagementApplianceTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OcvpManagementAppliance.IOcvpManagementApplianceTimeouts)}, new object[]{@value});
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

        [JsiiMethod(name: "resetPublicSshKeys")]
        public virtual void ResetPublicSshKeys()
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
        = GetStaticProperty<string>(typeof(oci.OcvpManagementAppliance.OcvpManagementAppliance))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeInstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configuration", typeJson: "{\"fqn\":\"oci.ocvpManagementAppliance.OcvpManagementApplianceConfigurationOutputReference\"}")]
        public virtual oci.OcvpManagementAppliance.OcvpManagementApplianceConfigurationOutputReference Configuration
        {
            get => GetInstanceProperty<oci.OcvpManagementAppliance.OcvpManagementApplianceConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "connections", typeJson: "{\"fqn\":\"oci.ocvpManagementAppliance.OcvpManagementApplianceConnectionsList\"}")]
        public virtual oci.OcvpManagementAppliance.OcvpManagementApplianceConnectionsList Connections
        {
            get => GetInstanceProperty<oci.OcvpManagementAppliance.OcvpManagementApplianceConnectionsList>()!;
        }

        [JsiiProperty(name: "heartbeatConnectionStates", typeJson: "{\"fqn\":\"oci.ocvpManagementAppliance.OcvpManagementApplianceHeartbeatConnectionStatesList\"}")]
        public virtual oci.OcvpManagementAppliance.OcvpManagementApplianceHeartbeatConnectionStatesList HeartbeatConnectionStates
        {
            get => GetInstanceProperty<oci.OcvpManagementAppliance.OcvpManagementApplianceHeartbeatConnectionStatesList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managementAgentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementAgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pluginVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PluginVersion
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "timeConfigurationUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeConfigurationUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastHeartbeat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastHeartbeat
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.ocvpManagementAppliance.OcvpManagementApplianceTimeoutsOutputReference\"}")]
        public virtual oci.OcvpManagementAppliance.OcvpManagementApplianceTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.OcvpManagementAppliance.OcvpManagementApplianceTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationInput", typeJson: "{\"fqn\":\"oci.ocvpManagementAppliance.OcvpManagementApplianceConfiguration\"}", isOptional: true)]
        public virtual oci.OcvpManagementAppliance.IOcvpManagementApplianceConfiguration? ConfigurationInput
        {
            get => GetInstanceProperty<oci.OcvpManagementAppliance.IOcvpManagementApplianceConfiguration?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OcvpManagementAppliance.IOcvpManagementApplianceConnections" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ocvpManagementAppliance.OcvpManagementApplianceConnections\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ConnectionsInput
        {
            get => GetInstanceProperty<object?>();
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

        [JsiiOptional]
        [JsiiProperty(name: "publicSshKeysInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PublicSshKeysInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sddcIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SddcIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.OcvpManagementAppliance.IOcvpManagementApplianceTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.ocvpManagementAppliance.OcvpManagementApplianceTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
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

        [JsiiProperty(name: "publicSshKeys", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicSshKeys
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sddcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SddcId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
