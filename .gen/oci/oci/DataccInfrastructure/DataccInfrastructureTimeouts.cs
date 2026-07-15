using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataccInfrastructure
{
    [JsiiByValue(fqn: "oci.dataccInfrastructure.DataccInfrastructureTimeouts")]
    public class DataccInfrastructureTimeouts : oci.DataccInfrastructure.IDataccInfrastructureTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datacc_infrastructure#create DataccInfrastructure#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datacc_infrastructure#delete DataccInfrastructure#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datacc_infrastructure#update DataccInfrastructure#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
