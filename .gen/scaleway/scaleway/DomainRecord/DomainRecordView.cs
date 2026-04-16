using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRecord
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.domainRecord.DomainRecordView")]
    public class DomainRecordView : scaleway.DomainRecord.IDomainRecordView
    {
        /// <summary>The data of the view record.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_record#data DomainRecord#data}
        /// </remarks>
        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}")]
        public string Data
        {
            get;
            set;
        }

        /// <summary>The subnet of the view.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_record#subnet DomainRecord#subnet}
        /// </remarks>
        [JsiiProperty(name: "subnet", typeJson: "{\"primitive\":\"string\"}")]
        public string Subnet
        {
            get;
            set;
        }
    }
}
