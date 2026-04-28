using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.OpensearchDeployment
{
    [JsiiInterface(nativeType: typeof(IOpensearchDeploymentVolume), fullyQualifiedName: "scaleway.opensearchDeployment.OpensearchDeploymentVolume")]
    public interface IOpensearchDeploymentVolume
    {
        /// <summary>Volume size in GB.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/opensearch_deployment#size_in_gb OpensearchDeployment#size_in_gb}
        /// </remarks>
        [JsiiProperty(name: "sizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        double SizeInGb
        {
            get;
        }

        /// <summary>Volume type (sbs_5k, sbs_15k).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/opensearch_deployment#type OpensearchDeployment#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchDeploymentVolume), fullyQualifiedName: "scaleway.opensearchDeployment.OpensearchDeploymentVolume")]
        internal sealed class _Proxy : DeputyBase, scaleway.OpensearchDeployment.IOpensearchDeploymentVolume
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Volume size in GB.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/opensearch_deployment#size_in_gb OpensearchDeployment#size_in_gb}
            /// </remarks>
            [JsiiProperty(name: "sizeInGb", typeJson: "{\"primitive\":\"number\"}")]
            public double SizeInGb
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Volume type (sbs_5k, sbs_15k).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/opensearch_deployment#type OpensearchDeployment#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
