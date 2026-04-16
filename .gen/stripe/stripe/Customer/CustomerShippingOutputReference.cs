using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    [JsiiClass(nativeType: typeof(stripe.Customer.CustomerShippingOutputReference), fullyQualifiedName: "stripe.customer.CustomerShippingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CustomerShippingOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CustomerShippingOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CustomerShippingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CustomerShippingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.customer.CustomerShippingAddress\"}}]")]
        public virtual void PutAddress(stripe.Customer.ICustomerShippingAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Customer.ICustomerShippingAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPhone")]
        public virtual void ResetPhone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.customer.CustomerShippingAddressOutputReference\"}")]
        public virtual stripe.Customer.CustomerShippingAddressOutputReference Address
        {
            get => GetInstanceProperty<stripe.Customer.CustomerShippingAddressOutputReference>()!;
        }

        [JsiiProperty(name: "carrier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Carrier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "trackingNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrackingNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "addressInput", typeJson: "{\"fqn\":\"stripe.customer.CustomerShippingAddress\"}", isOptional: true)]
        public virtual stripe.Customer.ICustomerShippingAddress? AddressInput
        {
            get => GetInstanceProperty<stripe.Customer.ICustomerShippingAddress?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "phoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PhoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "phone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Phone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.customer.CustomerShipping\"}", isOptional: true)]
        public virtual stripe.Customer.ICustomerShipping? InternalValue
        {
            get => GetInstanceProperty<stripe.Customer.ICustomerShipping?>();
            set => SetInstanceProperty(value);
        }
    }
}
