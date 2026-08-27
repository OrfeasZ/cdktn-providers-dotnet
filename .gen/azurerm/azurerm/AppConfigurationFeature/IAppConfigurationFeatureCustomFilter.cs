using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppConfigurationFeature
{
    [JsiiInterface(nativeType: typeof(IAppConfigurationFeatureCustomFilter), fullyQualifiedName: "azurerm.appConfigurationFeature.AppConfigurationFeatureCustomFilter")]
    public interface IAppConfigurationFeatureCustomFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/app_configuration_feature#name AppConfigurationFeature#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/app_configuration_feature#parameters AppConfigurationFeature#parameters}.</summary>
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppConfigurationFeatureCustomFilter), fullyQualifiedName: "azurerm.appConfigurationFeature.AppConfigurationFeatureCustomFilter")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppConfigurationFeature.IAppConfigurationFeatureCustomFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/app_configuration_feature#name AppConfigurationFeature#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/app_configuration_feature#parameters AppConfigurationFeature#parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Parameters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
