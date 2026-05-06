using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetSoftwareUpdateFsuCollection
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_collection oci_fleet_software_update_fsu_collection}.</summary>
    [JsiiClass(nativeType: typeof(oci.FleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollection), fullyQualifiedName: "oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollection", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionConfig\"}}]")]
    public class FleetSoftwareUpdateFsuCollection : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_collection oci_fleet_software_update_fsu_collection} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public FleetSoftwareUpdateFsuCollection(Constructs.Construct scope, string id, oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetSoftwareUpdateFsuCollection(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetSoftwareUpdateFsuCollection(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a FleetSoftwareUpdateFsuCollection resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the FleetSoftwareUpdateFsuCollection to import.</param>
        /// <param name="importFromId">The id of the existing FleetSoftwareUpdateFsuCollection that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the FleetSoftwareUpdateFsuCollection to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the FleetSoftwareUpdateFsuCollection to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_collection#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing FleetSoftwareUpdateFsuCollection that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the FleetSoftwareUpdateFsuCollection to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.FleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollection), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putComponents", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionComponents\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutComponents(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionComponents[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionComponents).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionComponents).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFleetDiscovery", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionFleetDiscovery\"}}]")]
        public virtual void PutFleetDiscovery(oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionFleetDiscovery @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionFleetDiscovery)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetComponents")]
        public virtual void ResetComponents()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFleetDiscovery")]
        public virtual void ResetFleetDiscovery()
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

        [JsiiMethod(name: "resetSourceMajorVersion")]
        public virtual void ResetSourceMajorVersion()
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
        = GetStaticProperty<string>(typeof(oci.FleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollection))!;

        [JsiiProperty(name: "activeFsuCycle", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionActiveFsuCycleList\"}")]
        public virtual oci.FleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionActiveFsuCycleList ActiveFsuCycle
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionActiveFsuCycleList>()!;
        }

        [JsiiProperty(name: "components", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionComponentsList\"}")]
        public virtual oci.FleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionComponentsList Components
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionComponentsList>()!;
        }

        [JsiiProperty(name: "fleetDiscovery", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionFleetDiscoveryOutputReference\"}")]
        public virtual oci.FleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionFleetDiscoveryOutputReference FleetDiscovery
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionFleetDiscoveryOutputReference>()!;
        }

        [JsiiProperty(name: "lastCompletedFsuCycleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastCompletedFsuCycleId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
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

        [JsiiProperty(name: "targetCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionTimeoutsOutputReference\"}")]
        public virtual oci.FleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "componentsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionComponents\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ComponentsInput
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
        [JsiiProperty(name: "fleetDiscoveryInput", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionFleetDiscovery\"}", isOptional: true)]
        public virtual oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionFleetDiscovery? FleetDiscoveryInput
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionFleetDiscovery?>();
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
        [JsiiProperty(name: "serviceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceMajorVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceMajorVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "serviceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceMajorVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceMajorVersion
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
