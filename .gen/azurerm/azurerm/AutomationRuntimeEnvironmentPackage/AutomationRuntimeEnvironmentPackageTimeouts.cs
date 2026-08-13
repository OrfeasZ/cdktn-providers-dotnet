using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationRuntimeEnvironmentPackage
{
    [JsiiByValue(fqn: "azurerm.automationRuntimeEnvironmentPackage.AutomationRuntimeEnvironmentPackageTimeouts")]
    public class AutomationRuntimeEnvironmentPackageTimeouts : azurerm.AutomationRuntimeEnvironmentPackage.IAutomationRuntimeEnvironmentPackageTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/automation_runtime_environment_package#create AutomationRuntimeEnvironmentPackage#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/automation_runtime_environment_package#delete AutomationRuntimeEnvironmentPackage#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/automation_runtime_environment_package#read AutomationRuntimeEnvironmentPackage#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
