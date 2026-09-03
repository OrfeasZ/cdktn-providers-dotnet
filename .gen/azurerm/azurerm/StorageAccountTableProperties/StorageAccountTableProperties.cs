using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccountTableProperties
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_account_table_properties azurerm_storage_account_table_properties}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.StorageAccountTableProperties.StorageAccountTableProperties), fullyQualifiedName: "azurerm.storageAccountTableProperties.StorageAccountTableProperties", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.storageAccountTableProperties.StorageAccountTablePropertiesConfig\"}}]")]
    public class StorageAccountTableProperties : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_account_table_properties azurerm_storage_account_table_properties} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public StorageAccountTableProperties(Constructs.Construct scope, string id, azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageAccountTableProperties(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageAccountTableProperties(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a StorageAccountTableProperties resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the StorageAccountTableProperties to import.</param>
        /// <param name="importFromId">The id of the existing StorageAccountTableProperties that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the StorageAccountTableProperties to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the StorageAccountTableProperties to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_account_table_properties#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing StorageAccountTableProperties that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the StorageAccountTableProperties to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.StorageAccountTableProperties.StorageAccountTableProperties), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesCorsRule" />)[]</param>
        [JsiiMethod(name: "putCorsRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageAccountTableProperties.StorageAccountTablePropertiesCorsRule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCorsRule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesCorsRule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesCorsRule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesCorsRule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHourMetrics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccountTableProperties.StorageAccountTablePropertiesHourMetrics\"}}]")]
        public virtual void PutHourMetrics(azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesHourMetrics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesHourMetrics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogging", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccountTableProperties.StorageAccountTablePropertiesLogging\"}}]")]
        public virtual void PutLogging(azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesLogging @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesLogging)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMinuteMetrics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccountTableProperties.StorageAccountTablePropertiesMinuteMetrics\"}}]")]
        public virtual void PutMinuteMetrics(azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesMinuteMetrics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesMinuteMetrics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccountTableProperties.StorageAccountTablePropertiesTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.StorageAccountTableProperties.StorageAccountTableProperties))!;

        [JsiiProperty(name: "corsRule", typeJson: "{\"fqn\":\"azurerm.storageAccountTableProperties.StorageAccountTablePropertiesCorsRuleList\"}")]
        public virtual azurerm.StorageAccountTableProperties.StorageAccountTablePropertiesCorsRuleList CorsRule
        {
            get => GetInstanceProperty<azurerm.StorageAccountTableProperties.StorageAccountTablePropertiesCorsRuleList>()!;
        }

        [JsiiProperty(name: "hourMetrics", typeJson: "{\"fqn\":\"azurerm.storageAccountTableProperties.StorageAccountTablePropertiesHourMetricsOutputReference\"}")]
        public virtual azurerm.StorageAccountTableProperties.StorageAccountTablePropertiesHourMetricsOutputReference HourMetrics
        {
            get => GetInstanceProperty<azurerm.StorageAccountTableProperties.StorageAccountTablePropertiesHourMetricsOutputReference>()!;
        }

        [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"azurerm.storageAccountTableProperties.StorageAccountTablePropertiesLoggingOutputReference\"}")]
        public virtual azurerm.StorageAccountTableProperties.StorageAccountTablePropertiesLoggingOutputReference Logging
        {
            get => GetInstanceProperty<azurerm.StorageAccountTableProperties.StorageAccountTablePropertiesLoggingOutputReference>()!;
        }

        [JsiiProperty(name: "minuteMetrics", typeJson: "{\"fqn\":\"azurerm.storageAccountTableProperties.StorageAccountTablePropertiesMinuteMetricsOutputReference\"}")]
        public virtual azurerm.StorageAccountTableProperties.StorageAccountTablePropertiesMinuteMetricsOutputReference MinuteMetrics
        {
            get => GetInstanceProperty<azurerm.StorageAccountTableProperties.StorageAccountTablePropertiesMinuteMetricsOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.storageAccountTableProperties.StorageAccountTablePropertiesTimeoutsOutputReference\"}")]
        public virtual azurerm.StorageAccountTableProperties.StorageAccountTablePropertiesTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.StorageAccountTableProperties.StorageAccountTablePropertiesTimeoutsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesCorsRule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "corsRuleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageAccountTableProperties.StorageAccountTablePropertiesCorsRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CorsRuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hourMetricsInput", typeJson: "{\"fqn\":\"azurerm.storageAccountTableProperties.StorageAccountTablePropertiesHourMetrics\"}", isOptional: true)]
        public virtual azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesHourMetrics? HourMetricsInput
        {
            get => GetInstanceProperty<azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesHourMetrics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingInput", typeJson: "{\"fqn\":\"azurerm.storageAccountTableProperties.StorageAccountTablePropertiesLogging\"}", isOptional: true)]
        public virtual azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesLogging? LoggingInput
        {
            get => GetInstanceProperty<azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesLogging?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minuteMetricsInput", typeJson: "{\"fqn\":\"azurerm.storageAccountTableProperties.StorageAccountTablePropertiesMinuteMetrics\"}", isOptional: true)]
        public virtual azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesMinuteMetrics? MinuteMetricsInput
        {
            get => GetInstanceProperty<azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesMinuteMetrics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageAccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.storageAccountTableProperties.StorageAccountTablePropertiesTimeouts\"}]}}", isOptional: true)]
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
