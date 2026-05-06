using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ObjectstoragePrivateEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.objectstoragePrivateEndpoint.ObjectstoragePrivateEndpointAccessTargets")]
    public class ObjectstoragePrivateEndpointAccessTargets : oci.ObjectstoragePrivateEndpoint.IObjectstoragePrivateEndpointAccessTargets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_private_endpoint#bucket ObjectstoragePrivateEndpoint#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_private_endpoint#compartment_id ObjectstoragePrivateEndpoint#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public string CompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_private_endpoint#namespace ObjectstoragePrivateEndpoint#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public string Namespace
        {
            get;
            set;
        }
    }
}
