using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ClusterPlacementGroupsClusterPlacementGroup
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cluster_placement_groups_cluster_placement_group oci_cluster_placement_groups_cluster_placement_group}.</summary>
    [JsiiClass(nativeType: typeof(oci.ClusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroup), fullyQualifiedName: "oci.clusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.clusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupConfig\"}}]")]
    public class ClusterPlacementGroupsClusterPlacementGroup : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cluster_placement_groups_cluster_placement_group oci_cluster_placement_groups_cluster_placement_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ClusterPlacementGroupsClusterPlacementGroup(Constructs.Construct scope, string id, oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ClusterPlacementGroupsClusterPlacementGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ClusterPlacementGroupsClusterPlacementGroup(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ClusterPlacementGroupsClusterPlacementGroup resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ClusterPlacementGroupsClusterPlacementGroup to import.</param>
        /// <param name="importFromId">The id of the existing ClusterPlacementGroupsClusterPlacementGroup that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ClusterPlacementGroupsClusterPlacementGroup to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ClusterPlacementGroupsClusterPlacementGroup to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cluster_placement_groups_cluster_placement_group#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ClusterPlacementGroupsClusterPlacementGroup that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ClusterPlacementGroupsClusterPlacementGroup to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.ClusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroup), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCapabilities", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.clusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupCapabilities\"}}]")]
        public virtual void PutCapabilities(oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupCapabilities @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupCapabilities)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlacementInstruction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.clusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupPlacementInstruction\"}}]")]
        public virtual void PutPlacementInstruction(oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupPlacementInstruction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupPlacementInstruction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.clusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCapabilities")]
        public virtual void ResetCapabilities()
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

        [JsiiMethod(name: "resetOpcDryRun")]
        public virtual void ResetOpcDryRun()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacementInstruction")]
        public virtual void ResetPlacementInstruction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetState")]
        public virtual void ResetState()
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
        = GetStaticProperty<string>(typeof(oci.ClusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroup))!;

        [JsiiProperty(name: "capabilities", typeJson: "{\"fqn\":\"oci.clusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupCapabilitiesOutputReference\"}")]
        public virtual oci.ClusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupCapabilitiesOutputReference Capabilities
        {
            get => GetInstanceProperty<oci.ClusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupCapabilitiesOutputReference>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "placementInstruction", typeJson: "{\"fqn\":\"oci.clusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupPlacementInstructionOutputReference\"}")]
        public virtual oci.ClusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupPlacementInstructionOutputReference PlacementInstruction
        {
            get => GetInstanceProperty<oci.ClusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupPlacementInstructionOutputReference>()!;
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.clusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupTimeoutsOutputReference\"}")]
        public virtual oci.ClusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.ClusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capabilitiesInput", typeJson: "{\"fqn\":\"oci.clusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupCapabilities\"}", isOptional: true)]
        public virtual oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupCapabilities? CapabilitiesInput
        {
            get => GetInstanceProperty<oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupCapabilities?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterPlacementGroupTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterPlacementGroupTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
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
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
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
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "opcDryRunInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? OpcDryRunInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementInstructionInput", typeJson: "{\"fqn\":\"oci.clusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupPlacementInstruction\"}", isOptional: true)]
        public virtual oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupPlacementInstruction? PlacementInstructionInput
        {
            get => GetInstanceProperty<oci.ClusterPlacementGroupsClusterPlacementGroup.IClusterPlacementGroupsClusterPlacementGroupPlacementInstruction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.clusterPlacementGroupsClusterPlacementGroup.ClusterPlacementGroupsClusterPlacementGroupTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterPlacementGroupType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterPlacementGroupType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
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

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "opcDryRun", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object OpcDryRun
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

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
