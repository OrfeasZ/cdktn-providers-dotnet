using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementFinancialAddress
{
    [JsiiClass(nativeType: typeof(stripe.V2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccountOutputReference), fullyQualifiedName: "stripe.v2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccountOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class V2MoneyManagementFinancialAddressBankAccountOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public V2MoneyManagementFinancialAddressBankAccountOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected V2MoneyManagementFinancialAddressBankAccountOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2MoneyManagementFinancialAddressBankAccountOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCountry")]
        public virtual void ResetCountry()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "aba", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccountAbaOutputReference\"}")]
        public virtual stripe.V2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccountAbaOutputReference Aba
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccountAbaOutputReference>()!;
        }

        [JsiiProperty(name: "iban", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccountIbanOutputReference\"}")]
        public virtual stripe.V2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccountIbanOutputReference Iban
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccountIbanOutputReference>()!;
        }

        [JsiiProperty(name: "sortCode", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccountSortCodeOutputReference\"}")]
        public virtual stripe.V2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccountSortCodeOutputReference SortCode
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccountSortCodeOutputReference>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "countryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CountryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "currencyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CurrencyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Country
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Currency
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.V2MoneyManagementFinancialAddress.IV2MoneyManagementFinancialAddressBankAccount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.v2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccount\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.V2MoneyManagementFinancialAddress.IV2MoneyManagementFinancialAddressBankAccount cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.V2MoneyManagementFinancialAddress.IV2MoneyManagementFinancialAddressBankAccount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
