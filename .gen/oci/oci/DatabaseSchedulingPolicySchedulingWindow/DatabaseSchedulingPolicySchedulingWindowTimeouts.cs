using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseSchedulingPolicySchedulingWindow
{
    [JsiiByValue(fqn: "oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowTimeouts")]
    public class DatabaseSchedulingPolicySchedulingWindowTimeouts : oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window#create DatabaseSchedulingPolicySchedulingWindow#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window#delete DatabaseSchedulingPolicySchedulingWindow#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window#update DatabaseSchedulingPolicySchedulingWindow#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
