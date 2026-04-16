using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.MongodbInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.mongodbInstance.MongodbInstancePrivateNetwork")]
    public class MongodbInstancePrivateNetwork : scaleway.MongodbInstance.IMongodbInstancePrivateNetwork
    {
        /// <summary>The private network ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#pn_id MongodbInstance#pn_id}
        /// </remarks>
        [JsiiProperty(name: "pnId", typeJson: "{\"primitive\":\"string\"}")]
        public string PnId
        {
            get;
            set;
        }
    }
}
