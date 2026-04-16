using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingServiceAction
{
    [JsiiClass(nativeType: typeof(stripe.V2BillingServiceAction.V2BillingServiceActionCreditGrantApplicabilityConfigOutputReference), fullyQualifiedName: "stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantApplicabilityConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class V2BillingServiceActionCreditGrantApplicabilityConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public V2BillingServiceActionCreditGrantApplicabilityConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected V2BillingServiceActionCreditGrantApplicabilityConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2BillingServiceActionCreditGrantApplicabilityConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putScope", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantApplicabilityConfigScope\"}}]")]
        public virtual void PutScope(stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantApplicabilityConfigScope @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantApplicabilityConfigScope)}, new object[]{@value});
        }

        [JsiiProperty(name: "scope", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantApplicabilityConfigScopeOutputReference\"}")]
        public virtual stripe.V2BillingServiceAction.V2BillingServiceActionCreditGrantApplicabilityConfigScopeOutputReference Scope
        {
            get => GetInstanceProperty<stripe.V2BillingServiceAction.V2BillingServiceActionCreditGrantApplicabilityConfigScopeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "scopeInput", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantApplicabilityConfigScope\"}", isOptional: true)]
        public virtual stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantApplicabilityConfigScope? ScopeInput
        {
            get => GetInstanceProperty<stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantApplicabilityConfigScope?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantApplicabilityConfig\"}", isOptional: true)]
        public virtual stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantApplicabilityConfig? InternalValue
        {
            get => GetInstanceProperty<stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantApplicabilityConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
