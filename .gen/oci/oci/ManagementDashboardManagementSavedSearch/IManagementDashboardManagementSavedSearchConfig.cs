using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ManagementDashboardManagementSavedSearch
{
    [JsiiInterface(nativeType: typeof(IManagementDashboardManagementSavedSearchConfig), fullyQualifiedName: "oci.managementDashboardManagementSavedSearch.ManagementDashboardManagementSavedSearchConfig")]
    public interface IManagementDashboardManagementSavedSearchConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#compartment_id ManagementDashboardManagementSavedSearch#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#data_config ManagementDashboardManagementSavedSearch#data_config}.</summary>
        [JsiiProperty(name: "dataConfig", typeJson: "{\"primitive\":\"string\"}")]
        string DataConfig
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#description ManagementDashboardManagementSavedSearch#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        string Description
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#display_name ManagementDashboardManagementSavedSearch#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#drilldown_config ManagementDashboardManagementSavedSearch#drilldown_config}.</summary>
        [JsiiProperty(name: "drilldownConfig", typeJson: "{\"primitive\":\"string\"}")]
        string DrilldownConfig
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#is_oob_saved_search ManagementDashboardManagementSavedSearch#is_oob_saved_search}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isOobSavedSearch", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsOobSavedSearch
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#metadata_version ManagementDashboardManagementSavedSearch#metadata_version}.</summary>
        [JsiiProperty(name: "metadataVersion", typeJson: "{\"primitive\":\"string\"}")]
        string MetadataVersion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#nls ManagementDashboardManagementSavedSearch#nls}.</summary>
        [JsiiProperty(name: "nls", typeJson: "{\"primitive\":\"string\"}")]
        string Nls
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#parameters_config ManagementDashboardManagementSavedSearch#parameters_config}.</summary>
        [JsiiProperty(name: "parametersConfig", typeJson: "{\"primitive\":\"string\"}")]
        string ParametersConfig
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#provider_id ManagementDashboardManagementSavedSearch#provider_id}.</summary>
        [JsiiProperty(name: "providerId", typeJson: "{\"primitive\":\"string\"}")]
        string ProviderId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#provider_name ManagementDashboardManagementSavedSearch#provider_name}.</summary>
        [JsiiProperty(name: "providerName", typeJson: "{\"primitive\":\"string\"}")]
        string ProviderName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#provider_version ManagementDashboardManagementSavedSearch#provider_version}.</summary>
        [JsiiProperty(name: "providerVersion", typeJson: "{\"primitive\":\"string\"}")]
        string ProviderVersion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#screen_image ManagementDashboardManagementSavedSearch#screen_image}.</summary>
        [JsiiProperty(name: "screenImage", typeJson: "{\"primitive\":\"string\"}")]
        string ScreenImage
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#type ManagementDashboardManagementSavedSearch#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#ui_config ManagementDashboardManagementSavedSearch#ui_config}.</summary>
        [JsiiProperty(name: "uiConfig", typeJson: "{\"primitive\":\"string\"}")]
        string UiConfig
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#widget_template ManagementDashboardManagementSavedSearch#widget_template}.</summary>
        [JsiiProperty(name: "widgetTemplate", typeJson: "{\"primitive\":\"string\"}")]
        string WidgetTemplate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#widget_vm ManagementDashboardManagementSavedSearch#widget_vm}.</summary>
        [JsiiProperty(name: "widgetVm", typeJson: "{\"primitive\":\"string\"}")]
        string WidgetVm
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#defined_tags ManagementDashboardManagementSavedSearch#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#freeform_tags ManagementDashboardManagementSavedSearch#freeform_tags}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, Dictionary&lt;string, string&gt;&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#id ManagementDashboardManagementSavedSearch#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#timeouts ManagementDashboardManagementSavedSearch#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.managementDashboardManagementSavedSearch.ManagementDashboardManagementSavedSearchTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ManagementDashboardManagementSavedSearch.IManagementDashboardManagementSavedSearchTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagementDashboardManagementSavedSearchConfig), fullyQualifiedName: "oci.managementDashboardManagementSavedSearch.ManagementDashboardManagementSavedSearchConfig")]
        internal sealed class _Proxy : DeputyBase, oci.ManagementDashboardManagementSavedSearch.IManagementDashboardManagementSavedSearchConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#compartment_id ManagementDashboardManagementSavedSearch#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#data_config ManagementDashboardManagementSavedSearch#data_config}.</summary>
            [JsiiProperty(name: "dataConfig", typeJson: "{\"primitive\":\"string\"}")]
            public string DataConfig
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#description ManagementDashboardManagementSavedSearch#description}.</summary>
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
            public string Description
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#display_name ManagementDashboardManagementSavedSearch#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#drilldown_config ManagementDashboardManagementSavedSearch#drilldown_config}.</summary>
            [JsiiProperty(name: "drilldownConfig", typeJson: "{\"primitive\":\"string\"}")]
            public string DrilldownConfig
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#is_oob_saved_search ManagementDashboardManagementSavedSearch#is_oob_saved_search}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "isOobSavedSearch", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsOobSavedSearch
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#metadata_version ManagementDashboardManagementSavedSearch#metadata_version}.</summary>
            [JsiiProperty(name: "metadataVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string MetadataVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#nls ManagementDashboardManagementSavedSearch#nls}.</summary>
            [JsiiProperty(name: "nls", typeJson: "{\"primitive\":\"string\"}")]
            public string Nls
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#parameters_config ManagementDashboardManagementSavedSearch#parameters_config}.</summary>
            [JsiiProperty(name: "parametersConfig", typeJson: "{\"primitive\":\"string\"}")]
            public string ParametersConfig
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#provider_id ManagementDashboardManagementSavedSearch#provider_id}.</summary>
            [JsiiProperty(name: "providerId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProviderId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#provider_name ManagementDashboardManagementSavedSearch#provider_name}.</summary>
            [JsiiProperty(name: "providerName", typeJson: "{\"primitive\":\"string\"}")]
            public string ProviderName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#provider_version ManagementDashboardManagementSavedSearch#provider_version}.</summary>
            [JsiiProperty(name: "providerVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string ProviderVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#screen_image ManagementDashboardManagementSavedSearch#screen_image}.</summary>
            [JsiiProperty(name: "screenImage", typeJson: "{\"primitive\":\"string\"}")]
            public string ScreenImage
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#type ManagementDashboardManagementSavedSearch#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#ui_config ManagementDashboardManagementSavedSearch#ui_config}.</summary>
            [JsiiProperty(name: "uiConfig", typeJson: "{\"primitive\":\"string\"}")]
            public string UiConfig
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#widget_template ManagementDashboardManagementSavedSearch#widget_template}.</summary>
            [JsiiProperty(name: "widgetTemplate", typeJson: "{\"primitive\":\"string\"}")]
            public string WidgetTemplate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#widget_vm ManagementDashboardManagementSavedSearch#widget_vm}.</summary>
            [JsiiProperty(name: "widgetVm", typeJson: "{\"primitive\":\"string\"}")]
            public string WidgetVm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#defined_tags ManagementDashboardManagementSavedSearch#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#freeform_tags ManagementDashboardManagementSavedSearch#freeform_tags}.</summary>
            /// <remarks>
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, Dictionary&lt;string, string&gt;&gt;</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? FreeformTags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#id ManagementDashboardManagementSavedSearch#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/management_dashboard_management_saved_search#timeouts ManagementDashboardManagementSavedSearch#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.managementDashboardManagementSavedSearch.ManagementDashboardManagementSavedSearchTimeouts\"}", isOptional: true)]
            public oci.ManagementDashboardManagementSavedSearch.IManagementDashboardManagementSavedSearchTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.ManagementDashboardManagementSavedSearch.IManagementDashboardManagementSavedSearchTimeouts?>();
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
