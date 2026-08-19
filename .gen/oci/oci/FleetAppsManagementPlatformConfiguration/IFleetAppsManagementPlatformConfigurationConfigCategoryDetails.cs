using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementPlatformConfiguration
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementPlatformConfigurationConfigCategoryDetails), fullyQualifiedName: "oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetails")]
    public interface IFleetAppsManagementPlatformConfigurationConfigCategoryDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#config_category FleetAppsManagementPlatformConfiguration#config_category}.</summary>
        [JsiiProperty(name: "configCategory", typeJson: "{\"primitive\":\"string\"}")]
        string ConfigCategory
        {
            get;
        }

        /// <summary>compatible_products block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#compatible_products FleetAppsManagementPlatformConfiguration#compatible_products}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsCompatibleProducts" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "compatibleProducts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsCompatibleProducts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CompatibleProducts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#components FleetAppsManagementPlatformConfiguration#components}.</summary>
        [JsiiProperty(name: "components", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Components
        {
            get
            {
                return null;
            }
        }

        /// <summary>credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#credentials FleetAppsManagementPlatformConfiguration#credentials}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsCredentials" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "credentials", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Credentials
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#instance_id FleetAppsManagementPlatformConfiguration#instance_id}.</summary>
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#instance_name FleetAppsManagementPlatformConfiguration#instance_name}.</summary>
        [JsiiProperty(name: "instanceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#is_compliance_policy_required_for_softlink FleetAppsManagementPlatformConfiguration#is_compliance_policy_required_for_softlink}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isCompliancePolicyRequiredForSoftlink", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsCompliancePolicyRequiredForSoftlink
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#is_softlink FleetAppsManagementPlatformConfiguration#is_softlink}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isSoftlink", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsSoftlink
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#link_product_id FleetAppsManagementPlatformConfiguration#link_product_id}.</summary>
        [JsiiProperty(name: "linkProductId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LinkProductId
        {
            get
            {
                return null;
            }
        }

        /// <summary>patch_types block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#patch_types FleetAppsManagementPlatformConfiguration#patch_types}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsPatchTypes" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "patchTypes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsPatchTypes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PatchTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>products block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#products FleetAppsManagementPlatformConfiguration#products}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsProducts" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "products", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsProducts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Products
        {
            get
            {
                return null;
            }
        }

        /// <summary>sub_category_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#sub_category_details FleetAppsManagementPlatformConfiguration#sub_category_details}
        /// </remarks>
        [JsiiProperty(name: "subCategoryDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsSubCategoryDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsSubCategoryDetails? SubCategoryDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#versions FleetAppsManagementPlatformConfiguration#versions}.</summary>
        [JsiiProperty(name: "versions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Versions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementPlatformConfigurationConfigCategoryDetails), fullyQualifiedName: "oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetails")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#config_category FleetAppsManagementPlatformConfiguration#config_category}.</summary>
            [JsiiProperty(name: "configCategory", typeJson: "{\"primitive\":\"string\"}")]
            public string ConfigCategory
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>compatible_products block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#compatible_products FleetAppsManagementPlatformConfiguration#compatible_products}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsCompatibleProducts" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "compatibleProducts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsCompatibleProducts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CompatibleProducts
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#components FleetAppsManagementPlatformConfiguration#components}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "components", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Components
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>credentials block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#credentials FleetAppsManagementPlatformConfiguration#credentials}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsCredentials" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "credentials", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Credentials
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#instance_id FleetAppsManagementPlatformConfiguration#instance_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#instance_name FleetAppsManagementPlatformConfiguration#instance_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#is_compliance_policy_required_for_softlink FleetAppsManagementPlatformConfiguration#is_compliance_policy_required_for_softlink}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isCompliancePolicyRequiredForSoftlink", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsCompliancePolicyRequiredForSoftlink
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#is_softlink FleetAppsManagementPlatformConfiguration#is_softlink}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isSoftlink", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsSoftlink
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#link_product_id FleetAppsManagementPlatformConfiguration#link_product_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "linkProductId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LinkProductId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>patch_types block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#patch_types FleetAppsManagementPlatformConfiguration#patch_types}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsPatchTypes" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "patchTypes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsPatchTypes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PatchTypes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>products block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#products FleetAppsManagementPlatformConfiguration#products}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsProducts" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "products", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsProducts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Products
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>sub_category_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#sub_category_details FleetAppsManagementPlatformConfiguration#sub_category_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subCategoryDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsSubCategoryDetails\"}", isOptional: true)]
            public oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsSubCategoryDetails? SubCategoryDetails
            {
                get => GetInstanceProperty<oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsSubCategoryDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/fleet_apps_management_platform_configuration#versions FleetAppsManagementPlatformConfiguration#versions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "versions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Versions
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
