using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.MessageqDeployment
{
    [JsiiInterface(nativeType: typeof(IMessageqDeploymentVolume), fullyQualifiedName: "scaleway.messageqDeployment.MessageqDeploymentVolume")]
    public interface IMessageqDeploymentVolume
    {
        /// <summary>Volume size in GB. Can be updated via Upgrade without recreating the deployment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.86.0/docs/resources/messageq_deployment#size_in_gb MessageqDeployment#size_in_gb}
        /// </remarks>
        [JsiiProperty(name: "sizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        double SizeInGb
        {
            get;
        }

        /// <summary>Volume type (sbs_5k, sbs_15k).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.86.0/docs/resources/messageq_deployment#type MessageqDeployment#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMessageqDeploymentVolume), fullyQualifiedName: "scaleway.messageqDeployment.MessageqDeploymentVolume")]
        internal sealed class _Proxy : DeputyBase, scaleway.MessageqDeployment.IMessageqDeploymentVolume
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Volume size in GB. Can be updated via Upgrade without recreating the deployment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.86.0/docs/resources/messageq_deployment#size_in_gb MessageqDeployment#size_in_gb}
            /// </remarks>
            [JsiiProperty(name: "sizeInGb", typeJson: "{\"primitive\":\"number\"}")]
            public double SizeInGb
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Volume type (sbs_5k, sbs_15k).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.86.0/docs/resources/messageq_deployment#type MessageqDeployment#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
