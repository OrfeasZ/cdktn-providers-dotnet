using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    [JsiiClass(nativeType: typeof(stripe.Customer.CustomerCashBalanceOutputReference), fullyQualifiedName: "stripe.customer.CustomerCashBalanceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CustomerCashBalanceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CustomerCashBalanceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CustomerCashBalanceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CustomerCashBalanceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.customer.CustomerCashBalanceSettings\"}}]")]
        public virtual void PutSettings(stripe.Customer.ICustomerCashBalanceSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Customer.ICustomerCashBalanceSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSettings")]
        public virtual void ResetSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "available", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Available
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "customer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Customer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerAccount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerAccount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"stripe.customer.CustomerCashBalanceSettingsOutputReference\"}")]
        public virtual stripe.Customer.CustomerCashBalanceSettingsOutputReference Settings
        {
            get => GetInstanceProperty<stripe.Customer.CustomerCashBalanceSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "settingsInput", typeJson: "{\"fqn\":\"stripe.customer.CustomerCashBalanceSettings\"}", isOptional: true)]
        public virtual stripe.Customer.ICustomerCashBalanceSettings? SettingsInput
        {
            get => GetInstanceProperty<stripe.Customer.ICustomerCashBalanceSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.customer.CustomerCashBalance\"}", isOptional: true)]
        public virtual stripe.Customer.ICustomerCashBalance? InternalValue
        {
            get => GetInstanceProperty<stripe.Customer.ICustomerCashBalance?>();
            set => SetInstanceProperty(value);
        }
    }
}
