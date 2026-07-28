using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiByValue(fqn: "azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricImage")]
    public class ManagedDevopsPoolVirtualMachineScaleSetFabricImage : azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricImage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_devops_pool#aliases ManagedDevopsPool#aliases}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "aliases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Aliases
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_devops_pool#buffer ManagedDevopsPool#buffer}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "buffer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Buffer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_devops_pool#id ManagedDevopsPool#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_devops_pool#well_known_image_name ManagedDevopsPool#well_known_image_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "wellKnownImageName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WellKnownImageName
        {
            get;
            set;
        }
    }
}
