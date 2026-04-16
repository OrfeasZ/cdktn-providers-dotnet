using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.OpensearchDeployment
{
    [JsiiByValue(fqn: "scaleway.opensearchDeployment.OpensearchDeploymentTimeouts")]
    public class OpensearchDeploymentTimeouts : scaleway.OpensearchDeployment.IOpensearchDeploymentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#create OpensearchDeployment#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#delete OpensearchDeployment#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#read OpensearchDeployment#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#update OpensearchDeployment#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
