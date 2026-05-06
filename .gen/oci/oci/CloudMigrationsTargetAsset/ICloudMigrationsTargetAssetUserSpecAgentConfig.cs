using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudMigrationsTargetAsset
{
    [JsiiInterface(nativeType: typeof(ICloudMigrationsTargetAssetUserSpecAgentConfig), fullyQualifiedName: "oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecAgentConfig")]
    public interface ICloudMigrationsTargetAssetUserSpecAgentConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#are_all_plugins_disabled CloudMigrationsTargetAsset#are_all_plugins_disabled}.</summary>
        [JsiiProperty(name: "areAllPluginsDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AreAllPluginsDisabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#is_management_disabled CloudMigrationsTargetAsset#is_management_disabled}.</summary>
        [JsiiProperty(name: "isManagementDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsManagementDisabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#is_monitoring_disabled CloudMigrationsTargetAsset#is_monitoring_disabled}.</summary>
        [JsiiProperty(name: "isMonitoringDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsMonitoringDisabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>plugins_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#plugins_config CloudMigrationsTargetAsset#plugins_config}
        /// </remarks>
        [JsiiProperty(name: "pluginsConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecAgentConfigPluginsConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PluginsConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudMigrationsTargetAssetUserSpecAgentConfig), fullyQualifiedName: "oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecAgentConfig")]
        internal sealed class _Proxy : DeputyBase, oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecAgentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#are_all_plugins_disabled CloudMigrationsTargetAsset#are_all_plugins_disabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "areAllPluginsDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AreAllPluginsDisabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#is_management_disabled CloudMigrationsTargetAsset#is_management_disabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isManagementDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsManagementDisabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#is_monitoring_disabled CloudMigrationsTargetAsset#is_monitoring_disabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isMonitoringDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsMonitoringDisabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>plugins_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#plugins_config CloudMigrationsTargetAsset#plugins_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pluginsConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecAgentConfigPluginsConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PluginsConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
