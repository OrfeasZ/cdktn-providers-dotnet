using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementFinancialAddress
{
    [JsiiClass(nativeType: typeof(stripe.V2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccountAbaAddressOutputReference), fullyQualifiedName: "stripe.v2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccountAbaAddressOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class V2MoneyManagementFinancialAddressBankAccountAbaAddressOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public V2MoneyManagementFinancialAddressBankAccountAbaAddressOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected V2MoneyManagementFinancialAddressBankAccountAbaAddressOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2MoneyManagementFinancialAddressBankAccountAbaAddressOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string City
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Country
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "line1", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Line1
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "line2", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Line2
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "postalCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PostalCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "town", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Town
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccountAbaAddress\"}", isOptional: true)]
        public virtual stripe.V2MoneyManagementFinancialAddress.IV2MoneyManagementFinancialAddressBankAccountAbaAddress? InternalValue
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementFinancialAddress.IV2MoneyManagementFinancialAddressBankAccountAbaAddress?>();
            set => SetInstanceProperty(value);
        }
    }
}
