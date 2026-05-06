using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseSchedulingPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseSchedulingPolicy.DatabaseSchedulingPolicyCadenceStartMonth")]
    public class DatabaseSchedulingPolicyCadenceStartMonth : oci.DatabaseSchedulingPolicy.IDatabaseSchedulingPolicyCadenceStartMonth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy#name DatabaseSchedulingPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
