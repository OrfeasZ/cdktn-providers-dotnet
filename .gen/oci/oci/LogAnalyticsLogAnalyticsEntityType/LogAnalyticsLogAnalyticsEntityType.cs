using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsLogAnalyticsEntityType
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_entity_type oci_log_analytics_log_analytics_entity_type}.</summary>
    [JsiiClass(nativeType: typeof(oci.LogAnalyticsLogAnalyticsEntityType.LogAnalyticsLogAnalyticsEntityType), fullyQualifiedName: "oci.logAnalyticsLogAnalyticsEntityType.LogAnalyticsLogAnalyticsEntityType", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.logAnalyticsLogAnalyticsEntityType.LogAnalyticsLogAnalyticsEntityTypeConfig\"}}]")]
    public class LogAnalyticsLogAnalyticsEntityType : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_entity_type oci_log_analytics_log_analytics_entity_type} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LogAnalyticsLogAnalyticsEntityType(Constructs.Construct scope, string id, oci.LogAnalyticsLogAnalyticsEntityType.ILogAnalyticsLogAnalyticsEntityTypeConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.LogAnalyticsLogAnalyticsEntityType.ILogAnalyticsLogAnalyticsEntityTypeConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LogAnalyticsLogAnalyticsEntityType(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LogAnalyticsLogAnalyticsEntityType(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a LogAnalyticsLogAnalyticsEntityType resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LogAnalyticsLogAnalyticsEntityType to import.</param>
        /// <param name="importFromId">The id of the existing LogAnalyticsLogAnalyticsEntityType that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LogAnalyticsLogAnalyticsEntityType to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LogAnalyticsLogAnalyticsEntityType to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_entity_type#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LogAnalyticsLogAnalyticsEntityType that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LogAnalyticsLogAnalyticsEntityType to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.LogAnalyticsLogAnalyticsEntityType.LogAnalyticsLogAnalyticsEntityType), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsLogAnalyticsEntityType.LogAnalyticsLogAnalyticsEntityTypeProperties\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutProperties(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.LogAnalyticsLogAnalyticsEntityType.ILogAnalyticsLogAnalyticsEntityTypeProperties[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LogAnalyticsLogAnalyticsEntityType.ILogAnalyticsLogAnalyticsEntityTypeProperties).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LogAnalyticsLogAnalyticsEntityType.ILogAnalyticsLogAnalyticsEntityTypeProperties).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.logAnalyticsLogAnalyticsEntityType.LogAnalyticsLogAnalyticsEntityTypeTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.LogAnalyticsLogAnalyticsEntityType.ILogAnalyticsLogAnalyticsEntityTypeTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.LogAnalyticsLogAnalyticsEntityType.ILogAnalyticsLogAnalyticsEntityTypeTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCategory")]
        public virtual void ResetCategory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProperties")]
        public virtual void ResetProperties()
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
        = GetStaticProperty<string>(typeof(oci.LogAnalyticsLogAnalyticsEntityType.LogAnalyticsLogAnalyticsEntityType))!;

        [JsiiProperty(name: "cloudType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "internalName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InternalName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managementAgentEligibilityStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementAgentEligibilityStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"oci.logAnalyticsLogAnalyticsEntityType.LogAnalyticsLogAnalyticsEntityTypePropertiesList\"}")]
        public virtual oci.LogAnalyticsLogAnalyticsEntityType.LogAnalyticsLogAnalyticsEntityTypePropertiesList Properties
        {
            get => GetInstanceProperty<oci.LogAnalyticsLogAnalyticsEntityType.LogAnalyticsLogAnalyticsEntityTypePropertiesList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.logAnalyticsLogAnalyticsEntityType.LogAnalyticsLogAnalyticsEntityTypeTimeoutsOutputReference\"}")]
        public virtual oci.LogAnalyticsLogAnalyticsEntityType.LogAnalyticsLogAnalyticsEntityTypeTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.LogAnalyticsLogAnalyticsEntityType.LogAnalyticsLogAnalyticsEntityTypeTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "categoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CategoryInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "namespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "propertiesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsLogAnalyticsEntityType.LogAnalyticsLogAnalyticsEntityTypeProperties\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PropertiesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.logAnalyticsLogAnalyticsEntityType.LogAnalyticsLogAnalyticsEntityTypeTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Category
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
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
