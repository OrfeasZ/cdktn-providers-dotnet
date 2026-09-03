using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourceProviderFeatureRegistration
{
    [JsiiInterface(nativeType: typeof(IResourceProviderFeatureRegistrationTimeouts), fullyQualifiedName: "azurerm.resourceProviderFeatureRegistration.ResourceProviderFeatureRegistrationTimeouts")]
    public interface IResourceProviderFeatureRegistrationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_provider_feature_registration#create ResourceProviderFeatureRegistration#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_provider_feature_registration#delete ResourceProviderFeatureRegistration#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_provider_feature_registration#read ResourceProviderFeatureRegistration#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IResourceProviderFeatureRegistrationTimeouts), fullyQualifiedName: "azurerm.resourceProviderFeatureRegistration.ResourceProviderFeatureRegistrationTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.ResourceProviderFeatureRegistration.IResourceProviderFeatureRegistrationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_provider_feature_registration#create ResourceProviderFeatureRegistration#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_provider_feature_registration#delete ResourceProviderFeatureRegistration#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_provider_feature_registration#read ResourceProviderFeatureRegistration#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
