using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ArcMachineAutomanageConfigurationAssignment
{
    [JsiiInterface(nativeType: typeof(IArcMachineAutomanageConfigurationAssignmentTimeouts), fullyQualifiedName: "azurerm.arcMachineAutomanageConfigurationAssignment.ArcMachineAutomanageConfigurationAssignmentTimeouts")]
    public interface IArcMachineAutomanageConfigurationAssignmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/arc_machine_automanage_configuration_assignment#create ArcMachineAutomanageConfigurationAssignment#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/arc_machine_automanage_configuration_assignment#delete ArcMachineAutomanageConfigurationAssignment#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/arc_machine_automanage_configuration_assignment#read ArcMachineAutomanageConfigurationAssignment#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IArcMachineAutomanageConfigurationAssignmentTimeouts), fullyQualifiedName: "azurerm.arcMachineAutomanageConfigurationAssignment.ArcMachineAutomanageConfigurationAssignmentTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.ArcMachineAutomanageConfigurationAssignment.IArcMachineAutomanageConfigurationAssignmentTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/arc_machine_automanage_configuration_assignment#create ArcMachineAutomanageConfigurationAssignment#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/arc_machine_automanage_configuration_assignment#delete ArcMachineAutomanageConfigurationAssignment#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/arc_machine_automanage_configuration_assignment#read ArcMachineAutomanageConfigurationAssignment#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
