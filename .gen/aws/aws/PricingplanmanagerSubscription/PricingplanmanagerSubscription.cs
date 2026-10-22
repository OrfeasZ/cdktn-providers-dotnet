using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PricingplanmanagerSubscription
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/pricingplanmanager_subscription aws_pricingplanmanager_subscription}.</summary>
    [JsiiClass(nativeType: typeof(aws.PricingplanmanagerSubscription.PricingplanmanagerSubscription), fullyQualifiedName: "aws.pricingplanmanagerSubscription.PricingplanmanagerSubscription", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.pricingplanmanagerSubscription.PricingplanmanagerSubscriptionConfig\"}}]")]
    public class PricingplanmanagerSubscription : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/pricingplanmanager_subscription aws_pricingplanmanager_subscription} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public PricingplanmanagerSubscription(Constructs.Construct scope, string id, aws.PricingplanmanagerSubscription.IPricingplanmanagerSubscriptionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.PricingplanmanagerSubscription.IPricingplanmanagerSubscriptionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PricingplanmanagerSubscription(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PricingplanmanagerSubscription(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a PricingplanmanagerSubscription resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the PricingplanmanagerSubscription to import.</param>
        /// <param name="importFromId">The id of the existing PricingplanmanagerSubscription that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the PricingplanmanagerSubscription to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the PricingplanmanagerSubscription to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/pricingplanmanager_subscription#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing PricingplanmanagerSubscription that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the PricingplanmanagerSubscription to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.PricingplanmanagerSubscription.PricingplanmanagerSubscription), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pricingplanmanagerSubscription.PricingplanmanagerSubscriptionTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.PricingplanmanagerSubscription.IPricingplanmanagerSubscriptionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PricingplanmanagerSubscription.IPricingplanmanagerSubscriptionTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApprovalMode")]
        public virtual void ResetApprovalMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsageLevel")]
        public virtual void ResetUsageLevel()
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
        = GetStaticProperty<string>(typeof(aws.PricingplanmanagerSubscription.PricingplanmanagerSubscription))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "etag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Etag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledChange", typeJson: "{\"fqn\":\"aws.pricingplanmanagerSubscription.PricingplanmanagerSubscriptionScheduledChangeList\"}")]
        public virtual aws.PricingplanmanagerSubscription.PricingplanmanagerSubscriptionScheduledChangeList ScheduledChange
        {
            get => GetInstanceProperty<aws.PricingplanmanagerSubscription.PricingplanmanagerSubscriptionScheduledChangeList>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatusReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.pricingplanmanagerSubscription.PricingplanmanagerSubscriptionTimeoutsOutputReference\"}")]
        public virtual aws.PricingplanmanagerSubscription.PricingplanmanagerSubscriptionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.PricingplanmanagerSubscription.PricingplanmanagerSubscriptionTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "approvalModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApprovalModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "planFamilyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlanFamilyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "planTierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlanTierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceArnsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ResourceArnsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.PricingplanmanagerSubscription.IPricingplanmanagerSubscriptionTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.pricingplanmanagerSubscription.PricingplanmanagerSubscriptionTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usageLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsageLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "approvalMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApprovalMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "planFamily", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlanFamily
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "planTier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlanTier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ResourceArns
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "usageLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
