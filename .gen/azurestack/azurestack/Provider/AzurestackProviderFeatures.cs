using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.Provider
{
    [JsiiByValue(fqn: "azurestack.provider.AzurestackProviderFeatures")]
    public class AzurestackProviderFeatures : azurestack.Provider.IAzurestackProviderFeatures
    {
        /// <summary>resource_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#resource_group AzurestackProvider#resource_group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceGroup", typeJson: "{\"fqn\":\"azurestack.provider.AzurestackProviderFeaturesResourceGroup\"}", isOptional: true)]
        public azurestack.Provider.IAzurestackProviderFeaturesResourceGroup? ResourceGroup
        {
            get;
            set;
        }

        /// <summary>virtual_machine block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#virtual_machine AzurestackProvider#virtual_machine}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualMachine", typeJson: "{\"fqn\":\"azurestack.provider.AzurestackProviderFeaturesVirtualMachine\"}", isOptional: true)]
        public azurestack.Provider.IAzurestackProviderFeaturesVirtualMachine? VirtualMachine
        {
            get;
            set;
        }

        /// <summary>virtual_machine_scale_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#virtual_machine_scale_set AzurestackProvider#virtual_machine_scale_set}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualMachineScaleSet", typeJson: "{\"fqn\":\"azurestack.provider.AzurestackProviderFeaturesVirtualMachineScaleSet\"}", isOptional: true)]
        public azurestack.Provider.IAzurestackProviderFeaturesVirtualMachineScaleSet? VirtualMachineScaleSet
        {
            get;
            set;
        }
    }
}
