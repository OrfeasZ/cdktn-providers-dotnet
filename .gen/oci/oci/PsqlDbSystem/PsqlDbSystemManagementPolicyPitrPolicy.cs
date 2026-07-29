using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    [JsiiByValue(fqn: "oci.psqlDbSystem.PsqlDbSystemManagementPolicyPitrPolicy")]
    public class PsqlDbSystemManagementPolicyPitrPolicy : oci.PsqlDbSystem.IPsqlDbSystemManagementPolicyPitrPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/psql_db_system#kind PsqlDbSystem#kind}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Kind
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/psql_db_system#restore_days PsqlDbSystem#restore_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "restoreDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RestoreDays
        {
            get;
            set;
        }
    }
}
