using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DatawarehouseDeployment
{
    [JsiiInterface(nativeType: typeof(IDatawarehouseDeploymentPrivateNetwork), fullyQualifiedName: "scaleway.datawarehouseDeployment.DatawarehouseDeploymentPrivateNetwork")]
    public interface IDatawarehouseDeploymentPrivateNetwork
    {
        /// <summary>The private network ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/datawarehouse_deployment#pn_id DatawarehouseDeployment#pn_id}
        /// </remarks>
        [JsiiProperty(name: "pnId", typeJson: "{\"primitive\":\"string\"}")]
        string PnId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatawarehouseDeploymentPrivateNetwork), fullyQualifiedName: "scaleway.datawarehouseDeployment.DatawarehouseDeploymentPrivateNetwork")]
        internal sealed class _Proxy : DeputyBase, scaleway.DatawarehouseDeployment.IDatawarehouseDeploymentPrivateNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The private network ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/datawarehouse_deployment#pn_id DatawarehouseDeployment#pn_id}
            /// </remarks>
            [JsiiProperty(name: "pnId", typeJson: "{\"primitive\":\"string\"}")]
            public string PnId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
