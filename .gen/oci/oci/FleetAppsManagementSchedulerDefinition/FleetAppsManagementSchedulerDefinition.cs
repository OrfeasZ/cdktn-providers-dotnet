using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementSchedulerDefinition
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition oci_fleet_apps_management_scheduler_definition}.</summary>
    [JsiiClass(nativeType: typeof(oci.FleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinition), fullyQualifiedName: "oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinition", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionConfig\"}}]")]
    public class FleetAppsManagementSchedulerDefinition : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition oci_fleet_apps_management_scheduler_definition} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public FleetAppsManagementSchedulerDefinition(Constructs.Construct scope, string id, oci.FleetAppsManagementSchedulerDefinition.IFleetAppsManagementSchedulerDefinitionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.FleetAppsManagementSchedulerDefinition.IFleetAppsManagementSchedulerDefinitionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetAppsManagementSchedulerDefinition(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetAppsManagementSchedulerDefinition(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a FleetAppsManagementSchedulerDefinition resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the FleetAppsManagementSchedulerDefinition to import.</param>
        /// <param name="importFromId">The id of the existing FleetAppsManagementSchedulerDefinition that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the FleetAppsManagementSchedulerDefinition to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the FleetAppsManagementSchedulerDefinition to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_scheduler_definition#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing FleetAppsManagementSchedulerDefinition that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the FleetAppsManagementSchedulerDefinition to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.FleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinition), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putActionGroups", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionActionGroups\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutActionGroups(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.FleetAppsManagementSchedulerDefinition.IFleetAppsManagementSchedulerDefinitionActionGroups[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementSchedulerDefinition.IFleetAppsManagementSchedulerDefinitionActionGroups).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementSchedulerDefinition.IFleetAppsManagementSchedulerDefinitionActionGroups).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRunBooks", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionRunBooks\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRunBooks(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.FleetAppsManagementSchedulerDefinition.IFleetAppsManagementSchedulerDefinitionRunBooks[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementSchedulerDefinition.IFleetAppsManagementSchedulerDefinitionRunBooks).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementSchedulerDefinition.IFleetAppsManagementSchedulerDefinitionRunBooks).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionSchedule\"}}]")]
        public virtual void PutSchedule(oci.FleetAppsManagementSchedulerDefinition.IFleetAppsManagementSchedulerDefinitionSchedule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementSchedulerDefinition.IFleetAppsManagementSchedulerDefinitionSchedule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.FleetAppsManagementSchedulerDefinition.IFleetAppsManagementSchedulerDefinitionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementSchedulerDefinition.IFleetAppsManagementSchedulerDefinitionTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
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

        [JsiiMethod(name: "resetRunBooks")]
        public virtual void ResetRunBooks()
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
        = GetStaticProperty<string>(typeof(oci.FleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinition))!;

        [JsiiProperty(name: "actionGroups", typeJson: "{\"fqn\":\"oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionActionGroupsList\"}")]
        public virtual oci.FleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionActionGroupsList ActionGroups
        {
            get => GetInstanceProperty<oci.FleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionActionGroupsList>()!;
        }

        [JsiiProperty(name: "countOfAffectedActionGroups", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CountOfAffectedActionGroups
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "countOfAffectedResources", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CountOfAffectedResources
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "countOfAffectedTargets", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CountOfAffectedTargets
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleOperations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LifecycleOperations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "products", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Products
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "resourceRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "runBooks", typeJson: "{\"fqn\":\"oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionRunBooksList\"}")]
        public virtual oci.FleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionRunBooksList RunBooks
        {
            get => GetInstanceProperty<oci.FleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionRunBooksList>()!;
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionScheduleOutputReference\"}")]
        public virtual oci.FleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionScheduleOutputReference Schedule
        {
            get => GetInstanceProperty<oci.FleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionScheduleOutputReference>()!;
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

        [JsiiProperty(name: "timeOfNextRun", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfNextRun
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionTimeoutsOutputReference\"}")]
        public virtual oci.FleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.FleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionGroupsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionActionGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ActionGroupsInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "runBooksInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionRunBooks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RunBooksInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduleInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionSchedule\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementSchedulerDefinition.IFleetAppsManagementSchedulerDefinitionSchedule? ScheduleInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementSchedulerDefinition.IFleetAppsManagementSchedulerDefinitionSchedule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.fleetAppsManagementSchedulerDefinition.FleetAppsManagementSchedulerDefinitionTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
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
    }
}
