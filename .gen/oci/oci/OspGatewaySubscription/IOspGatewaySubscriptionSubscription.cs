using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OspGatewaySubscription
{
    [JsiiInterface(nativeType: typeof(IOspGatewaySubscriptionSubscription), fullyQualifiedName: "oci.ospGatewaySubscription.OspGatewaySubscriptionSubscription")]
    public interface IOspGatewaySubscriptionSubscription
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#subscription_plan_number OspGatewaySubscription#subscription_plan_number}.</summary>
        [JsiiProperty(name: "subscriptionPlanNumber", typeJson: "{\"primitive\":\"string\"}")]
        string SubscriptionPlanNumber
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#account_type OspGatewaySubscription#account_type}.</summary>
        [JsiiProperty(name: "accountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountType
        {
            get
            {
                return null;
            }
        }

        /// <summary>billing_address block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#billing_address OspGatewaySubscription#billing_address}
        /// </remarks>
        [JsiiProperty(name: "billingAddress", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionBillingAddress\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BillingAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#bill_to_cust_account_id OspGatewaySubscription#bill_to_cust_account_id}.</summary>
        [JsiiProperty(name: "billToCustAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BillToCustAccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#currency_code OspGatewaySubscription#currency_code}.</summary>
        [JsiiProperty(name: "currencyCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CurrencyCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#gsi_org_code OspGatewaySubscription#gsi_org_code}.</summary>
        [JsiiProperty(name: "gsiOrgCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GsiOrgCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#id OspGatewaySubscription#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#is_corporate_conversion_allowed OspGatewaySubscription#is_corporate_conversion_allowed}.</summary>
        [JsiiProperty(name: "isCorporateConversionAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsCorporateConversionAllowed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#is_intent_to_pay OspGatewaySubscription#is_intent_to_pay}.</summary>
        [JsiiProperty(name: "isIntentToPay", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsIntentToPay
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#language_code OspGatewaySubscription#language_code}.</summary>
        [JsiiProperty(name: "languageCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LanguageCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#organization_id OspGatewaySubscription#organization_id}.</summary>
        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OrganizationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>payment_gateway block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#payment_gateway OspGatewaySubscription#payment_gateway}
        /// </remarks>
        [JsiiProperty(name: "paymentGateway", typeJson: "{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentGateway\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionPaymentGateway? PaymentGateway
        {
            get
            {
                return null;
            }
        }

        /// <summary>payment_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#payment_options OspGatewaySubscription#payment_options}
        /// </remarks>
        [JsiiProperty(name: "paymentOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PaymentOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#plan_type OspGatewaySubscription#plan_type}.</summary>
        [JsiiProperty(name: "planType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlanType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#ship_to_cust_acct_role_id OspGatewaySubscription#ship_to_cust_acct_role_id}.</summary>
        [JsiiProperty(name: "shipToCustAcctRoleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ShipToCustAcctRoleId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#ship_to_cust_acct_site_id OspGatewaySubscription#ship_to_cust_acct_site_id}.</summary>
        [JsiiProperty(name: "shipToCustAcctSiteId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ShipToCustAcctSiteId
        {
            get
            {
                return null;
            }
        }

        /// <summary>tax_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#tax_info OspGatewaySubscription#tax_info}
        /// </remarks>
        [JsiiProperty(name: "taxInfo", typeJson: "{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionTaxInfo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionTaxInfo? TaxInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#time_personal_to_corporate_conv OspGatewaySubscription#time_personal_to_corporate_conv}.</summary>
        [JsiiProperty(name: "timePersonalToCorporateConv", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimePersonalToCorporateConv
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#time_plan_upgrade OspGatewaySubscription#time_plan_upgrade}.</summary>
        [JsiiProperty(name: "timePlanUpgrade", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimePlanUpgrade
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#time_start OspGatewaySubscription#time_start}.</summary>
        [JsiiProperty(name: "timeStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeStart
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#upgrade_state OspGatewaySubscription#upgrade_state}.</summary>
        [JsiiProperty(name: "upgradeState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UpgradeState
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#upgrade_state_details OspGatewaySubscription#upgrade_state_details}.</summary>
        [JsiiProperty(name: "upgradeStateDetails", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UpgradeStateDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOspGatewaySubscriptionSubscription), fullyQualifiedName: "oci.ospGatewaySubscription.OspGatewaySubscriptionSubscription")]
        internal sealed class _Proxy : DeputyBase, oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscription
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#subscription_plan_number OspGatewaySubscription#subscription_plan_number}.</summary>
            [JsiiProperty(name: "subscriptionPlanNumber", typeJson: "{\"primitive\":\"string\"}")]
            public string SubscriptionPlanNumber
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#account_type OspGatewaySubscription#account_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>billing_address block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#billing_address OspGatewaySubscription#billing_address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "billingAddress", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionBillingAddress\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BillingAddress
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#bill_to_cust_account_id OspGatewaySubscription#bill_to_cust_account_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "billToCustAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BillToCustAccountId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#currency_code OspGatewaySubscription#currency_code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "currencyCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CurrencyCode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#gsi_org_code OspGatewaySubscription#gsi_org_code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gsiOrgCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GsiOrgCode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#id OspGatewaySubscription#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#is_corporate_conversion_allowed OspGatewaySubscription#is_corporate_conversion_allowed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isCorporateConversionAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsCorporateConversionAllowed
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#is_intent_to_pay OspGatewaySubscription#is_intent_to_pay}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isIntentToPay", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsIntentToPay
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#language_code OspGatewaySubscription#language_code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "languageCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LanguageCode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#organization_id OspGatewaySubscription#organization_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrganizationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>payment_gateway block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#payment_gateway OspGatewaySubscription#payment_gateway}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paymentGateway", typeJson: "{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentGateway\"}", isOptional: true)]
            public oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionPaymentGateway? PaymentGateway
            {
                get => GetInstanceProperty<oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionPaymentGateway?>();
            }

            /// <summary>payment_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#payment_options OspGatewaySubscription#payment_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paymentOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PaymentOptions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#plan_type OspGatewaySubscription#plan_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "planType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlanType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#ship_to_cust_acct_role_id OspGatewaySubscription#ship_to_cust_acct_role_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shipToCustAcctRoleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ShipToCustAcctRoleId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#ship_to_cust_acct_site_id OspGatewaySubscription#ship_to_cust_acct_site_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shipToCustAcctSiteId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ShipToCustAcctSiteId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>tax_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#tax_info OspGatewaySubscription#tax_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "taxInfo", typeJson: "{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionTaxInfo\"}", isOptional: true)]
            public oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionTaxInfo? TaxInfo
            {
                get => GetInstanceProperty<oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionTaxInfo?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#time_personal_to_corporate_conv OspGatewaySubscription#time_personal_to_corporate_conv}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timePersonalToCorporateConv", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimePersonalToCorporateConv
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#time_plan_upgrade OspGatewaySubscription#time_plan_upgrade}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timePlanUpgrade", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimePlanUpgrade
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#time_start OspGatewaySubscription#time_start}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeStart
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#upgrade_state OspGatewaySubscription#upgrade_state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "upgradeState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UpgradeState
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#upgrade_state_details OspGatewaySubscription#upgrade_state_details}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "upgradeStateDetails", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UpgradeStateDetails
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
