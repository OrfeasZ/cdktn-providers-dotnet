using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.Provider
{
    [JsiiInterface(nativeType: typeof(IAzurestackProviderFeatures), fullyQualifiedName: "azurestack.provider.AzurestackProviderFeatures")]
    public interface IAzurestackProviderFeatures
    {
        /// <summary>resource_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#resource_group AzurestackProvider#resource_group}
        /// </remarks>
        [JsiiProperty(name: "resourceGroup", typeJson: "{\"fqn\":\"azurestack.provider.AzurestackProviderFeaturesResourceGroup\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.Provider.IAzurestackProviderFeaturesResourceGroup? ResourceGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>virtual_machine block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#virtual_machine AzurestackProvider#virtual_machine}
        /// </remarks>
        [JsiiProperty(name: "virtualMachine", typeJson: "{\"fqn\":\"azurestack.provider.AzurestackProviderFeaturesVirtualMachine\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.Provider.IAzurestackProviderFeaturesVirtualMachine? VirtualMachine
        {
            get
            {
                return null;
            }
        }

        /// <summary>virtual_machine_scale_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#virtual_machine_scale_set AzurestackProvider#virtual_machine_scale_set}
        /// </remarks>
        [JsiiProperty(name: "virtualMachineScaleSet", typeJson: "{\"fqn\":\"azurestack.provider.AzurestackProviderFeaturesVirtualMachineScaleSet\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.Provider.IAzurestackProviderFeaturesVirtualMachineScaleSet? VirtualMachineScaleSet
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAzurestackProviderFeatures), fullyQualifiedName: "azurestack.provider.AzurestackProviderFeatures")]
        internal sealed class _Proxy : DeputyBase, azurestack.Provider.IAzurestackProviderFeatures
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>resource_group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#resource_group AzurestackProvider#resource_group}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceGroup", typeJson: "{\"fqn\":\"azurestack.provider.AzurestackProviderFeaturesResourceGroup\"}", isOptional: true)]
            public azurestack.Provider.IAzurestackProviderFeaturesResourceGroup? ResourceGroup
            {
                get => GetInstanceProperty<azurestack.Provider.IAzurestackProviderFeaturesResourceGroup?>();
            }

            /// <summary>virtual_machine block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#virtual_machine AzurestackProvider#virtual_machine}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "virtualMachine", typeJson: "{\"fqn\":\"azurestack.provider.AzurestackProviderFeaturesVirtualMachine\"}", isOptional: true)]
            public azurestack.Provider.IAzurestackProviderFeaturesVirtualMachine? VirtualMachine
            {
                get => GetInstanceProperty<azurestack.Provider.IAzurestackProviderFeaturesVirtualMachine?>();
            }

            /// <summary>virtual_machine_scale_set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#virtual_machine_scale_set AzurestackProvider#virtual_machine_scale_set}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "virtualMachineScaleSet", typeJson: "{\"fqn\":\"azurestack.provider.AzurestackProviderFeaturesVirtualMachineScaleSet\"}", isOptional: true)]
            public azurestack.Provider.IAzurestackProviderFeaturesVirtualMachineScaleSet? VirtualMachineScaleSet
            {
                get => GetInstanceProperty<azurestack.Provider.IAzurestackProviderFeaturesVirtualMachineScaleSet?>();
            }
        }
    }
}
