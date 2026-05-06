using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsLogAnalyticsPreferencesManagement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_preferences_management oci_log_analytics_log_analytics_preferences_management}.</summary>
    [JsiiClass(nativeType: typeof(oci.LogAnalyticsLogAnalyticsPreferencesManagement.LogAnalyticsLogAnalyticsPreferencesManagement), fullyQualifiedName: "oci.logAnalyticsLogAnalyticsPreferencesManagement.LogAnalyticsLogAnalyticsPreferencesManagement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.logAnalyticsLogAnalyticsPreferencesManagement.LogAnalyticsLogAnalyticsPreferencesManagementConfig\"}}]")]
    public class LogAnalyticsLogAnalyticsPreferencesManagement : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_preferences_management oci_log_analytics_log_analytics_preferences_management} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LogAnalyticsLogAnalyticsPreferencesManagement(Constructs.Construct scope, string id, oci.LogAnalyticsLogAnalyticsPreferencesManagement.ILogAnalyticsLogAnalyticsPreferencesManagementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.LogAnalyticsLogAnalyticsPreferencesManagement.ILogAnalyticsLogAnalyticsPreferencesManagementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LogAnalyticsLogAnalyticsPreferencesManagement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LogAnalyticsLogAnalyticsPreferencesManagement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a LogAnalyticsLogAnalyticsPreferencesManagement resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LogAnalyticsLogAnalyticsPreferencesManagement to import.</param>
        /// <param name="importFromId">The id of the existing LogAnalyticsLogAnalyticsPreferencesManagement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LogAnalyticsLogAnalyticsPreferencesManagement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LogAnalyticsLogAnalyticsPreferencesManagement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_preferences_management#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LogAnalyticsLogAnalyticsPreferencesManagement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LogAnalyticsLogAnalyticsPreferencesManagement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.LogAnalyticsLogAnalyticsPreferencesManagement.LogAnalyticsLogAnalyticsPreferencesManagement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putItems", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsLogAnalyticsPreferencesManagement.LogAnalyticsLogAnalyticsPreferencesManagementItems\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutItems(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.LogAnalyticsLogAnalyticsPreferencesManagement.ILogAnalyticsLogAnalyticsPreferencesManagementItems[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LogAnalyticsLogAnalyticsPreferencesManagement.ILogAnalyticsLogAnalyticsPreferencesManagementItems).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LogAnalyticsLogAnalyticsPreferencesManagement.ILogAnalyticsLogAnalyticsPreferencesManagementItems).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.logAnalyticsLogAnalyticsPreferencesManagement.LogAnalyticsLogAnalyticsPreferencesManagementTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.LogAnalyticsLogAnalyticsPreferencesManagement.ILogAnalyticsLogAnalyticsPreferencesManagementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.LogAnalyticsLogAnalyticsPreferencesManagement.ILogAnalyticsLogAnalyticsPreferencesManagementTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetItems")]
        public virtual void ResetItems()
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
        = GetStaticProperty<string>(typeof(oci.LogAnalyticsLogAnalyticsPreferencesManagement.LogAnalyticsLogAnalyticsPreferencesManagement))!;

        [JsiiProperty(name: "items", typeJson: "{\"fqn\":\"oci.logAnalyticsLogAnalyticsPreferencesManagement.LogAnalyticsLogAnalyticsPreferencesManagementItemsList\"}")]
        public virtual oci.LogAnalyticsLogAnalyticsPreferencesManagement.LogAnalyticsLogAnalyticsPreferencesManagementItemsList Items
        {
            get => GetInstanceProperty<oci.LogAnalyticsLogAnalyticsPreferencesManagement.LogAnalyticsLogAnalyticsPreferencesManagementItemsList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.logAnalyticsLogAnalyticsPreferencesManagement.LogAnalyticsLogAnalyticsPreferencesManagementTimeoutsOutputReference\"}")]
        public virtual oci.LogAnalyticsLogAnalyticsPreferencesManagement.LogAnalyticsLogAnalyticsPreferencesManagementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.LogAnalyticsLogAnalyticsPreferencesManagement.LogAnalyticsLogAnalyticsPreferencesManagementTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "itemsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsLogAnalyticsPreferencesManagement.LogAnalyticsLogAnalyticsPreferencesManagementItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ItemsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.logAnalyticsLogAnalyticsPreferencesManagement.LogAnalyticsLogAnalyticsPreferencesManagementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
