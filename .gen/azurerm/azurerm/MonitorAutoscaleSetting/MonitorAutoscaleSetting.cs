using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAutoscaleSetting
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/monitor_autoscale_setting azurerm_monitor_autoscale_setting}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSetting), fullyQualifiedName: "azurerm.monitorAutoscaleSetting.MonitorAutoscaleSetting", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingConfig\"}}]")]
    public class MonitorAutoscaleSetting : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/monitor_autoscale_setting azurerm_monitor_autoscale_setting} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MonitorAutoscaleSetting(Constructs.Construct scope, string id, azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MonitorAutoscaleSetting(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MonitorAutoscaleSetting(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a MonitorAutoscaleSetting resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MonitorAutoscaleSetting to import.</param>
        /// <param name="importFromId">The id of the existing MonitorAutoscaleSetting that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MonitorAutoscaleSetting to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MonitorAutoscaleSetting to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/monitor_autoscale_setting#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MonitorAutoscaleSetting that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MonitorAutoscaleSetting to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSetting), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putNotification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingNotification\"}}]")]
        public virtual void PutNotification(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingNotification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingNotification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPredictive", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingPredictive\"}}]")]
        public virtual void PutPredictive(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingPredictive @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingPredictive)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfile" />)[]</param>
        [JsiiMethod(name: "putProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfile\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutProfile(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfile[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfile).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfile).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotification")]
        public virtual void ResetNotification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPredictive")]
        public virtual void ResetPredictive()
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
        = GetStaticProperty<string>(typeof(azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSetting))!;

        [JsiiProperty(name: "notification", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingNotificationOutputReference\"}")]
        public virtual azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingNotificationOutputReference Notification
        {
            get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingNotificationOutputReference>()!;
        }

        [JsiiProperty(name: "predictive", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingPredictiveOutputReference\"}")]
        public virtual azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingPredictiveOutputReference Predictive
        {
            get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingPredictiveOutputReference>()!;
        }

        [JsiiProperty(name: "profile", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileList\"}")]
        public virtual azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingProfileList Profile
        {
            get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingProfileList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingTimeoutsOutputReference\"}")]
        public virtual azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingTimeoutsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
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
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
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
        [JsiiProperty(name: "notificationInput", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingNotification\"}", isOptional: true)]
        public virtual azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingNotification? NotificationInput
        {
            get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingNotification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "predictiveInput", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingPredictive\"}", isOptional: true)]
        public virtual azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingPredictive? PredictiveInput
        {
            get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingPredictive?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfile" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "profileInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ProfileInput
        {
            get => GetInstanceProperty<object?>();
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

        [JsiiOptional]
        [JsiiProperty(name: "targetResourceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetResourceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Enabled
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

        [JsiiProperty(name: "targetResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetResourceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
