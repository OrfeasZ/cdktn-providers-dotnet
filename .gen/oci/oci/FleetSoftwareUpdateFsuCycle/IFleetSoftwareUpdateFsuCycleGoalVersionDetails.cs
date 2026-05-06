using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetSoftwareUpdateFsuCycle
{
    [JsiiInterface(nativeType: typeof(IFleetSoftwareUpdateFsuCycleGoalVersionDetails), fullyQualifiedName: "oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetails")]
    public interface IFleetSoftwareUpdateFsuCycleGoalVersionDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#type FleetSoftwareUpdateFsuCycle#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>components block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#components FleetSoftwareUpdateFsuCycle#components}
        /// </remarks>
        [JsiiProperty(name: "components", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponents\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Components
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#home_policy FleetSoftwareUpdateFsuCycle#home_policy}.</summary>
        [JsiiProperty(name: "homePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HomePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#new_home_prefix FleetSoftwareUpdateFsuCycle#new_home_prefix}.</summary>
        [JsiiProperty(name: "newHomePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NewHomePrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#software_image_id FleetSoftwareUpdateFsuCycle#software_image_id}.</summary>
        [JsiiProperty(name: "softwareImageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SoftwareImageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#version FleetSoftwareUpdateFsuCycle#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetSoftwareUpdateFsuCycleGoalVersionDetails), fullyQualifiedName: "oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetails")]
        internal sealed class _Proxy : DeputyBase, oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleGoalVersionDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#type FleetSoftwareUpdateFsuCycle#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>components block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#components FleetSoftwareUpdateFsuCycle#components}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "components", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetailsComponents\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Components
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#home_policy FleetSoftwareUpdateFsuCycle#home_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "homePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HomePolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#new_home_prefix FleetSoftwareUpdateFsuCycle#new_home_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "newHomePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NewHomePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#software_image_id FleetSoftwareUpdateFsuCycle#software_image_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "softwareImageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SoftwareImageId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#version FleetSoftwareUpdateFsuCycle#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
