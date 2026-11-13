using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementInboundTransfer
{
    [JsiiInterface(nativeType: typeof(IV2MoneyManagementInboundTransferConfig), fullyQualifiedName: "stripe.v2MoneyManagementInboundTransfer.V2MoneyManagementInboundTransferConfig")]
    public interface IV2MoneyManagementInboundTransferConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The amount in specified currency that will land in the FinancialAccount balance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_inbound_transfer#amount V2MoneyManagementInboundTransfer#amount}
        /// </remarks>
        [JsiiProperty(name: "amount", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementInboundTransfer.V2MoneyManagementInboundTransferAmount\"}")]
        stripe.V2MoneyManagementInboundTransfer.IV2MoneyManagementInboundTransferAmount Amount
        {
            get;
        }

        /// <summary>A nested object containing information about the origin of the InboundTransfer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_inbound_transfer#from V2MoneyManagementInboundTransfer#from}
        /// </remarks>
        [JsiiProperty(name: "from", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementInboundTransfer.V2MoneyManagementInboundTransferFrom\"}")]
        stripe.V2MoneyManagementInboundTransfer.IV2MoneyManagementInboundTransferFrom From
        {
            get;
        }

        /// <summary>A nested object containing information about the destination of the InboundTransfer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_inbound_transfer#to V2MoneyManagementInboundTransfer#to}
        /// </remarks>
        [JsiiProperty(name: "to", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementInboundTransfer.V2MoneyManagementInboundTransferTo\"}")]
        stripe.V2MoneyManagementInboundTransfer.IV2MoneyManagementInboundTransferTo To
        {
            get;
        }

        /// <summary>A freeform text field provided by user, containing metadata.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_inbound_transfer#description V2MoneyManagementInboundTransfer#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IV2MoneyManagementInboundTransferConfig), fullyQualifiedName: "stripe.v2MoneyManagementInboundTransfer.V2MoneyManagementInboundTransferConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.V2MoneyManagementInboundTransfer.IV2MoneyManagementInboundTransferConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The amount in specified currency that will land in the FinancialAccount balance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_inbound_transfer#amount V2MoneyManagementInboundTransfer#amount}
            /// </remarks>
            [JsiiProperty(name: "amount", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementInboundTransfer.V2MoneyManagementInboundTransferAmount\"}")]
            public stripe.V2MoneyManagementInboundTransfer.IV2MoneyManagementInboundTransferAmount Amount
            {
                get => GetInstanceProperty<stripe.V2MoneyManagementInboundTransfer.IV2MoneyManagementInboundTransferAmount>()!;
            }

            /// <summary>A nested object containing information about the origin of the InboundTransfer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_inbound_transfer#from V2MoneyManagementInboundTransfer#from}
            /// </remarks>
            [JsiiProperty(name: "from", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementInboundTransfer.V2MoneyManagementInboundTransferFrom\"}")]
            public stripe.V2MoneyManagementInboundTransfer.IV2MoneyManagementInboundTransferFrom From
            {
                get => GetInstanceProperty<stripe.V2MoneyManagementInboundTransfer.IV2MoneyManagementInboundTransferFrom>()!;
            }

            /// <summary>A nested object containing information about the destination of the InboundTransfer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_inbound_transfer#to V2MoneyManagementInboundTransfer#to}
            /// </remarks>
            [JsiiProperty(name: "to", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementInboundTransfer.V2MoneyManagementInboundTransferTo\"}")]
            public stripe.V2MoneyManagementInboundTransfer.IV2MoneyManagementInboundTransferTo To
            {
                get => GetInstanceProperty<stripe.V2MoneyManagementInboundTransfer.IV2MoneyManagementInboundTransferTo>()!;
            }

            /// <summary>A freeform text field provided by user, containing metadata.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_inbound_transfer#description V2MoneyManagementInboundTransfer#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
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
