using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementPlatformConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetails")]
    public class FleetAppsManagementPlatformConfigurationConfigCategoryDetails : oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_platform_configuration#config_category FleetAppsManagementPlatformConfiguration#config_category}.</summary>
        [JsiiProperty(name: "configCategory", typeJson: "{\"primitive\":\"string\"}")]
        public string ConfigCategory
        {
            get;
            set;
        }

        private object? _compatibleProducts;

        /// <summary>compatible_products block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_platform_configuration#compatible_products FleetAppsManagementPlatformConfiguration#compatible_products}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "compatibleProducts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsCompatibleProducts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CompatibleProducts
        {
            get => _compatibleProducts;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsCompatibleProducts[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsCompatibleProducts).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _compatibleProducts = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_platform_configuration#components FleetAppsManagementPlatformConfiguration#components}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "components", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Components
        {
            get;
            set;
        }

        private object? _credentials;

        /// <summary>credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_platform_configuration#credentials FleetAppsManagementPlatformConfiguration#credentials}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "credentials", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Credentials
        {
            get => _credentials;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsCredentials[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsCredentials).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _credentials = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_platform_configuration#instance_id FleetAppsManagementPlatformConfiguration#instance_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_platform_configuration#instance_name FleetAppsManagementPlatformConfiguration#instance_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceName
        {
            get;
            set;
        }

        private object? _patchTypes;

        /// <summary>patch_types block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_platform_configuration#patch_types FleetAppsManagementPlatformConfiguration#patch_types}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "patchTypes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsPatchTypes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PatchTypes
        {
            get => _patchTypes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsPatchTypes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsPatchTypes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _patchTypes = value;
            }
        }

        private object? _products;

        /// <summary>products block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_platform_configuration#products FleetAppsManagementPlatformConfiguration#products}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "products", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsProducts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Products
        {
            get => _products;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsProducts[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsProducts).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _products = value;
            }
        }

        /// <summary>sub_category_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_platform_configuration#sub_category_details FleetAppsManagementPlatformConfiguration#sub_category_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subCategoryDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsSubCategoryDetails\"}", isOptional: true)]
        public oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsSubCategoryDetails? SubCategoryDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_platform_configuration#versions FleetAppsManagementPlatformConfiguration#versions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "versions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Versions
        {
            get;
            set;
        }
    }
}
