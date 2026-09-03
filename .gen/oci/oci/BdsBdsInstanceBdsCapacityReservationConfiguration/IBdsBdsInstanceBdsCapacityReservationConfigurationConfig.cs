using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceBdsCapacityReservationConfiguration
{
    [JsiiInterface(nativeType: typeof(IBdsBdsInstanceBdsCapacityReservationConfigurationConfig), fullyQualifiedName: "oci.bdsBdsInstanceBdsCapacityReservationConfiguration.BdsBdsInstanceBdsCapacityReservationConfigurationConfig")]
    public interface IBdsBdsInstanceBdsCapacityReservationConfigurationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_instance_bds_capacity_reservation_configuration#bds_capacity_reservation_id BdsBdsInstanceBdsCapacityReservationConfiguration#bds_capacity_reservation_id}.</summary>
        [JsiiProperty(name: "bdsCapacityReservationId", typeJson: "{\"primitive\":\"string\"}")]
        string BdsCapacityReservationId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_instance_bds_capacity_reservation_configuration#bds_instance_id BdsBdsInstanceBdsCapacityReservationConfiguration#bds_instance_id}.</summary>
        [JsiiProperty(name: "bdsInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        string BdsInstanceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_instance_bds_capacity_reservation_configuration#display_name BdsBdsInstanceBdsCapacityReservationConfiguration#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_instance_bds_capacity_reservation_configuration#activate_trigger BdsBdsInstanceBdsCapacityReservationConfiguration#activate_trigger}.</summary>
        [JsiiProperty(name: "activateTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ActivateTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_instance_bds_capacity_reservation_configuration#deactivate_trigger BdsBdsInstanceBdsCapacityReservationConfiguration#deactivate_trigger}.</summary>
        [JsiiProperty(name: "deactivateTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DeactivateTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_instance_bds_capacity_reservation_configuration#id BdsBdsInstanceBdsCapacityReservationConfiguration#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_instance_bds_capacity_reservation_configuration#timeouts BdsBdsInstanceBdsCapacityReservationConfiguration#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceBdsCapacityReservationConfiguration.BdsBdsInstanceBdsCapacityReservationConfigurationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.BdsBdsInstanceBdsCapacityReservationConfiguration.IBdsBdsInstanceBdsCapacityReservationConfigurationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsBdsInstanceBdsCapacityReservationConfigurationConfig), fullyQualifiedName: "oci.bdsBdsInstanceBdsCapacityReservationConfiguration.BdsBdsInstanceBdsCapacityReservationConfigurationConfig")]
        internal sealed class _Proxy : DeputyBase, oci.BdsBdsInstanceBdsCapacityReservationConfiguration.IBdsBdsInstanceBdsCapacityReservationConfigurationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_instance_bds_capacity_reservation_configuration#bds_capacity_reservation_id BdsBdsInstanceBdsCapacityReservationConfiguration#bds_capacity_reservation_id}.</summary>
            [JsiiProperty(name: "bdsCapacityReservationId", typeJson: "{\"primitive\":\"string\"}")]
            public string BdsCapacityReservationId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_instance_bds_capacity_reservation_configuration#bds_instance_id BdsBdsInstanceBdsCapacityReservationConfiguration#bds_instance_id}.</summary>
            [JsiiProperty(name: "bdsInstanceId", typeJson: "{\"primitive\":\"string\"}")]
            public string BdsInstanceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_instance_bds_capacity_reservation_configuration#display_name BdsBdsInstanceBdsCapacityReservationConfiguration#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_instance_bds_capacity_reservation_configuration#activate_trigger BdsBdsInstanceBdsCapacityReservationConfiguration#activate_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "activateTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ActivateTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_instance_bds_capacity_reservation_configuration#deactivate_trigger BdsBdsInstanceBdsCapacityReservationConfiguration#deactivate_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deactivateTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DeactivateTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_instance_bds_capacity_reservation_configuration#id BdsBdsInstanceBdsCapacityReservationConfiguration#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_instance_bds_capacity_reservation_configuration#timeouts BdsBdsInstanceBdsCapacityReservationConfiguration#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceBdsCapacityReservationConfiguration.BdsBdsInstanceBdsCapacityReservationConfigurationTimeouts\"}", isOptional: true)]
            public oci.BdsBdsInstanceBdsCapacityReservationConfiguration.IBdsBdsInstanceBdsCapacityReservationConfigurationTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.BdsBdsInstanceBdsCapacityReservationConfiguration.IBdsBdsInstanceBdsCapacityReservationConfigurationTimeouts?>();
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
