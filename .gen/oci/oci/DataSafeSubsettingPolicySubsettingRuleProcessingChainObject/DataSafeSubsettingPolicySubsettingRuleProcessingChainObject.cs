using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_rule_processing_chain_object oci_data_safe_subsetting_policy_subsetting_rule_processing_chain_object}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject), fullyQualifiedName: "oci.dataSafeSubsettingPolicySubsettingRuleProcessingChainObject.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataSafeSubsettingPolicySubsettingRuleProcessingChainObject.DataSafeSubsettingPolicySubsettingRuleProcessingChainObjectConfig\"}}]")]
    public class DataSafeSubsettingPolicySubsettingRuleProcessingChainObject : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_rule_processing_chain_object oci_data_safe_subsetting_policy_subsetting_rule_processing_chain_object} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataSafeSubsettingPolicySubsettingRuleProcessingChainObject(Constructs.Construct scope, string id, oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject.IDataSafeSubsettingPolicySubsettingRuleProcessingChainObjectConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject.IDataSafeSubsettingPolicySubsettingRuleProcessingChainObjectConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeSubsettingPolicySubsettingRuleProcessingChainObject(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeSubsettingPolicySubsettingRuleProcessingChainObject(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataSafeSubsettingPolicySubsettingRuleProcessingChainObject resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataSafeSubsettingPolicySubsettingRuleProcessingChainObject to import.</param>
        /// <param name="importFromId">The id of the existing DataSafeSubsettingPolicySubsettingRuleProcessingChainObject that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataSafeSubsettingPolicySubsettingRuleProcessingChainObject to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataSafeSubsettingPolicySubsettingRuleProcessingChainObject to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_rule_processing_chain_object#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataSafeSubsettingPolicySubsettingRuleProcessingChainObject that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataSafeSubsettingPolicySubsettingRuleProcessingChainObject to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataSafeSubsettingPolicySubsettingRuleProcessingChainObject.DataSafeSubsettingPolicySubsettingRuleProcessingChainObjectTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject.IDataSafeSubsettingPolicySubsettingRuleProcessingChainObjectTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject.IDataSafeSubsettingPolicySubsettingRuleProcessingChainObjectTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject))!;

        [JsiiProperty(name: "items", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingPolicySubsettingRuleProcessingChainObject.DataSafeSubsettingPolicySubsettingRuleProcessingChainObjectItemsList\"}")]
        public virtual oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject.DataSafeSubsettingPolicySubsettingRuleProcessingChainObjectItemsList Items
        {
            get => GetInstanceProperty<oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject.DataSafeSubsettingPolicySubsettingRuleProcessingChainObjectItemsList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingPolicySubsettingRuleProcessingChainObject.DataSafeSubsettingPolicySubsettingRuleProcessingChainObjectTimeoutsOutputReference\"}")]
        public virtual oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject.DataSafeSubsettingPolicySubsettingRuleProcessingChainObjectTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject.DataSafeSubsettingPolicySubsettingRuleProcessingChainObjectTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isEnabledForProcessingInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsEnabledForProcessingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "processingChainObjectKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProcessingChainObjectKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subsettingPolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubsettingPolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subsettingRuleKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubsettingRuleKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DataSafeSubsettingPolicySubsettingRuleProcessingChainObject.IDataSafeSubsettingPolicySubsettingRuleProcessingChainObjectTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.dataSafeSubsettingPolicySubsettingRuleProcessingChainObject.DataSafeSubsettingPolicySubsettingRuleProcessingChainObjectTimeouts\"}]}}", isOptional: true)]
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isEnabledForProcessing", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsEnabledForProcessing
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

        [JsiiProperty(name: "processingChainObjectKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProcessingChainObjectKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subsettingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubsettingPolicyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subsettingRuleKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubsettingRuleKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
