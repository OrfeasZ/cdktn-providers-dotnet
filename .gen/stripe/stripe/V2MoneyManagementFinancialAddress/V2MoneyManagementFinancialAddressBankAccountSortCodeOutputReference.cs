using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementFinancialAddress
{
    [JsiiClass(nativeType: typeof(stripe.V2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccountSortCodeOutputReference), fullyQualifiedName: "stripe.v2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccountSortCodeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class V2MoneyManagementFinancialAddressBankAccountSortCodeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public V2MoneyManagementFinancialAddressBankAccountSortCodeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected V2MoneyManagementFinancialAddressBankAccountSortCodeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2MoneyManagementFinancialAddressBankAccountSortCodeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accountHolderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountHolderName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sortCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SortCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccountSortCode\"}", isOptional: true)]
        public virtual stripe.V2MoneyManagementFinancialAddress.IV2MoneyManagementFinancialAddressBankAccountSortCode? InternalValue
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementFinancialAddress.IV2MoneyManagementFinancialAddressBankAccountSortCode?>();
            set => SetInstanceProperty(value);
        }
    }
}
