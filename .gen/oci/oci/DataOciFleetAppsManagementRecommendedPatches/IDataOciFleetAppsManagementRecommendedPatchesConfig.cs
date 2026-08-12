using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementRecommendedPatches
{
    [JsiiInterface(nativeType: typeof(IDataOciFleetAppsManagementRecommendedPatchesConfig), fullyQualifiedName: "oci.dataOciFleetAppsManagementRecommendedPatches.DataOciFleetAppsManagementRecommendedPatchesConfig")]
    public interface IDataOciFleetAppsManagementRecommendedPatchesConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/fleet_apps_management_recommended_patches#compartment_id DataOciFleetAppsManagementRecommendedPatches#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/fleet_apps_management_recommended_patches#filter DataOciFleetAppsManagementRecommendedPatches#filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciFleetAppsManagementRecommendedPatches.IDataOciFleetAppsManagementRecommendedPatchesFilter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciFleetAppsManagementRecommendedPatches.DataOciFleetAppsManagementRecommendedPatchesFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/fleet_apps_management_recommended_patches#id DataOciFleetAppsManagementRecommendedPatches#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/fleet_apps_management_recommended_patches#patch_id DataOciFleetAppsManagementRecommendedPatches#patch_id}.</summary>
        [JsiiProperty(name: "patchId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PatchId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/fleet_apps_management_recommended_patches#patch_level DataOciFleetAppsManagementRecommendedPatches#patch_level}.</summary>
        [JsiiProperty(name: "patchLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PatchLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/fleet_apps_management_recommended_patches#patch_type DataOciFleetAppsManagementRecommendedPatches#patch_type}.</summary>
        [JsiiProperty(name: "patchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PatchType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/fleet_apps_management_recommended_patches#severity DataOciFleetAppsManagementRecommendedPatches#severity}.</summary>
        [JsiiProperty(name: "severity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Severity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/fleet_apps_management_recommended_patches#target_id DataOciFleetAppsManagementRecommendedPatches#target_id}.</summary>
        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/fleet_apps_management_recommended_patches#target_name DataOciFleetAppsManagementRecommendedPatches#target_name}.</summary>
        [JsiiProperty(name: "targetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciFleetAppsManagementRecommendedPatchesConfig), fullyQualifiedName: "oci.dataOciFleetAppsManagementRecommendedPatches.DataOciFleetAppsManagementRecommendedPatchesConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciFleetAppsManagementRecommendedPatches.IDataOciFleetAppsManagementRecommendedPatchesConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/fleet_apps_management_recommended_patches#compartment_id DataOciFleetAppsManagementRecommendedPatches#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/fleet_apps_management_recommended_patches#filter DataOciFleetAppsManagementRecommendedPatches#filter}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciFleetAppsManagementRecommendedPatches.IDataOciFleetAppsManagementRecommendedPatchesFilter" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciFleetAppsManagementRecommendedPatches.DataOciFleetAppsManagementRecommendedPatchesFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Filter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/fleet_apps_management_recommended_patches#id DataOciFleetAppsManagementRecommendedPatches#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/fleet_apps_management_recommended_patches#patch_id DataOciFleetAppsManagementRecommendedPatches#patch_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "patchId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PatchId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/fleet_apps_management_recommended_patches#patch_level DataOciFleetAppsManagementRecommendedPatches#patch_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "patchLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PatchLevel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/fleet_apps_management_recommended_patches#patch_type DataOciFleetAppsManagementRecommendedPatches#patch_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "patchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PatchType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/fleet_apps_management_recommended_patches#severity DataOciFleetAppsManagementRecommendedPatches#severity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "severity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Severity
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/fleet_apps_management_recommended_patches#target_id DataOciFleetAppsManagementRecommendedPatches#target_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/fleet_apps_management_recommended_patches#target_name DataOciFleetAppsManagementRecommendedPatches#target_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetName
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
