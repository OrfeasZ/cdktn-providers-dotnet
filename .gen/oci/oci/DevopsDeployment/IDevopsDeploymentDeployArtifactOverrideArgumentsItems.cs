using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployment
{
    [JsiiInterface(nativeType: typeof(IDevopsDeploymentDeployArtifactOverrideArgumentsItems), fullyQualifiedName: "oci.devopsDeployment.DevopsDeploymentDeployArtifactOverrideArgumentsItems")]
    public interface IDevopsDeploymentDeployArtifactOverrideArgumentsItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#deploy_artifact_id DevopsDeployment#deploy_artifact_id}.</summary>
        [JsiiProperty(name: "deployArtifactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeployArtifactId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#name DevopsDeployment#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#value DevopsDeployment#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsDeploymentDeployArtifactOverrideArgumentsItems), fullyQualifiedName: "oci.devopsDeployment.DevopsDeploymentDeployArtifactOverrideArgumentsItems")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsDeployment.IDevopsDeploymentDeployArtifactOverrideArgumentsItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#deploy_artifact_id DevopsDeployment#deploy_artifact_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deployArtifactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeployArtifactId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#name DevopsDeployment#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#value DevopsDeployment#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
