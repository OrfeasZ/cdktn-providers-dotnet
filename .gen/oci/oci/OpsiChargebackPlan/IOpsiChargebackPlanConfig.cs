using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpsiChargebackPlan
{
    [JsiiInterface(nativeType: typeof(IOpsiChargebackPlanConfig), fullyQualifiedName: "oci.opsiChargebackPlan.OpsiChargebackPlanConfig")]
    public interface IOpsiChargebackPlanConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/opsi_chargeback_plan#compartment_id OpsiChargebackPlan#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/opsi_chargeback_plan#entity_source OpsiChargebackPlan#entity_source}.</summary>
        [JsiiProperty(name: "entitySource", typeJson: "{\"primitive\":\"string\"}")]
        string EntitySource
        {
            get;
        }

        /// <summary>plan_custom_items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/opsi_chargeback_plan#plan_custom_items OpsiChargebackPlan#plan_custom_items}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OpsiChargebackPlan.IOpsiChargebackPlanPlanCustomItems" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "planCustomItems", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.opsiChargebackPlan.OpsiChargebackPlanPlanCustomItems\"},\"kind\":\"array\"}}]}}")]
        object PlanCustomItems
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/opsi_chargeback_plan#plan_description OpsiChargebackPlan#plan_description}.</summary>
        [JsiiProperty(name: "planDescription", typeJson: "{\"primitive\":\"string\"}")]
        string PlanDescription
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/opsi_chargeback_plan#plan_name OpsiChargebackPlan#plan_name}.</summary>
        [JsiiProperty(name: "planName", typeJson: "{\"primitive\":\"string\"}")]
        string PlanName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/opsi_chargeback_plan#plan_type OpsiChargebackPlan#plan_type}.</summary>
        [JsiiProperty(name: "planType", typeJson: "{\"primitive\":\"string\"}")]
        string PlanType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/opsi_chargeback_plan#defined_tags OpsiChargebackPlan#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/opsi_chargeback_plan#freeform_tags OpsiChargebackPlan#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/opsi_chargeback_plan#id OpsiChargebackPlan#id}.</summary>
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

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/opsi_chargeback_plan#timeouts OpsiChargebackPlan#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.opsiChargebackPlan.OpsiChargebackPlanTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OpsiChargebackPlan.IOpsiChargebackPlanTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsiChargebackPlanConfig), fullyQualifiedName: "oci.opsiChargebackPlan.OpsiChargebackPlanConfig")]
        internal sealed class _Proxy : DeputyBase, oci.OpsiChargebackPlan.IOpsiChargebackPlanConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/opsi_chargeback_plan#compartment_id OpsiChargebackPlan#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/opsi_chargeback_plan#entity_source OpsiChargebackPlan#entity_source}.</summary>
            [JsiiProperty(name: "entitySource", typeJson: "{\"primitive\":\"string\"}")]
            public string EntitySource
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>plan_custom_items block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/opsi_chargeback_plan#plan_custom_items OpsiChargebackPlan#plan_custom_items}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OpsiChargebackPlan.IOpsiChargebackPlanPlanCustomItems" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "planCustomItems", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.opsiChargebackPlan.OpsiChargebackPlanPlanCustomItems\"},\"kind\":\"array\"}}]}}")]
            public object PlanCustomItems
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/opsi_chargeback_plan#plan_description OpsiChargebackPlan#plan_description}.</summary>
            [JsiiProperty(name: "planDescription", typeJson: "{\"primitive\":\"string\"}")]
            public string PlanDescription
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/opsi_chargeback_plan#plan_name OpsiChargebackPlan#plan_name}.</summary>
            [JsiiProperty(name: "planName", typeJson: "{\"primitive\":\"string\"}")]
            public string PlanName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/opsi_chargeback_plan#plan_type OpsiChargebackPlan#plan_type}.</summary>
            [JsiiProperty(name: "planType", typeJson: "{\"primitive\":\"string\"}")]
            public string PlanType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/opsi_chargeback_plan#defined_tags OpsiChargebackPlan#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/opsi_chargeback_plan#freeform_tags OpsiChargebackPlan#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/opsi_chargeback_plan#id OpsiChargebackPlan#id}.</summary>
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

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/opsi_chargeback_plan#timeouts OpsiChargebackPlan#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.opsiChargebackPlan.OpsiChargebackPlanTimeouts\"}", isOptional: true)]
            public oci.OpsiChargebackPlan.IOpsiChargebackPlanTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.OpsiChargebackPlan.IOpsiChargebackPlanTimeouts?>();
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
