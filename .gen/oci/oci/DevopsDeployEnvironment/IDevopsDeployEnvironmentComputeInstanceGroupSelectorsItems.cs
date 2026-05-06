using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployEnvironment
{
    [JsiiInterface(nativeType: typeof(IDevopsDeployEnvironmentComputeInstanceGroupSelectorsItems), fullyQualifiedName: "oci.devopsDeployEnvironment.DevopsDeployEnvironmentComputeInstanceGroupSelectorsItems")]
    public interface IDevopsDeployEnvironmentComputeInstanceGroupSelectorsItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_environment#selector_type DevopsDeployEnvironment#selector_type}.</summary>
        [JsiiProperty(name: "selectorType", typeJson: "{\"primitive\":\"string\"}")]
        string SelectorType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_environment#compute_instance_ids DevopsDeployEnvironment#compute_instance_ids}.</summary>
        [JsiiProperty(name: "computeInstanceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ComputeInstanceIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_environment#query DevopsDeployEnvironment#query}.</summary>
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Query
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_environment#region DevopsDeployEnvironment#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsDeployEnvironmentComputeInstanceGroupSelectorsItems), fullyQualifiedName: "oci.devopsDeployEnvironment.DevopsDeployEnvironmentComputeInstanceGroupSelectorsItems")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsDeployEnvironment.IDevopsDeployEnvironmentComputeInstanceGroupSelectorsItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_environment#selector_type DevopsDeployEnvironment#selector_type}.</summary>
            [JsiiProperty(name: "selectorType", typeJson: "{\"primitive\":\"string\"}")]
            public string SelectorType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_environment#compute_instance_ids DevopsDeployEnvironment#compute_instance_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computeInstanceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ComputeInstanceIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_environment#query DevopsDeployEnvironment#query}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Query
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_environment#region DevopsDeployEnvironment#region}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
