using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDrgNatPolicy
{
    [JsiiByValue(fqn: "oci.coreDrgNatPolicy.CoreDrgNatPolicyTimeouts")]
    public class CoreDrgNatPolicyTimeouts : oci.CoreDrgNatPolicy.ICoreDrgNatPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy#create CoreDrgNatPolicy#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy#delete CoreDrgNatPolicy#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy#update CoreDrgNatPolicy#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
