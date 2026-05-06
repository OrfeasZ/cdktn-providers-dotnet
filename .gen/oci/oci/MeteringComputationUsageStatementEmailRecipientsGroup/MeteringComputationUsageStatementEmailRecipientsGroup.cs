using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationUsageStatementEmailRecipientsGroup
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_statement_email_recipients_group oci_metering_computation_usage_statement_email_recipients_group}.</summary>
    [JsiiClass(nativeType: typeof(oci.MeteringComputationUsageStatementEmailRecipientsGroup.MeteringComputationUsageStatementEmailRecipientsGroup), fullyQualifiedName: "oci.meteringComputationUsageStatementEmailRecipientsGroup.MeteringComputationUsageStatementEmailRecipientsGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.meteringComputationUsageStatementEmailRecipientsGroup.MeteringComputationUsageStatementEmailRecipientsGroupConfig\"}}]")]
    public class MeteringComputationUsageStatementEmailRecipientsGroup : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_statement_email_recipients_group oci_metering_computation_usage_statement_email_recipients_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MeteringComputationUsageStatementEmailRecipientsGroup(Constructs.Construct scope, string id, oci.MeteringComputationUsageStatementEmailRecipientsGroup.IMeteringComputationUsageStatementEmailRecipientsGroupConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.MeteringComputationUsageStatementEmailRecipientsGroup.IMeteringComputationUsageStatementEmailRecipientsGroupConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MeteringComputationUsageStatementEmailRecipientsGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MeteringComputationUsageStatementEmailRecipientsGroup(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a MeteringComputationUsageStatementEmailRecipientsGroup resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MeteringComputationUsageStatementEmailRecipientsGroup to import.</param>
        /// <param name="importFromId">The id of the existing MeteringComputationUsageStatementEmailRecipientsGroup that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MeteringComputationUsageStatementEmailRecipientsGroup to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MeteringComputationUsageStatementEmailRecipientsGroup to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_statement_email_recipients_group#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MeteringComputationUsageStatementEmailRecipientsGroup that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MeteringComputationUsageStatementEmailRecipientsGroup to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.MeteringComputationUsageStatementEmailRecipientsGroup.MeteringComputationUsageStatementEmailRecipientsGroup), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putRecipientsList", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.meteringComputationUsageStatementEmailRecipientsGroup.MeteringComputationUsageStatementEmailRecipientsGroupRecipientsListStruct\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRecipientsList(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.MeteringComputationUsageStatementEmailRecipientsGroup.IMeteringComputationUsageStatementEmailRecipientsGroupRecipientsListStruct[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MeteringComputationUsageStatementEmailRecipientsGroup.IMeteringComputationUsageStatementEmailRecipientsGroupRecipientsListStruct).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MeteringComputationUsageStatementEmailRecipientsGroup.IMeteringComputationUsageStatementEmailRecipientsGroupRecipientsListStruct).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.meteringComputationUsageStatementEmailRecipientsGroup.MeteringComputationUsageStatementEmailRecipientsGroupTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.MeteringComputationUsageStatementEmailRecipientsGroup.IMeteringComputationUsageStatementEmailRecipientsGroupTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.MeteringComputationUsageStatementEmailRecipientsGroup.IMeteringComputationUsageStatementEmailRecipientsGroupTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEmailRecipientsGroupId")]
        public virtual void ResetEmailRecipientsGroupId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(oci.MeteringComputationUsageStatementEmailRecipientsGroup.MeteringComputationUsageStatementEmailRecipientsGroup))!;

        [JsiiProperty(name: "recipientsList", typeJson: "{\"fqn\":\"oci.meteringComputationUsageStatementEmailRecipientsGroup.MeteringComputationUsageStatementEmailRecipientsGroupRecipientsListStructList\"}")]
        public virtual oci.MeteringComputationUsageStatementEmailRecipientsGroup.MeteringComputationUsageStatementEmailRecipientsGroupRecipientsListStructList RecipientsList
        {
            get => GetInstanceProperty<oci.MeteringComputationUsageStatementEmailRecipientsGroup.MeteringComputationUsageStatementEmailRecipientsGroupRecipientsListStructList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.meteringComputationUsageStatementEmailRecipientsGroup.MeteringComputationUsageStatementEmailRecipientsGroupTimeoutsOutputReference\"}")]
        public virtual oci.MeteringComputationUsageStatementEmailRecipientsGroup.MeteringComputationUsageStatementEmailRecipientsGroupTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.MeteringComputationUsageStatementEmailRecipientsGroup.MeteringComputationUsageStatementEmailRecipientsGroupTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailRecipientsGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailRecipientsGroupIdInput
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
        [JsiiProperty(name: "recipientsListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.meteringComputationUsageStatementEmailRecipientsGroup.MeteringComputationUsageStatementEmailRecipientsGroupRecipientsListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RecipientsListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subscriptionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubscriptionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.meteringComputationUsageStatementEmailRecipientsGroup.MeteringComputationUsageStatementEmailRecipientsGroupTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "emailRecipientsGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailRecipientsGroupId
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

        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
