using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccountQueueProperties
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/storage_account_queue_properties azurerm_storage_account_queue_properties}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.StorageAccountQueueProperties.StorageAccountQueueProperties), fullyQualifiedName: "azurerm.storageAccountQueueProperties.StorageAccountQueueProperties", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.storageAccountQueueProperties.StorageAccountQueuePropertiesConfig\"}}]")]
    public class StorageAccountQueueProperties : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/storage_account_queue_properties azurerm_storage_account_queue_properties} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public StorageAccountQueueProperties(Constructs.Construct scope, string id, azurerm.StorageAccountQueueProperties.IStorageAccountQueuePropertiesConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.StorageAccountQueueProperties.IStorageAccountQueuePropertiesConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageAccountQueueProperties(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageAccountQueueProperties(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a StorageAccountQueueProperties resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the StorageAccountQueueProperties to import.</param>
        /// <param name="importFromId">The id of the existing StorageAccountQueueProperties that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the StorageAccountQueueProperties to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the StorageAccountQueueProperties to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/storage_account_queue_properties#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing StorageAccountQueueProperties that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the StorageAccountQueueProperties to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.StorageAccountQueueProperties.StorageAccountQueueProperties), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.StorageAccountQueueProperties.IStorageAccountQueuePropertiesCorsRule" />)[]</param>
        [JsiiMethod(name: "putCorsRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageAccountQueueProperties.StorageAccountQueuePropertiesCorsRule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCorsRule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.StorageAccountQueueProperties.IStorageAccountQueuePropertiesCorsRule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.StorageAccountQueueProperties.IStorageAccountQueuePropertiesCorsRule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.StorageAccountQueueProperties.IStorageAccountQueuePropertiesCorsRule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHourMetrics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccountQueueProperties.StorageAccountQueuePropertiesHourMetrics\"}}]")]
        public virtual void PutHourMetrics(azurerm.StorageAccountQueueProperties.IStorageAccountQueuePropertiesHourMetrics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccountQueueProperties.IStorageAccountQueuePropertiesHourMetrics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogging", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccountQueueProperties.StorageAccountQueuePropertiesLogging\"}}]")]
        public virtual void PutLogging(azurerm.StorageAccountQueueProperties.IStorageAccountQueuePropertiesLogging @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccountQueueProperties.IStorageAccountQueuePropertiesLogging)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMinuteMetrics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccountQueueProperties.StorageAccountQueuePropertiesMinuteMetrics\"}}]")]
        public virtual void PutMinuteMetrics(azurerm.StorageAccountQueueProperties.IStorageAccountQueuePropertiesMinuteMetrics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccountQueueProperties.IStorageAccountQueuePropertiesMinuteMetrics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccountQueueProperties.StorageAccountQueuePropertiesTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.StorageAccountQueueProperties.IStorageAccountQueuePropertiesTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccountQueueProperties.IStorageAccountQueuePropertiesTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCorsRule")]
        public virtual void ResetCorsRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHourMetrics")]
        public virtual void ResetHourMetrics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogging")]
        public virtual void ResetLogging()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinuteMetrics")]
        public virtual void ResetMinuteMetrics()
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
        = GetStaticProperty<string>(typeof(azurerm.StorageAccountQueueProperties.StorageAccountQueueProperties))!;

        [JsiiProperty(name: "corsRule", typeJson: "{\"fqn\":\"azurerm.storageAccountQueueProperties.StorageAccountQueuePropertiesCorsRuleList\"}")]
        public virtual azurerm.StorageAccountQueueProperties.StorageAccountQueuePropertiesCorsRuleList CorsRule
        {
            get => GetInstanceProperty<azurerm.StorageAccountQueueProperties.StorageAccountQueuePropertiesCorsRuleList>()!;
        }

        [JsiiProperty(name: "hourMetrics", typeJson: "{\"fqn\":\"azurerm.storageAccountQueueProperties.StorageAccountQueuePropertiesHourMetricsOutputReference\"}")]
        public virtual azurerm.StorageAccountQueueProperties.StorageAccountQueuePropertiesHourMetricsOutputReference HourMetrics
        {
            get => GetInstanceProperty<azurerm.StorageAccountQueueProperties.StorageAccountQueuePropertiesHourMetricsOutputReference>()!;
        }

        [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"azurerm.storageAccountQueueProperties.StorageAccountQueuePropertiesLoggingOutputReference\"}")]
        public virtual azurerm.StorageAccountQueueProperties.StorageAccountQueuePropertiesLoggingOutputReference Logging
        {
            get => GetInstanceProperty<azurerm.StorageAccountQueueProperties.StorageAccountQueuePropertiesLoggingOutputReference>()!;
        }

        [JsiiProperty(name: "minuteMetrics", typeJson: "{\"fqn\":\"azurerm.storageAccountQueueProperties.StorageAccountQueuePropertiesMinuteMetricsOutputReference\"}")]
        public virtual azurerm.StorageAccountQueueProperties.StorageAccountQueuePropertiesMinuteMetricsOutputReference MinuteMetrics
        {
            get => GetInstanceProperty<azurerm.StorageAccountQueueProperties.StorageAccountQueuePropertiesMinuteMetricsOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.storageAccountQueueProperties.StorageAccountQueuePropertiesTimeoutsOutputReference\"}")]
        public virtual azurerm.StorageAccountQueueProperties.StorageAccountQueuePropertiesTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.StorageAccountQueueProperties.StorageAccountQueuePropertiesTimeoutsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.StorageAccountQueueProperties.IStorageAccountQueuePropertiesCorsRule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "corsRuleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageAccountQueueProperties.StorageAccountQueuePropertiesCorsRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CorsRuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hourMetricsInput", typeJson: "{\"fqn\":\"azurerm.storageAccountQueueProperties.StorageAccountQueuePropertiesHourMetrics\"}", isOptional: true)]
        public virtual azurerm.StorageAccountQueueProperties.IStorageAccountQueuePropertiesHourMetrics? HourMetricsInput
        {
            get => GetInstanceProperty<azurerm.StorageAccountQueueProperties.IStorageAccountQueuePropertiesHourMetrics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingInput", typeJson: "{\"fqn\":\"azurerm.storageAccountQueueProperties.StorageAccountQueuePropertiesLogging\"}", isOptional: true)]
        public virtual azurerm.StorageAccountQueueProperties.IStorageAccountQueuePropertiesLogging? LoggingInput
        {
            get => GetInstanceProperty<azurerm.StorageAccountQueueProperties.IStorageAccountQueuePropertiesLogging?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minuteMetricsInput", typeJson: "{\"fqn\":\"azurerm.storageAccountQueueProperties.StorageAccountQueuePropertiesMinuteMetrics\"}", isOptional: true)]
        public virtual azurerm.StorageAccountQueueProperties.IStorageAccountQueuePropertiesMinuteMetrics? MinuteMetricsInput
        {
            get => GetInstanceProperty<azurerm.StorageAccountQueueProperties.IStorageAccountQueuePropertiesMinuteMetrics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageAccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.StorageAccountQueueProperties.IStorageAccountQueuePropertiesTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.storageAccountQueueProperties.StorageAccountQueuePropertiesTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageAccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
