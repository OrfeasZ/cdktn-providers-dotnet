using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.MongodbInstance
{
    [JsiiInterface(nativeType: typeof(IMongodbInstancePrivateNetwork), fullyQualifiedName: "scaleway.mongodbInstance.MongodbInstancePrivateNetwork")]
    public interface IMongodbInstancePrivateNetwork
    {
        /// <summary>The private network ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/mongodb_instance#pn_id MongodbInstance#pn_id}
        /// </remarks>
        [JsiiProperty(name: "pnId", typeJson: "{\"primitive\":\"string\"}")]
        string PnId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMongodbInstancePrivateNetwork), fullyQualifiedName: "scaleway.mongodbInstance.MongodbInstancePrivateNetwork")]
        internal sealed class _Proxy : DeputyBase, scaleway.MongodbInstance.IMongodbInstancePrivateNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The private network ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/mongodb_instance#pn_id MongodbInstance#pn_id}
            /// </remarks>
            [JsiiProperty(name: "pnId", typeJson: "{\"primitive\":\"string\"}")]
            public string PnId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
