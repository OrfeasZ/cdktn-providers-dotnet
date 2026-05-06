using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployStage
{
    [JsiiInterface(nativeType: typeof(IDevopsDeployStageContainerConfig), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageContainerConfig")]
    public interface IDevopsDeployStageContainerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#container_config_type DevopsDeployStage#container_config_type}.</summary>
        [JsiiProperty(name: "containerConfigType", typeJson: "{\"primitive\":\"string\"}")]
        string ContainerConfigType
        {
            get;
        }

        /// <summary>network_channel block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#network_channel DevopsDeployStage#network_channel}
        /// </remarks>
        [JsiiProperty(name: "networkChannel", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageContainerConfigNetworkChannel\"}")]
        oci.DevopsDeployStage.IDevopsDeployStageContainerConfigNetworkChannel NetworkChannel
        {
            get;
        }

        /// <summary>shape_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#shape_config DevopsDeployStage#shape_config}
        /// </remarks>
        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageContainerConfigShapeConfig\"}")]
        oci.DevopsDeployStage.IDevopsDeployStageContainerConfigShapeConfig ShapeConfig
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#shape_name DevopsDeployStage#shape_name}.</summary>
        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}")]
        string ShapeName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#availability_domain DevopsDeployStage#availability_domain}.</summary>
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilityDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#compartment_id DevopsDeployStage#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompartmentId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsDeployStageContainerConfig), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageContainerConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsDeployStage.IDevopsDeployStageContainerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#container_config_type DevopsDeployStage#container_config_type}.</summary>
            [JsiiProperty(name: "containerConfigType", typeJson: "{\"primitive\":\"string\"}")]
            public string ContainerConfigType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>network_channel block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#network_channel DevopsDeployStage#network_channel}
            /// </remarks>
            [JsiiProperty(name: "networkChannel", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageContainerConfigNetworkChannel\"}")]
            public oci.DevopsDeployStage.IDevopsDeployStageContainerConfigNetworkChannel NetworkChannel
            {
                get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageContainerConfigNetworkChannel>()!;
            }

            /// <summary>shape_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#shape_config DevopsDeployStage#shape_config}
            /// </remarks>
            [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageContainerConfigShapeConfig\"}")]
            public oci.DevopsDeployStage.IDevopsDeployStageContainerConfigShapeConfig ShapeConfig
            {
                get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageContainerConfigShapeConfig>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#shape_name DevopsDeployStage#shape_name}.</summary>
            [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}")]
            public string ShapeName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#availability_domain DevopsDeployStage#availability_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilityDomain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#compartment_id DevopsDeployStage#compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompartmentId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
