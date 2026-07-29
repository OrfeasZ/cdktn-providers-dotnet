using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.difStack.DifStackGgcsConnectionsDifDependencies")]
    public class DifStackGgcsConnectionsDifDependencies : oci.DifStack.IDifStackGgcsConnectionsDifDependencies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/dif_stack#service_instance_id DifStack#service_instance_id}.</summary>
        [JsiiProperty(name: "serviceInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceInstanceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/dif_stack#service_type DifStack#service_type}.</summary>
        [JsiiProperty(name: "serviceType", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceType
        {
            get;
            set;
        }
    }
}
