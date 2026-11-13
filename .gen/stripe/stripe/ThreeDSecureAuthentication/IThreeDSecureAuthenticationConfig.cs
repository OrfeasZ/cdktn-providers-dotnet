using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    [JsiiInterface(nativeType: typeof(IThreeDSecureAuthenticationConfig), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationConfig")]
    public interface IThreeDSecureAuthenticationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Contains details on the channel used (browser, 3RI) for a standalone 3DS Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#channel ThreeDSecureAuthentication#channel}
        /// </remarks>
        [JsiiProperty(name: "channel", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannel\"}")]
        stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannel Channel
        {
            get;
        }

        /// <summary>Indicates whether this 3DS Authentication is being performed for a payment or non-payment use case.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#message_category ThreeDSecureAuthentication#message_category}
        /// </remarks>
        [JsiiProperty(name: "messageCategory", typeJson: "{\"primitive\":\"string\"}")]
        string MessageCategory
        {
            get;
        }

        /// <summary>Contains additional details about the acquirer for a 3DS Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#acquirer_details ThreeDSecureAuthentication#acquirer_details}
        /// </remarks>
        [JsiiProperty(name: "acquirerDetails", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationAcquirerDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationAcquirerDetails? AcquirerDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>The amount for this 3DS Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#amount ThreeDSecureAuthentication#amount}
        /// </remarks>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Amount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#currency ThreeDSecureAuthentication#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Currency
        {
            get
            {
                return null;
            }
        }

        /// <summary>The 3DS directory server with which this 3DS Authentication was processed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#directory_server ThreeDSecureAuthentication#directory_server}
        /// </remarks>
        [JsiiProperty(name: "directoryServer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DirectoryServer
        {
            get
            {
                return null;
            }
        }

        /// <summary>Contains details of the flow preference used for a standalone 3DS Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#flow_preference ThreeDSecureAuthentication#flow_preference}
        /// </remarks>
        [JsiiProperty(name: "flowPreference", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreference? FlowPreference
        {
            get
            {
                return null;
            }
        }

        /// <summary>Contains information about the future authorisations related to this authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#future_usage ThreeDSecureAuthentication#future_usage}
        /// </remarks>
        [JsiiProperty(name: "futureUsage", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFutureUsage\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFutureUsage? FutureUsage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#metadata ThreeDSecureAuthentication#metadata}
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the payment method (a PaymentMethod object) to attach to this 3DS Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#payment_method ThreeDSecureAuthentication#payment_method}
        /// </remarks>
        [JsiiProperty(name: "paymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PaymentMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Hash used to generate the PaymentMethod to be used for this Authentication.</summary>
        /// <remarks>
        /// This is mutually exclusive with the <c>payment_method</c> parameter.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#payment_method_data ThreeDSecureAuthentication#payment_method_data}
        /// </remarks>
        [JsiiProperty(name: "paymentMethodData", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodData\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodData? PaymentMethodData
        {
            get
            {
                return null;
            }
        }

        /// <summary>The reason for invoking this 3DS Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#reason ThreeDSecureAuthentication#reason}
        /// </remarks>
        [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Reason
        {
            get
            {
                return null;
            }
        }

        /// <summary>Contains details about the shipping address for a 3DS Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#shipping_address ThreeDSecureAuthentication#shipping_address}
        /// </remarks>
        [JsiiProperty(name: "shippingAddress", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationShippingAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationShippingAddress? ShippingAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set to `always` to skip the fingerprinting step and submit this Authentication immediately or `if_fingerprinting_not_supported` to submit this Authentication only if fingerprinting is not available.</summary>
        /// <remarks>
        /// This parameter defaults to <c>never</c>.
        ///
        /// Refer to the <a href="/payments/3d-secure/standalone-3d-secure#submit-at-creation">Submit at creation section of the standalone 3DS guide</a> for more information.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#submit ThreeDSecureAuthentication#submit}
        /// </remarks>
        [JsiiProperty(name: "submit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Submit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IThreeDSecureAuthenticationConfig), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Contains details on the channel used (browser, 3RI) for a standalone 3DS Authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#channel ThreeDSecureAuthentication#channel}
            /// </remarks>
            [JsiiProperty(name: "channel", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannel\"}")]
            public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannel Channel
            {
                get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannel>()!;
            }

            /// <summary>Indicates whether this 3DS Authentication is being performed for a payment or non-payment use case.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#message_category ThreeDSecureAuthentication#message_category}
            /// </remarks>
            [JsiiProperty(name: "messageCategory", typeJson: "{\"primitive\":\"string\"}")]
            public string MessageCategory
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Contains additional details about the acquirer for a 3DS Authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#acquirer_details ThreeDSecureAuthentication#acquirer_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acquirerDetails", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationAcquirerDetails\"}", isOptional: true)]
            public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationAcquirerDetails? AcquirerDetails
            {
                get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationAcquirerDetails?>();
            }

            /// <summary>The amount for this 3DS Authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#amount ThreeDSecureAuthentication#amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Amount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#currency ThreeDSecureAuthentication#currency}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Currency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The 3DS directory server with which this 3DS Authentication was processed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#directory_server ThreeDSecureAuthentication#directory_server}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "directoryServer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DirectoryServer
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Contains details of the flow preference used for a standalone 3DS Authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#flow_preference ThreeDSecureAuthentication#flow_preference}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "flowPreference", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreference\"}", isOptional: true)]
            public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreference? FlowPreference
            {
                get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreference?>();
            }

            /// <summary>Contains information about the future authorisations related to this authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#future_usage ThreeDSecureAuthentication#future_usage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "futureUsage", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFutureUsage\"}", isOptional: true)]
            public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFutureUsage? FutureUsage
            {
                get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFutureUsage?>();
            }

            /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#metadata ThreeDSecureAuthentication#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>ID of the payment method (a PaymentMethod object) to attach to this 3DS Authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#payment_method ThreeDSecureAuthentication#payment_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PaymentMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Hash used to generate the PaymentMethod to be used for this Authentication.</summary>
            /// <remarks>
            /// This is mutually exclusive with the <c>payment_method</c> parameter.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#payment_method_data ThreeDSecureAuthentication#payment_method_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paymentMethodData", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodData\"}", isOptional: true)]
            public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodData? PaymentMethodData
            {
                get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodData?>();
            }

            /// <summary>The reason for invoking this 3DS Authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#reason ThreeDSecureAuthentication#reason}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Reason
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Contains details about the shipping address for a 3DS Authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#shipping_address ThreeDSecureAuthentication#shipping_address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shippingAddress", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationShippingAddress\"}", isOptional: true)]
            public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationShippingAddress? ShippingAddress
            {
                get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationShippingAddress?>();
            }

            /// <summary>Set to `always` to skip the fingerprinting step and submit this Authentication immediately or `if_fingerprinting_not_supported` to submit this Authentication only if fingerprinting is not available.</summary>
            /// <remarks>
            /// This parameter defaults to <c>never</c>.
            ///
            /// Refer to the <a href="/payments/3d-secure/standalone-3d-secure#submit-at-creation">Submit at creation section of the standalone 3DS guide</a> for more information.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#submit ThreeDSecureAuthentication#submit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "submit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Submit
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
