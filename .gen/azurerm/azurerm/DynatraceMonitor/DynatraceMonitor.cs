using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DynatraceMonitor
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/dynatrace_monitor azurerm_dynatrace_monitor}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DynatraceMonitor.DynatraceMonitor), fullyQualifiedName: "azurerm.dynatraceMonitor.DynatraceMonitor", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dynatraceMonitor.DynatraceMonitorConfig\"}}]")]
    public class DynatraceMonitor : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/dynatrace_monitor azurerm_dynatrace_monitor} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DynatraceMonitor(Constructs.Construct scope, string id, azurerm.DynatraceMonitor.IDynatraceMonitorConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DynatraceMonitor.IDynatraceMonitorConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynatraceMonitor(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynatraceMonitor(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DynatraceMonitor resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DynatraceMonitor to import.</param>
        /// <param name="importFromId">The id of the existing DynatraceMonitor that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DynatraceMonitor to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DynatraceMonitor to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/dynatrace_monitor#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DynatraceMonitor that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DynatraceMonitor to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.DynatraceMonitor.DynatraceMonitor), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.DynatraceMonitor.IDynatraceMonitorEnvironmentProperties" />)[]</param>
        [JsiiMethod(name: "putEnvironmentProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.dynatraceMonitor.DynatraceMonitorEnvironmentProperties\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEnvironmentProperties(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.DynatraceMonitor.IDynatraceMonitorEnvironmentProperties[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.DynatraceMonitor.IDynatraceMonitorEnvironmentProperties).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.DynatraceMonitor.IDynatraceMonitorEnvironmentProperties).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dynatraceMonitor.DynatraceMonitorIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.DynatraceMonitor.IDynatraceMonitorIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DynatraceMonitor.IDynatraceMonitorIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlan", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dynatraceMonitor.DynatraceMonitorPlan\"}}]")]
        public virtual void PutPlan(azurerm.DynatraceMonitor.IDynatraceMonitorPlan @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DynatraceMonitor.IDynatraceMonitorPlan)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dynatraceMonitor.DynatraceMonitorTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DynatraceMonitor.IDynatraceMonitorTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DynatraceMonitor.IDynatraceMonitorTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUser", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dynatraceMonitor.DynatraceMonitorUser\"}}]")]
        public virtual void PutUser(azurerm.DynatraceMonitor.IDynatraceMonitorUser @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DynatraceMonitor.IDynatraceMonitorUser)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnvironmentProperties")]
        public virtual void ResetEnvironmentProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonitoringEnabled")]
        public virtual void ResetMonitoringEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(azurerm.DynatraceMonitor.DynatraceMonitor))!;

        [JsiiProperty(name: "environmentProperties", typeJson: "{\"fqn\":\"azurerm.dynatraceMonitor.DynatraceMonitorEnvironmentPropertiesList\"}")]
        public virtual azurerm.DynatraceMonitor.DynatraceMonitorEnvironmentPropertiesList EnvironmentProperties
        {
            get => GetInstanceProperty<azurerm.DynatraceMonitor.DynatraceMonitorEnvironmentPropertiesList>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.dynatraceMonitor.DynatraceMonitorIdentityOutputReference\"}")]
        public virtual azurerm.DynatraceMonitor.DynatraceMonitorIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.DynatraceMonitor.DynatraceMonitorIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "plan", typeJson: "{\"fqn\":\"azurerm.dynatraceMonitor.DynatraceMonitorPlanOutputReference\"}")]
        public virtual azurerm.DynatraceMonitor.DynatraceMonitorPlanOutputReference Plan
        {
            get => GetInstanceProperty<azurerm.DynatraceMonitor.DynatraceMonitorPlanOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dynatraceMonitor.DynatraceMonitorTimeoutsOutputReference\"}")]
        public virtual azurerm.DynatraceMonitor.DynatraceMonitorTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DynatraceMonitor.DynatraceMonitorTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"azurerm.dynatraceMonitor.DynatraceMonitorUserOutputReference\"}")]
        public virtual azurerm.DynatraceMonitor.DynatraceMonitorUserOutputReference User
        {
            get => GetInstanceProperty<azurerm.DynatraceMonitor.DynatraceMonitorUserOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.DynatraceMonitor.IDynatraceMonitorEnvironmentProperties" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "environmentPropertiesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.dynatraceMonitor.DynatraceMonitorEnvironmentProperties\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EnvironmentPropertiesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.dynatraceMonitor.DynatraceMonitorIdentity\"}", isOptional: true)]
        public virtual azurerm.DynatraceMonitor.IDynatraceMonitorIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.DynatraceMonitor.IDynatraceMonitorIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "marketplaceSubscriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MarketplaceSubscriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "monitoringEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? MonitoringEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "planInput", typeJson: "{\"fqn\":\"azurerm.dynatraceMonitor.DynatraceMonitorPlan\"}", isOptional: true)]
        public virtual azurerm.DynatraceMonitor.IDynatraceMonitorPlan? PlanInput
        {
            get => GetInstanceProperty<azurerm.DynatraceMonitor.IDynatraceMonitorPlan?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.DynatraceMonitor.IDynatraceMonitorTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.dynatraceMonitor.DynatraceMonitorTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userInput", typeJson: "{\"fqn\":\"azurerm.dynatraceMonitor.DynatraceMonitorUser\"}", isOptional: true)]
        public virtual azurerm.DynatraceMonitor.IDynatraceMonitorUser? UserInput
        {
            get => GetInstanceProperty<azurerm.DynatraceMonitor.IDynatraceMonitorUser?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "marketplaceSubscription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MarketplaceSubscription
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "monitoringEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object MonitoringEnabled
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
