using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetSoftwareUpdateFsuCycle
{
    [JsiiInterface(nativeType: typeof(IFleetSoftwareUpdateFsuCycleConfig), fullyQualifiedName: "oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleConfig")]
    public interface IFleetSoftwareUpdateFsuCycleConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#compartment_id FleetSoftwareUpdateFsuCycle#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#fsu_collection_id FleetSoftwareUpdateFsuCycle#fsu_collection_id}.</summary>
        [JsiiProperty(name: "fsuCollectionId", typeJson: "{\"primitive\":\"string\"}")]
        string FsuCollectionId
        {
            get;
        }

        /// <summary>goal_version_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#goal_version_details FleetSoftwareUpdateFsuCycle#goal_version_details}
        /// </remarks>
        [JsiiProperty(name: "goalVersionDetails", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetails\"}")]
        oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleGoalVersionDetails GoalVersionDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#type FleetSoftwareUpdateFsuCycle#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>apply_action_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#apply_action_schedule FleetSoftwareUpdateFsuCycle#apply_action_schedule}
        /// </remarks>
        [JsiiProperty(name: "applyActionSchedule", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleApplyActionSchedule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleApplyActionSchedule? ApplyActionSchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>batching_strategy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#batching_strategy FleetSoftwareUpdateFsuCycle#batching_strategy}
        /// </remarks>
        [JsiiProperty(name: "batchingStrategy", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleBatchingStrategy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleBatchingStrategy? BatchingStrategy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#defined_tags FleetSoftwareUpdateFsuCycle#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>diagnostics_collection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#diagnostics_collection FleetSoftwareUpdateFsuCycle#diagnostics_collection}
        /// </remarks>
        [JsiiProperty(name: "diagnosticsCollection", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleDiagnosticsCollection\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleDiagnosticsCollection? DiagnosticsCollection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#display_name FleetSoftwareUpdateFsuCycle#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#freeform_tags FleetSoftwareUpdateFsuCycle#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#id FleetSoftwareUpdateFsuCycle#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#is_ignore_missing_patches FleetSoftwareUpdateFsuCycle#is_ignore_missing_patches}.</summary>
        [JsiiProperty(name: "isIgnoreMissingPatches", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IsIgnoreMissingPatches
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#is_ignore_patches FleetSoftwareUpdateFsuCycle#is_ignore_patches}.</summary>
        [JsiiProperty(name: "isIgnorePatches", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsIgnorePatches
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#is_keep_placement FleetSoftwareUpdateFsuCycle#is_keep_placement}.</summary>
        [JsiiProperty(name: "isKeepPlacement", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsKeepPlacement
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#max_drain_timeout_in_seconds FleetSoftwareUpdateFsuCycle#max_drain_timeout_in_seconds}.</summary>
        [JsiiProperty(name: "maxDrainTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxDrainTimeoutInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>stage_action_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#stage_action_schedule FleetSoftwareUpdateFsuCycle#stage_action_schedule}
        /// </remarks>
        [JsiiProperty(name: "stageActionSchedule", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleStageActionSchedule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleStageActionSchedule? StageActionSchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#timeouts FleetSoftwareUpdateFsuCycle#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>upgrade_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#upgrade_details FleetSoftwareUpdateFsuCycle#upgrade_details}
        /// </remarks>
        [JsiiProperty(name: "upgradeDetails", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleUpgradeDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleUpgradeDetails? UpgradeDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetSoftwareUpdateFsuCycleConfig), fullyQualifiedName: "oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleConfig")]
        internal sealed class _Proxy : DeputyBase, oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#compartment_id FleetSoftwareUpdateFsuCycle#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#fsu_collection_id FleetSoftwareUpdateFsuCycle#fsu_collection_id}.</summary>
            [JsiiProperty(name: "fsuCollectionId", typeJson: "{\"primitive\":\"string\"}")]
            public string FsuCollectionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>goal_version_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#goal_version_details FleetSoftwareUpdateFsuCycle#goal_version_details}
            /// </remarks>
            [JsiiProperty(name: "goalVersionDetails", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetails\"}")]
            public oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleGoalVersionDetails GoalVersionDetails
            {
                get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleGoalVersionDetails>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#type FleetSoftwareUpdateFsuCycle#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>apply_action_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#apply_action_schedule FleetSoftwareUpdateFsuCycle#apply_action_schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applyActionSchedule", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleApplyActionSchedule\"}", isOptional: true)]
            public oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleApplyActionSchedule? ApplyActionSchedule
            {
                get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleApplyActionSchedule?>();
            }

            /// <summary>batching_strategy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#batching_strategy FleetSoftwareUpdateFsuCycle#batching_strategy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "batchingStrategy", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleBatchingStrategy\"}", isOptional: true)]
            public oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleBatchingStrategy? BatchingStrategy
            {
                get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleBatchingStrategy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#defined_tags FleetSoftwareUpdateFsuCycle#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>diagnostics_collection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#diagnostics_collection FleetSoftwareUpdateFsuCycle#diagnostics_collection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "diagnosticsCollection", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleDiagnosticsCollection\"}", isOptional: true)]
            public oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleDiagnosticsCollection? DiagnosticsCollection
            {
                get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleDiagnosticsCollection?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#display_name FleetSoftwareUpdateFsuCycle#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#freeform_tags FleetSoftwareUpdateFsuCycle#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#id FleetSoftwareUpdateFsuCycle#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#is_ignore_missing_patches FleetSoftwareUpdateFsuCycle#is_ignore_missing_patches}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isIgnoreMissingPatches", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IsIgnoreMissingPatches
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#is_ignore_patches FleetSoftwareUpdateFsuCycle#is_ignore_patches}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isIgnorePatches", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsIgnorePatches
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#is_keep_placement FleetSoftwareUpdateFsuCycle#is_keep_placement}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isKeepPlacement", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsKeepPlacement
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#max_drain_timeout_in_seconds FleetSoftwareUpdateFsuCycle#max_drain_timeout_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxDrainTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxDrainTimeoutInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>stage_action_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#stage_action_schedule FleetSoftwareUpdateFsuCycle#stage_action_schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stageActionSchedule", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleStageActionSchedule\"}", isOptional: true)]
            public oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleStageActionSchedule? StageActionSchedule
            {
                get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleStageActionSchedule?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#timeouts FleetSoftwareUpdateFsuCycle#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleTimeouts\"}", isOptional: true)]
            public oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleTimeouts?>();
            }

            /// <summary>upgrade_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#upgrade_details FleetSoftwareUpdateFsuCycle#upgrade_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "upgradeDetails", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleUpgradeDetails\"}", isOptional: true)]
            public oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleUpgradeDetails? UpgradeDetails
            {
                get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleUpgradeDetails?>();
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
