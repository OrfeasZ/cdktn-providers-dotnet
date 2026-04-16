using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingServiceAction
{
    [JsiiClass(nativeType: typeof(stripe.V2BillingServiceAction.V2BillingServiceActionCreditGrantOutputReference), fullyQualifiedName: "stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class V2BillingServiceActionCreditGrantOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public V2BillingServiceActionCreditGrantOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2BillingServiceActionCreditGrantOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2BillingServiceActionCreditGrantOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAmount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantAmount\"}}]")]
        public virtual void PutAmount(stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putApplicabilityConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantApplicabilityConfig\"}}]")]
        public virtual void PutApplicabilityConfig(stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantApplicabilityConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantApplicabilityConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExpiryConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantExpiryConfig\"}}]")]
        public virtual void PutExpiryConfig(stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantExpiryConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantExpiryConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCategory")]
        public virtual void ResetCategory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPriority")]
        public virtual void ResetPriority()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "amount", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantAmountOutputReference\"}")]
        public virtual stripe.V2BillingServiceAction.V2BillingServiceActionCreditGrantAmountOutputReference Amount
        {
            get => GetInstanceProperty<stripe.V2BillingServiceAction.V2BillingServiceActionCreditGrantAmountOutputReference>()!;
        }

        [JsiiProperty(name: "applicabilityConfig", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantApplicabilityConfigOutputReference\"}")]
        public virtual stripe.V2BillingServiceAction.V2BillingServiceActionCreditGrantApplicabilityConfigOutputReference ApplicabilityConfig
        {
            get => GetInstanceProperty<stripe.V2BillingServiceAction.V2BillingServiceActionCreditGrantApplicabilityConfigOutputReference>()!;
        }

        [JsiiProperty(name: "expiryConfig", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantExpiryConfigOutputReference\"}")]
        public virtual stripe.V2BillingServiceAction.V2BillingServiceActionCreditGrantExpiryConfigOutputReference ExpiryConfig
        {
            get => GetInstanceProperty<stripe.V2BillingServiceAction.V2BillingServiceActionCreditGrantExpiryConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "amountInput", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantAmount\"}", isOptional: true)]
        public virtual stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmount? AmountInput
        {
            get => GetInstanceProperty<stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmount?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicabilityConfigInput", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantApplicabilityConfig\"}", isOptional: true)]
        public virtual stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantApplicabilityConfig? ApplicabilityConfigInput
        {
            get => GetInstanceProperty<stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantApplicabilityConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "categoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CategoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expiryConfigInput", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantExpiryConfig\"}", isOptional: true)]
        public virtual stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantExpiryConfig? ExpiryConfigInput
        {
            get => GetInstanceProperty<stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantExpiryConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priorityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PriorityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Category
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

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrant\"}", isOptional: true)]
        public virtual stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrant? InternalValue
        {
            get => GetInstanceProperty<stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrant?>();
            set => SetInstanceProperty(value);
        }
    }
}
