using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.MongodbInstance
{
    [JsiiByValue(fqn: "scaleway.mongodbInstance.MongodbInstancePublicNetwork")]
    public class MongodbInstancePublicNetwork : scaleway.MongodbInstance.IMongodbInstancePublicNetwork
    {
        /// <summary>The DNS record of your endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#dns_record MongodbInstance#dns_record}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dnsRecord", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DnsRecord
        {
            get;
            set;
        }

        /// <summary>ID of the public network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#id MongodbInstance#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>TCP port of the endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#port MongodbInstance#port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }
    }
}
