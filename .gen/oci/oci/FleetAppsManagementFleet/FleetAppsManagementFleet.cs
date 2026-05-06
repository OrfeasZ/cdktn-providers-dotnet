using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementFleet
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet oci_fleet_apps_management_fleet}.</summary>
    [JsiiClass(nativeType: typeof(oci.FleetAppsManagementFleet.FleetAppsManagementFleet), fullyQualifiedName: "oci.fleetAppsManagementFleet.FleetAppsManagementFleet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetConfig\"}}]")]
    public class FleetAppsManagementFleet : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet oci_fleet_apps_management_fleet} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public FleetAppsManagementFleet(Constructs.Construct scope, string id, oci.FleetAppsManagementFleet.IFleetAppsManagementFleetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.FleetAppsManagementFleet.IFleetAppsManagementFleetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetAppsManagementFleet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetAppsManagementFleet(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a FleetAppsManagementFleet resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the FleetAppsManagementFleet to import.</param>
        /// <param name="importFromId">The id of the existing FleetAppsManagementFleet that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the FleetAppsManagementFleet to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the FleetAppsManagementFleet to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing FleetAppsManagementFleet that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the FleetAppsManagementFleet to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.FleetAppsManagementFleet.FleetAppsManagementFleet), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCredentials", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentials\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCredentials(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentials[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentials).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentials).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetDetails\"}}]")]
        public virtual void PutDetails(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNotificationPreferences", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetNotificationPreferences\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNotificationPreferences(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.FleetAppsManagementFleet.IFleetAppsManagementFleetNotificationPreferences[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetNotificationPreferences).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetNotificationPreferences).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetProperties\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutProperties(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.FleetAppsManagementFleet.IFleetAppsManagementFleetProperties[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetProperties).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetProperties).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResources", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetResources\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResources(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.FleetAppsManagementFleet.IFleetAppsManagementFleetResources[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetResources).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetResources).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceSelection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetResourceSelection\"}}]")]
        public virtual void PutResourceSelection(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetResourceSelection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetResourceSelection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCredentials")]
        public virtual void ResetCredentials()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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

        [JsiiMethod(name: "resetDetails")]
        public virtual void ResetDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnvironmentType")]
        public virtual void ResetEnvironmentType()
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

        [JsiiMethod(name: "resetIsTargetAutoConfirm")]
        public virtual void ResetIsTargetAutoConfirm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotificationPreferences")]
        public virtual void ResetNotificationPreferences()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParentFleetId")]
        public virtual void ResetParentFleetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProducts")]
        public virtual void ResetProducts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProperties")]
        public virtual void ResetProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResources")]
        public virtual void ResetResources()
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
        = GetStaticProperty<string>(typeof(oci.FleetAppsManagementFleet.FleetAppsManagementFleet))!;

        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentialsList\"}")]
        public virtual oci.FleetAppsManagementFleet.FleetAppsManagementFleetCredentialsList Credentials
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleet.FleetAppsManagementFleetCredentialsList>()!;
        }

        [JsiiProperty(name: "details", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetDetailsOutputReference\"}")]
        public virtual oci.FleetAppsManagementFleet.FleetAppsManagementFleetDetailsOutputReference Details
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleet.FleetAppsManagementFleetDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notificationPreferences", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetNotificationPreferencesList\"}")]
        public virtual oci.FleetAppsManagementFleet.FleetAppsManagementFleetNotificationPreferencesList NotificationPreferences
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleet.FleetAppsManagementFleetNotificationPreferencesList>()!;
        }

        [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetPropertiesList\"}")]
        public virtual oci.FleetAppsManagementFleet.FleetAppsManagementFleetPropertiesList Properties
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleet.FleetAppsManagementFleetPropertiesList>()!;
        }

        [JsiiProperty(name: "resourceRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetResourcesList\"}")]
        public virtual oci.FleetAppsManagementFleet.FleetAppsManagementFleetResourcesList Resources
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleet.FleetAppsManagementFleetResourcesList>()!;
        }

        [JsiiProperty(name: "resourceSelection", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetResourceSelectionOutputReference\"}")]
        public virtual oci.FleetAppsManagementFleet.FleetAppsManagementFleetResourceSelectionOutputReference ResourceSelection
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleet.FleetAppsManagementFleetResourceSelectionOutputReference>()!;
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetTimeoutsOutputReference\"}")]
        public virtual oci.FleetAppsManagementFleet.FleetAppsManagementFleetTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleet.FleetAppsManagementFleetTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "credentialsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CredentialsInput
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
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "detailsInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetDetails\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementFleet.IFleetAppsManagementFleetDetails? DetailsInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleet.IFleetAppsManagementFleetDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EnvironmentTypeInput
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
        [JsiiProperty(name: "isTargetAutoConfirmInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsTargetAutoConfirmInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationPreferencesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetNotificationPreferences\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NotificationPreferencesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parentFleetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ParentFleetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "productsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ProductsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "propertiesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetProperties\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PropertiesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceSelectionInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetResourceSelection\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementFleet.IFleetAppsManagementFleetResourceSelection? ResourceSelectionInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleet.IFleetAppsManagementFleetResourceSelection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourcesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetResources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourcesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "environmentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnvironmentType
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

        [JsiiProperty(name: "isTargetAutoConfirm", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsTargetAutoConfirm
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

        [JsiiProperty(name: "parentFleetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentFleetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "products", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Products
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
