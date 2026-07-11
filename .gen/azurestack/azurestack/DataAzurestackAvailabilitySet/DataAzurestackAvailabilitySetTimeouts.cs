using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackAvailabilitySet
{
    [JsiiByValue(fqn: "azurestack.dataAzurestackAvailabilitySet.DataAzurestackAvailabilitySetTimeouts")]
    public class DataAzurestackAvailabilitySetTimeouts : azurestack.DataAzurestackAvailabilitySet.IDataAzurestackAvailabilitySetTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/availability_set#read DataAzurestackAvailabilitySet#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
