using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OspGatewaySubscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.ospGatewaySubscription.OspGatewaySubscriptionSubscription")]
    public class OspGatewaySubscriptionSubscription : oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscription
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#subscription_plan_number OspGatewaySubscription#subscription_plan_number}.</summary>
        [JsiiProperty(name: "subscriptionPlanNumber", typeJson: "{\"primitive\":\"string\"}")]
        public string SubscriptionPlanNumber
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#account_type OspGatewaySubscription#account_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountType
        {
            get;
            set;
        }

        private object? _billingAddress;

        /// <summary>billing_address block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#billing_address OspGatewaySubscription#billing_address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billingAddress", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionBillingAddress\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BillingAddress
        {
            get => _billingAddress;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionBillingAddress[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionBillingAddress).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _billingAddress = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#bill_to_cust_account_id OspGatewaySubscription#bill_to_cust_account_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "billToCustAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BillToCustAccountId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#currency_code OspGatewaySubscription#currency_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "currencyCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CurrencyCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#gsi_org_code OspGatewaySubscription#gsi_org_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gsiOrgCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GsiOrgCode
        {
            get;
            set;
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
            get;
            set;
        }

        private object? _isCorporateConversionAllowed;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#is_corporate_conversion_allowed OspGatewaySubscription#is_corporate_conversion_allowed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isCorporateConversionAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsCorporateConversionAllowed
        {
            get => _isCorporateConversionAllowed;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isCorporateConversionAllowed = value;
            }
        }

        private object? _isIntentToPay;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#is_intent_to_pay OspGatewaySubscription#is_intent_to_pay}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isIntentToPay", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsIntentToPay
        {
            get => _isIntentToPay;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isIntentToPay = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#language_code OspGatewaySubscription#language_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "languageCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LanguageCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#organization_id OspGatewaySubscription#organization_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OrganizationId
        {
            get;
            set;
        }

        /// <summary>payment_gateway block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#payment_gateway OspGatewaySubscription#payment_gateway}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentGateway", typeJson: "{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentGateway\"}", isOptional: true)]
        public oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionPaymentGateway? PaymentGateway
        {
            get;
            set;
        }

        private object? _paymentOptions;

        /// <summary>payment_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#payment_options OspGatewaySubscription#payment_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PaymentOptions
        {
            get => _paymentOptions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionPaymentOptions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionPaymentOptions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _paymentOptions = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#plan_type OspGatewaySubscription#plan_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "planType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PlanType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#ship_to_cust_acct_role_id OspGatewaySubscription#ship_to_cust_acct_role_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shipToCustAcctRoleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ShipToCustAcctRoleId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#ship_to_cust_acct_site_id OspGatewaySubscription#ship_to_cust_acct_site_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shipToCustAcctSiteId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ShipToCustAcctSiteId
        {
            get;
            set;
        }

        /// <summary>tax_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#tax_info OspGatewaySubscription#tax_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "taxInfo", typeJson: "{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionTaxInfo\"}", isOptional: true)]
        public oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionTaxInfo? TaxInfo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#time_personal_to_corporate_conv OspGatewaySubscription#time_personal_to_corporate_conv}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timePersonalToCorporateConv", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimePersonalToCorporateConv
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#time_plan_upgrade OspGatewaySubscription#time_plan_upgrade}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timePlanUpgrade", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimePlanUpgrade
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#time_start OspGatewaySubscription#time_start}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeStart
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#upgrade_state OspGatewaySubscription#upgrade_state}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "upgradeState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpgradeState
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#upgrade_state_details OspGatewaySubscription#upgrade_state_details}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "upgradeStateDetails", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpgradeStateDetails
        {
            get;
            set;
        }
    }
}
