using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SavingsplansSavingsPlan
{
    [JsiiInterface(nativeType: typeof(ISavingsplansSavingsPlanConfig), fullyQualifiedName: "aws.savingsplansSavingsPlan.SavingsplansSavingsPlanConfig")]
    public interface ISavingsplansSavingsPlanConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The hourly commitment, in USD.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/savingsplans_savings_plan#commitment SavingsplansSavingsPlan#commitment}
        /// </remarks>
        [JsiiProperty(name: "commitment", typeJson: "{\"primitive\":\"string\"}")]
        string Commitment
        {
            get;
        }

        /// <summary>The unique ID of a Savings Plan offering.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/savingsplans_savings_plan#savings_plan_offering_id SavingsplansSavingsPlan#savings_plan_offering_id}
        /// </remarks>
        [JsiiProperty(name: "savingsPlanOfferingId", typeJson: "{\"primitive\":\"string\"}")]
        string SavingsPlanOfferingId
        {
            get;
        }

        /// <summary>The time at which to purchase the Savings Plan, in UTC format (YYYY-MM-DDTHH:MM:SSZ).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/savingsplans_savings_plan#purchase_time SavingsplansSavingsPlan#purchase_time}
        /// </remarks>
        [JsiiProperty(name: "purchaseTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PurchaseTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/savingsplans_savings_plan#tags SavingsplansSavingsPlan#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/savingsplans_savings_plan#timeouts SavingsplansSavingsPlan#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.savingsplansSavingsPlan.SavingsplansSavingsPlanTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SavingsplansSavingsPlan.ISavingsplansSavingsPlanTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>The up-front payment amount.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/savingsplans_savings_plan#upfront_payment_amount SavingsplansSavingsPlan#upfront_payment_amount}
        /// </remarks>
        [JsiiProperty(name: "upfrontPaymentAmount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UpfrontPaymentAmount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISavingsplansSavingsPlanConfig), fullyQualifiedName: "aws.savingsplansSavingsPlan.SavingsplansSavingsPlanConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SavingsplansSavingsPlan.ISavingsplansSavingsPlanConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The hourly commitment, in USD.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/savingsplans_savings_plan#commitment SavingsplansSavingsPlan#commitment}
            /// </remarks>
            [JsiiProperty(name: "commitment", typeJson: "{\"primitive\":\"string\"}")]
            public string Commitment
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The unique ID of a Savings Plan offering.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/savingsplans_savings_plan#savings_plan_offering_id SavingsplansSavingsPlan#savings_plan_offering_id}
            /// </remarks>
            [JsiiProperty(name: "savingsPlanOfferingId", typeJson: "{\"primitive\":\"string\"}")]
            public string SavingsPlanOfferingId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The time at which to purchase the Savings Plan, in UTC format (YYYY-MM-DDTHH:MM:SSZ).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/savingsplans_savings_plan#purchase_time SavingsplansSavingsPlan#purchase_time}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "purchaseTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PurchaseTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/savingsplans_savings_plan#tags SavingsplansSavingsPlan#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/savingsplans_savings_plan#timeouts SavingsplansSavingsPlan#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.savingsplansSavingsPlan.SavingsplansSavingsPlanTimeouts\"}", isOptional: true)]
            public aws.SavingsplansSavingsPlan.ISavingsplansSavingsPlanTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.SavingsplansSavingsPlan.ISavingsplansSavingsPlanTimeouts?>();
            }

            /// <summary>The up-front payment amount.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/savingsplans_savings_plan#upfront_payment_amount SavingsplansSavingsPlan#upfront_payment_amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "upfrontPaymentAmount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UpfrontPaymentAmount
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
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
