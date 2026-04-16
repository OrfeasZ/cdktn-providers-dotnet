using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SavingsplansSavingsPlan
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/savingsplans_savings_plan aws_savingsplans_savings_plan}.</summary>
    [JsiiClass(nativeType: typeof(aws.SavingsplansSavingsPlan.SavingsplansSavingsPlan), fullyQualifiedName: "aws.savingsplansSavingsPlan.SavingsplansSavingsPlan", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.savingsplansSavingsPlan.SavingsplansSavingsPlanConfig\"}}]")]
    public class SavingsplansSavingsPlan : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/savingsplans_savings_plan aws_savingsplans_savings_plan} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SavingsplansSavingsPlan(Constructs.Construct scope, string id, aws.SavingsplansSavingsPlan.ISavingsplansSavingsPlanConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.SavingsplansSavingsPlan.ISavingsplansSavingsPlanConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SavingsplansSavingsPlan(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SavingsplansSavingsPlan(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a SavingsplansSavingsPlan resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SavingsplansSavingsPlan to import.</param>
        /// <param name="importFromId">The id of the existing SavingsplansSavingsPlan that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SavingsplansSavingsPlan to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SavingsplansSavingsPlan to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/savingsplans_savings_plan#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SavingsplansSavingsPlan that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SavingsplansSavingsPlan to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.SavingsplansSavingsPlan.SavingsplansSavingsPlan), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.savingsplansSavingsPlan.SavingsplansSavingsPlanTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.SavingsplansSavingsPlan.ISavingsplansSavingsPlanTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SavingsplansSavingsPlan.ISavingsplansSavingsPlanTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPurchaseTime")]
        public virtual void ResetPurchaseTime()
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

        [JsiiMethod(name: "resetUpfrontPaymentAmount")]
        public virtual void ResetUpfrontPaymentAmount()
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
        = GetStaticProperty<string>(typeof(aws.SavingsplansSavingsPlan.SavingsplansSavingsPlan))!;

        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Currency
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ec2InstanceFamily", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ec2InstanceFamily
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string End
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "offeringId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OfferingId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "paymentOption", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentOption
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "productTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ProductTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "recurringPaymentAmount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecurringPaymentAmount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "returnableUntil", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReturnableUntil
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "savingsPlanArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SavingsPlanArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "savingsPlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SavingsPlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "savingsPlanType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SavingsPlanType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Start
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap TagsAll
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "termDurationInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TermDurationInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.savingsplansSavingsPlan.SavingsplansSavingsPlanTimeoutsOutputReference\"}")]
        public virtual aws.SavingsplansSavingsPlan.SavingsplansSavingsPlanTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.SavingsplansSavingsPlan.SavingsplansSavingsPlanTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "commitmentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CommitmentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "purchaseTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PurchaseTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "savingsPlanOfferingIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SavingsPlanOfferingIdInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.savingsplansSavingsPlan.SavingsplansSavingsPlanTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "upfrontPaymentAmountInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UpfrontPaymentAmountInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "commitment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Commitment
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "purchaseTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PurchaseTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "savingsPlanOfferingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SavingsPlanOfferingId
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

        [JsiiProperty(name: "upfrontPaymentAmount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpfrontPaymentAmount
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
